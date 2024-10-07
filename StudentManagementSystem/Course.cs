using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    class Course
    {
        public string Id { get; set; }
        public string CourseName { get; set; }
        public string CourseHour { get; set; }
        public string Description { get; set; }
        public List<Score> ScoreList { get; set; } = new List<Score>();

        DBConnection connection = new DBConnection();

        public bool insertCourse(Course course)
        {
            try
            {
                connection.openConnection();
                string query = "INSERT INTO tblcourse(coursename,coursehour,description) " +
                               "VALUES (@CourseName, @CourseHour, @Description);";

                SqlCommand cmd = connection.GetSqlCommand(query);

                cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                cmd.Parameters.AddWithValue("@CourseHour", course.CourseHour);
                cmd.Parameters.AddWithValue("@Description", course.Description);

                if (cmd.ExecuteNonQuery() == 1)
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

        public List<Course> getCourseList()
        {
            List<Course> courseList = new List<Course>();
            try
            {
                connection.openConnection();
                string query = "SELECT * FROM tblcourse;";

                SqlCommand cmd = connection.GetSqlCommand(query);

                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Course c = new Course();
                    c.Id = result.GetString(0);
                    c.CourseName = result.GetString(1);
                    c.CourseHour = result.GetString(2);
                    c.Description = result.GetString(3);
                    courseList.Add(c);
                }

            }catch(Exception ex)
            {
                if (courseList.Count < 1)
                {
                    MessageBox.Show("There is no course in list.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                connection.closeConnection();
            }
            return courseList;
        }


        public List<Course> searchCourse(string searchItem)
        {
            List<Course> courseList = new List<Course>();
            try
            {
                connection.openConnection();
                string query = $"SELECT * FROM tblcourse " +
                               $"WHERE CONCAT(coursename, description) LIKE '%{searchItem}%';";

                SqlCommand cmd = connection.GetSqlCommand(query);
                SqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    Course c = new Course();
                    c.Id = result.GetString(0);
                    c.CourseName = result.GetString(1);
                    c.CourseHour = result.GetString(2);
                    c.Description = result.GetString(3);
                    courseList.Add(c);
                }

            }catch(Exception ex)
            {
                if(courseList.Count < 1)
                {
                    MessageBox.Show("There is not This Course. ");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                connection.closeConnection();
            }
            return courseList;
        }

        public Course searchCourseById(string id)
        {
            Course course = new Course();
            try
            {
                connection.openConnection();
                string query = $"SELECT * FROM tblcourse " +
                               $"WHERE id = @CourseId;";

                SqlCommand cmd = connection.GetSqlCommand(query);
                cmd.Parameters.AddWithValue("@CourseId", id);
                SqlDataReader result = cmd.ExecuteReader();

                if (result.Read())
                {
                    course.Id = result.GetString(0);
                    course.CourseName = result.GetString(1);
                    course.CourseHour = result.GetString(2);
                    course.Description = result.GetString(3);
                }
                else
                {
                    MessageBox.Show("There is no course with this name.", "Course Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.closeConnection();
            }
            return course;
        }
 
        public bool updateCourse(Course course)
        {
            try
            {
                connection.openConnection();
                string query = $"UPDATE tblcourse SET " +
                               $"coursename = @CourseName, " +
                               $"coursehour = @CourseHour, " +
                               $"description = @description " +
                               $"WHERE id = @Id;";

                SqlCommand cmd = connection.GetSqlCommand(query);

                cmd.Parameters.AddWithValue("@Id", course.Id);
                cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                cmd.Parameters.AddWithValue("@CourseHour", course.CourseHour);
                cmd.Parameters.AddWithValue("@description", course.Description);

                if(cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connection.closeConnection();
            }
        }

        public bool deleteCourse(String courseId)
        {
            try
            {
                connection.openConnection();
                string query = $"DELETE FROM tblcourse " +
                               $"WHERE id = '{courseId}';";

                SqlCommand cmd = connection.GetSqlCommand(query);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
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
}
