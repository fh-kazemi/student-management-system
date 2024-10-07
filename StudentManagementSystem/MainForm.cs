using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class MainForm : Form
    {
        Student student = new Student();
        Course course = new Course();
        Score score = new Score();

        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }
        public void MainForm_Load(object sender, EventArgs e)
        {
            showStudentCount();
            showCourseNameInComboBox();
        }

        public void showStudentCount()
        {
            lbl_totalStd.Text = "Total Students : " + student.totalStudentCount();
            lbl_maleStd.Text = "Male : " + student.maleStudentCount();
            lbl_femaleStd.Text = "Female : " + student.femaleStudentCount();
        }

        void showCourseNameInComboBox()
        {
            List<Course> courseList =  course.getCourseList();
            course.CourseName = "";
            course.Id = "0";
            courseList.Insert(0,course);

            comboBox_Course.DataSource = courseList;
            comboBox_Course.DisplayMember = "coursename";
            comboBox_Course.ValueMember = "id";
            comboBox_Course.SelectedIndexChanged += (object sender, EventArgs e) =>
            {
                if (comboBox_Course.SelectedItem != null)
                {
                    string courseId = comboBox_Course.SelectedValue.ToString();
                    lbl_StudentInCourse.Text = "Total Student In This Course : " + score.studentCountInCourse(courseId);
                }
            };            
        }

        public void customizeDesign()
        {
            panel_stdSubmenu.Visible = false;
            panel_courseSubmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;

        }

        public void hideSubmenu()
        {
            if (panel_stdSubmenu.Visible == true)
                panel_stdSubmenu.Visible = false;
            if (panel_courseSubmenu.Visible == true)
                panel_courseSubmenu.Visible = false;
            if (panel_scoreSubmenu.Visible == true)
                panel_scoreSubmenu.Visible = false;
        }

        public void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        public void btn_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdSubmenu);
        }
        #region StdSubmenu
        public void btn_registration_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            hideSubmenu();
        }

        public void btn_manageStd_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm());
            hideSubmenu();
        }

        public void btn_stdPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PintStudentForm());
            hideSubmenu();
        }

        #endregion StdSubmenu

        public void btn_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_courseSubmenu);
        }
        #region CourseSubmenu
        public void btn_newCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());
            hideSubmenu();
        }

        public void btn_manageCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCourseForm());
            hideSubmenu();
        }

        public void btn_coursePrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintCourseForm());
            hideSubmenu();
        }
        #endregion CourseSubmenu

        public void btn_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoreSubmenu);
        }
        #region ScoreSubmenu
        
        public void btn_manageScore_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentCourseForm());
            hideSubmenu();
        }

        private void btn_scorePrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintScoreForm());
            hideSubmenu();
        }

        #endregion ScoreSubmenu


        //to show childForm in mainForm
        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void btn_dashboard_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            panel_main.Controls.Add(panel_cover);
            showStudentCount();
        }

        public void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

    }
}
