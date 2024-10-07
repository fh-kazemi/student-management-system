using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class LoginForm : Form
    {
        DBConnection connection = new DBConnection();
       
        public LoginForm()
        {
            InitializeComponent();
            txt_Password.UseSystemPasswordChar = true;
            btn_Hide_Pass.BringToFront();
        }

        private void lbl_ExitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_ExitForm_MouseEnter(object sender, EventArgs e)
        {
            lbl_ExitForm.ForeColor = Color.Red;
        }

        private void lbl_ExitForm_MouseLeave(object sender, EventArgs e)
        {
            lbl_ExitForm.ForeColor = Color.Transparent;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Username.Text) || string.IsNullOrWhiteSpace(txt_Username.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_Username, "Username is required!");
                txt_Username.Focus();
            }
            else if (string.IsNullOrEmpty(txt_Password.Text) || string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_Password, "Password is required!");
                txt_Password.Focus();
            }
            else
            {
                string username = txt_Username.Text.Trim().ToLower();
                string password = txt_Password.Text.Trim().ToLower();

                if(isExistAdmin(username, password))
                {
                    this.Hide();
                    MainForm main = new MainForm();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect!\nTry again...", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProvider.Clear();
                    txt_Username.Text = "";
                    txt_Password.Text = "";
                }
            }

            bool isExistAdmin(String username, string password)
            {
                try
                {
                    string query = $"SELECT * FROM tblusers " +
                                   $"WHERE username = @Username AND password = @Password;";
                    connection.openConnection();

                    SqlCommand cmd = connection.GetSqlCommand(query);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader result = cmd.ExecuteReader();

                    if (result.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    connection.closeConnection();
                }
            }
        }

        private void btn_Show_Pass_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = true;
            btn_Hide_Pass.BringToFront();
        }

        private void btn_Hide_Pass_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = false;
            btn_Show_Pass.BringToFront();
        }
    }
}
