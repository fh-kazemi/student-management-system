using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ManageStudentForm : Form
    {
        Student student = new Student();
        public ManageStudentForm()
        {
            InitializeComponent();
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            showStudentList();
        }

        void showStudentList()
        {        
            List<Student> studentList = student.getStudentList();
            dataGrid_Student.DataSource = studentList;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGrid_Student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void dataGrid_Student_Click(object sender, EventArgs e)
        {
            student.Id = dataGrid_Student.CurrentRow.Cells[0].Value.ToString();

            txt_FirstName.Text = dataGrid_Student.CurrentRow.Cells[1].Value.ToString();
            txt_LastName.Text = dataGrid_Student.CurrentRow.Cells[2].Value.ToString();
            txt_Phone.Text = dataGrid_Student.CurrentRow.Cells[3].Value.ToString();
            dateTime_Birthdate.Value = (DateTime)dataGrid_Student.CurrentRow.Cells[4].Value;

            if(dataGrid_Student.CurrentRow.Cells[5].Value.ToString() == "Male")
            {
                radioBox_Male.Checked = true;
            }
            else
            {
                radioBox_Female.Checked = true;
            }

            txt_Address.Text = dataGrid_Student.CurrentRow.Cells[6].Value.ToString();

            byte[] img = (byte[])dataGrid_Student.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_student.Image = Image.FromStream(ms);
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

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox_student.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search.Text))
            {
                MessageBox.Show("Enter letters to search.", "Search Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<Student> studentList = student.searchStudent(txt_search.Text);
                dataGrid_Student.DataSource = studentList;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)dataGrid_Student.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                txt_search.Clear();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            student.FirstName = txt_FirstName.Text.Trim().ToLower();
            student.LastName = txt_LastName.Text.Trim().ToLower();
            student.Phone = txt_Phone.Text.Trim();
            student.BirthDate = dateTime_Birthdate.Value;
            student.Gender = radioBox_Male.Checked ? "Male" : "Female";
            student.Address = txt_Address.Text.Trim().ToLower();

            int born_year = dateTime_Birthdate.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The student age must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verifyStudent())
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);
                    student.Image = ms.ToArray();

                    if (student.updateStudent(student))
                    {
                        showStudentList();
                        MessageBox.Show("Student data updated.", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_Clear.PerformClick();
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btn_delete_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("Are you sure you want to remove this student?", "Remove Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (student.deleteStudent(student.Id))
                {
                    showStudentList();
                    MessageBox.Show("Student Removed", "Remove student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Clear.PerformClick();
                }
            }
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            showStudentList();
            btn_Clear.PerformClick();
        }

    }
}
