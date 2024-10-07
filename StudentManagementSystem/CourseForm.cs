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
    public partial class CourseForm : Form
    {
        Course course = new Course();
        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            showCourseList();
        }

        void showCourseList()
        {
            List<Course> courseList = course.getCourseList();
            dataGrid_Course.DataSource = courseList;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            course.CourseName = txt_CourseName.Text.Trim().ToLower();
            course.CourseHour = txt_CourseHour.Text.Trim().ToLower();
            course.Description = txt_Description.Text.Trim().ToLower();

            if (verifyCourse())
            {
                try
                {
                    if (course.insertCourse(course))
                    {
                        showCourseList();
                        MessageBox.Show("New Course Added", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_clear.PerformClick();
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Empty Field!!", "Add Coures", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool verifyCourse() 
        {
            if(string.IsNullOrEmpty(txt_CourseName.Text) || string.IsNullOrWhiteSpace(txt_CourseName.Text) ||
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_CourseName.Clear();
            txt_CourseHour.Clear();
            txt_Description.Clear();
        }
    }
}
