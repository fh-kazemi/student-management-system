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
    public partial class ManageCourseForm : Form
    {
        Course course = new Course();
        public ManageCourseForm()
        {
            InitializeComponent();
        }                

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            showCourseList();
        }
        void showCourseList()
        {
            List<Course> courseList = course.getCourseList();
            dataGrid_Course.DataSource = courseList;
        }
        
        private void dataGrid_Course_Click(object sender, EventArgs e)
        {
            course.Id = dataGrid_Course.CurrentRow.Cells[0].Value.ToString();
            txt_CourseName.Text = dataGrid_Course.CurrentRow.Cells[1].Value.ToString();
            txt_CourseHour.Text = dataGrid_Course.CurrentRow.Cells[2].Value.ToString();
            txt_Description.Text = dataGrid_Course.CurrentRow.Cells[3].Value.ToString();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Search.Text))
            {
                MessageBox.Show("Enter letters to search.", "Search Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<Course> courseList = course.searchCourse(txt_Search.Text);
                dataGrid_Course.DataSource = courseList;
                txt_Search.Clear();
            }
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            showCourseList();
            btn_Clear.PerformClick();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_CourseName.Clear();
            txt_CourseHour.Clear();
            txt_Description.Clear();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            course.CourseName = txt_CourseName.Text;
            course.CourseHour = txt_CourseHour.Text;
            course.Description = txt_Description.Text;

            if (verifyCourse())
            {
                try
                {
                    if (course.updateCourse(course))
                    {
                        showCourseList();
                        MessageBox.Show("Course data updated.", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_Clear.PerformClick();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        bool verifyCourse()
        {
            if (string.IsNullOrEmpty(txt_CourseName.Text) || string.IsNullOrWhiteSpace(txt_CourseName.Text) ||
                string.IsNullOrEmpty(txt_CourseHour.Text) || string.IsNullOrWhiteSpace(txt_CourseHour.Text) ||
                string.IsNullOrEmpty(txt_Description.Text) || string.IsNullOrWhiteSpace(txt_Description.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (course.deleteCourse(course.Id))
                {
                    showCourseList();
                    MessageBox.Show("Course Removed!", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Clear.PerformClick();
                }
            }
        }
    }
}
