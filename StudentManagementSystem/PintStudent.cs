using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;



namespace StudentManagementSystem
{
    public partial class PintStudentForm : Form
    {
        Student student = new Student();
        Course course = new Course();
        Score score = new Score();
        DGVPrinter printer = new DGVPrinter();

        public PintStudentForm()
        {
            InitializeComponent();
        }

        private void PintStudentForm_Load(object sender, EventArgs e)
        {
            showStudentList(student.getStudentList());
            course.CourseName = "";
            course.Id = "0";
            showCourseNameInComboBox();
        }

        void showStudentList(List<Student> studentList)
        {
            dataGrid_Student.ReadOnly = true;
            dataGrid_Student.DataSource = studentList;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGrid_Student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        void showCourseNameInComboBox()
        {           
            List<Course> courseList = course.getCourseList();            
            courseList.Insert(0, course);

            comboBox_Course.DataSource = courseList;
            comboBox_Course.DisplayMember = "coursename";
            comboBox_Course.ValueMember = "id";
            comboBox_Course.SelectedIndexChanged += (object sender, EventArgs e) =>
            {
                if (comboBox_Course.SelectedItem != null)
                {
                    course.Id = comboBox_Course.SelectedValue.ToString();
                    lbl_StudentInCourse.Text = "Total Student In This Course : " + score.studentCountInCourse(course.Id);
                    showStudentInDataGrid();
                }
            };
        }

        private void radioButton_allGender_CheckedChanged(object sender, EventArgs e)
        {
            showStudentInDataGrid();
        }

        private void radioBox_male_CheckedChanged(object sender, EventArgs e)
        {
            showStudentInDataGrid();
        }

        private void radioBox_female_CheckedChanged(object sender, EventArgs e)
        {
            showStudentInDataGrid();
        }

        void showStudentInDataGrid()
        {
            string query;
            if (radioButton_allGender.Checked == true)
            {

                if (course.Id == "0")
                {
                    showStudentList(student.getStudentList());
                }
                else
                {
                    query = $"SELECT firstname, lastname, phone, birthdate, gender, address, image " +
                        $"FROM tblstudent AS student " +
                        $"INNER JOIN tblscore AS score ON student.id = score.studentid " +
                        $"WHERE score.courseid = @CourseId; ";
                    dataGrid_Student.DataSource = score.getStudentInCourse(course.Id, query);
                }
            }
            else if (radioBox_male.Checked == true)
            {
                if (course.Id == "0")
                {
                    showStudentList(student.maleStudentList());
                }
                else
                {
                    query = $"SELECT firstname, lastname, phone, birthdate, gender, address, image " +
                        $"FROM tblstudent AS student " +
                        $"INNER JOIN tblscore AS score ON student.id = score.studentid " +
                        $"WHERE score.courseid = @CourseId " +
                        $"AND student.gender = 'Male';";
                    dataGrid_Student.DataSource = score.getStudentInCourse(course.Id, query);
                }
            }
            else
            {
                if (course.Id == "0")
                {
                    showStudentList(student.femaleStudentList());
                }
                else
                {
                    query = $"SELECT firstname, lastname, phone, birthdate, gender, address, image " +
                        $"FROM tblstudent AS student " +
                        $"INNER JOIN tblscore AS score ON student.id = score.studentid " +
                        $"WHERE score.courseid = @CourseId " +
                        $"AND student.gender = 'Female';";
                    dataGrid_Student.DataSource = score.getStudentInCourse(course.Id, query);
                }
            }            
        }
        private void btn_print_Click(object sender, EventArgs e)
        {
            //We need DGVprinter helper for print pdf file
            printer.Title = "Ludwig-Geißler-Schule Students List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Kazemi-Printer";
            printer.FooterSpacing = 10;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGrid_Student);
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            course.Id = "0";
            comboBox_Course.SelectedIndex = 0;
            lbl_StudentInCourse.Text = "Total Student In This Course : ";
            showStudentList(student.getStudentList());
        }
    }
}
