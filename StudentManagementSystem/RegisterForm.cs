using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using System.Collections;

namespace StudentManagementSystem
{
    public partial class RegisterForm : Form
    {
        Student student = new Student();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            showStudentList();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox_student.Image = Image.FromFile(openFile.FileName);
                MemoryStream ms = new MemoryStream();
                pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);

                student.Image = ms.ToArray();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            student.FirstName = txt_FirstName.Text.Trim().ToLower();
            student.LastName = txt_LastName.Text.Trim().ToLower();
            student.Phone = txt_Phone.Text.Trim();
            student.BirthDate = dateTime_Birthdate.Value;
            student.Gender = radioBox_Male.Checked ? "Male" : "Female";
            student.Address = txt_Address.Text.Trim().ToLower();

            if (verifyStudent())
            {
                int born_year = dateTime_Birthdate.Value.Year;
                int this_year = DateTime.Now.Year;
                if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                {
                    MessageBox.Show("The student age must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        if (student.insertStudent(student))
                        {
                            showStudentList();
                            MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_Clear_Click(sender, e);
                        }
                    }
                    catch (Exception ex)

                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool verifyStudent()
        {
            if (string.IsNullOrEmpty(txt_FirstName.Text) || string.IsNullOrWhiteSpace(txt_FirstName.Text) ||
               string.IsNullOrEmpty(txt_LastName.Text) || string.IsNullOrWhiteSpace(txt_LastName.Text) ||
               string.IsNullOrEmpty(txt_Phone.Text) || string.IsNullOrWhiteSpace(txt_Phone.Text) ||
               pictureBox_student.Image == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        void showStudentList()
        {            
            List<Student> studentList = student.getStudentList();
            dataGrid_Student.DataSource = studentList;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGrid_Student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_FirstName.Clear();
            txt_LastName.Clear();
            txt_Phone.Clear();
            dateTime_Birthdate.Value = DateTime.Now;
            radioBox_Male.Checked = true;
            txt_Address.Clear();
            pictureBox_student.Image = null;

        }
    }
}
