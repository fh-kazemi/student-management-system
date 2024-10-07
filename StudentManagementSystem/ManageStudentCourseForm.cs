using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ManageStudentCourseForm : Form
    {
        Student student = new Student();
        Score score = new Score();
        Course course = new Course();
        public ManageStudentCourseForm()
        {
            InitializeComponent();
        }

        private void ManageStudentCourseForm_Load(object sender, EventArgs e)
        {
            showStudentList();
            showCourseNameInComboBox();
            showSemesterInComboBox();
        }

        void showStudentList()
        {
            List<Student> studentList = student.getStudentList();
            dataGrid_Student.DataSource = studentList;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGrid_Student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Search.Text))
            {
                MessageBox.Show("Enter letters to search.", "Search Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<Student> studentList = student.searchStudent(txt_Search.Text);
                dataGrid_Student.DataSource = studentList;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)dataGrid_Student.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                txt_Search.Clear();
            }
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            showStudentList();
            lbl_StudentName.Text = "";
            dataGrid_Course.DataSource = null;
            student.Id = null;
            course.Id = null;
        }

        private void dataGrid_Student_Click(object sender, EventArgs e)
        {
            btn_Clear.PerformClick();

            student.Id = dataGrid_Student.CurrentRow.Cells[0].Value.ToString();
            student.FirstName = dataGrid_Student.CurrentRow.Cells[1].Value.ToString();
            student.LastName = dataGrid_Student.CurrentRow.Cells[2].Value.ToString();
            student.Phone = dataGrid_Student.CurrentRow.Cells[3].Value.ToString();
            student.BirthDate = (DateTime) dataGrid_Student.CurrentRow.Cells[4].Value;
            student.Gender = dataGrid_Student.CurrentRow.Cells[5].Value.ToString();
            student.Address = dataGrid_Student.CurrentRow.Cells[6].Value.ToString();
            student.Image = (byte[]) dataGrid_Student.CurrentRow.Cells[7].Value;
            
            showScoreList();

            lbl_StudentName.Text = char.ToUpper(student.FirstName[0]) + student.FirstName.Substring(1).ToLower() +" "+
                                    char.ToUpper(student.LastName[0]) + student.LastName.Substring(1).ToLower();
        }

        void showScoreList()
        {
            List<Score> scoreList = score.getScoreListByStudent(student.Id);
            dataGrid_Course.DataSource =scoreList;
        }


        void showCourseNameInComboBox()
        {
            List<Course> courseList = course.getCourseList();
            
            course.CourseName = "";
            course.Id = "0";
            courseList.Insert(0, course);

            comboBox_Course.DataSource = courseList;
            comboBox_Course.DisplayMember = "coursename";
            comboBox_Course.ValueMember = "id";
            comboBox_Course.SelectedIndexChanged += (object sender, EventArgs e) =>
                {
                    if (comboBox_Course.SelectedItem != null)
                    {
                        course.Id = comboBox_Course.SelectedValue.ToString();
                    }
                };
        }

        void showSemesterInComboBox()
        {
            comboBox_Semester.Items.Add("Sem1 2024-2025");
            comboBox_Semester.Items.Add("Sem2 2024-2025");
            comboBox_Semester.Items.Add("Sem1 2025-2026");
            comboBox_Semester.Items.Add("Sem2 2025-2026");
        }

        private void btn_Add_Course_Click(object sender, EventArgs e)
        {
            if (!verify(student.Id))
            {
                MessageBox.Show("You must select a Student.","Select Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!verify(comboBox_Semester.Text))
            {
                MessageBox.Show("You must select a Semester.", "Select Semester", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!verify(course.Id))
            {
                MessageBox.Show("You must select a course.", "Select Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(verifyCourseExist(student.Id, course.Id, comboBox_Semester.Text))
            {
                MessageBox.Show("This Student has already taken this course in this semester.", "Select Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                score.StudentId = student.Id;
                score.CourseId = course.Id;
                score.Semester = comboBox_Semester.Text;

                try
                {
                    if (score.insertScore(score))
                    {
                        showScoreList();
                        MessageBox.Show("New Course for this student Added.", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_Clear.PerformClick();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        bool verify(string checkEmptyValue)
        {
            if (string.IsNullOrEmpty(checkEmptyValue))
            {                
                return false;
            }
            else
            {
                return true;
            }
        }

        bool verifyCourseExist(string studentId, string courseId, string semester)
        {
            bool check = false;
            List<Score> courseList = score.getScoreListByStudent(studentId);

            foreach (var item in courseList)
            {
                if (item.CourseId == courseId && item.Semester == semester)
                {
                    check = true;
                    break;
                }                
            }
            return check;
        }

        private void dataGrid_Course_Click(object sender, EventArgs e)
        {
            score.Id = dataGrid_Course.CurrentRow.Cells[0].Value.ToString();
            score.StudentId = dataGrid_Course.CurrentRow.Cells[1].Value.ToString();
            score.CourseId = dataGrid_Course.CurrentRow.Cells[2].Value.ToString();
            score.Semester = dataGrid_Course.CurrentRow.Cells[3].Value.ToString();
            score.value = (float) dataGrid_Course.CurrentRow.Cells[4].Value;            

            comboBox_Course.Text = course.searchCourseById(score.CourseId).CourseName.ToString(); ;
            comboBox_Semester.Text = score.Semester;
            txt_Score.Text = score.value.ToString();
        }

        private void btn_Delete_Course_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (score.deleteCourse(score.Id))
                {
                    showScoreList();
                    MessageBox.Show("This course removed for this student in this semester!", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Clear.PerformClick();
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            comboBox_Semester.Text = "";
            comboBox_Course.Text = "";
            txt_Score.Text = "";
            score.value = 0;
        }

        private void btn_Update_Semester_Click_1(object sender, EventArgs e)
        {
            score.Semester = comboBox_Semester.Text;

            if (verify(comboBox_Semester.Text))
            {
                try
                {
                    if (score.updateSemester(score))
                    {
                        showScoreList();
                        MessageBox.Show("The Semester for this course updated.", "Update Semester", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_Clear.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Value of semester is empty.", "Update Semester", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Update_Score_Click_1(object sender, EventArgs e)
        {
            score.value = float.Parse(txt_Score.Text);

            if (verify(txt_Score.Text))
            {
                try
                {
                    if (score.updateScore(score))
                    {
                        showScoreList();
                        MessageBox.Show("This score for this course updated.", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_Clear.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Value of score is empty.", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
