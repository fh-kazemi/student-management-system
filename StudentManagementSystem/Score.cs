using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    class Score
    {
        public string Id { get; set; }
        public string StudentId { get; set; }
        public string CourseId { get; set; }
        public string Semester { get; set; }
        public float value { get; set; }


        DBConnection connection = new DBConnection();

        public List<Score> getScoreListByStudent(string studentId)
        {
            List<Score> scoreList = new List<Score>();
            try
            {
                connection.openConnection();
                string query = $"SELECT * FROM tblscore WHERE studentid = @StudentId;";
                SqlCommand cmd = connection.GetSqlCommand(query);

                cmd.Parameters.AddWithValue("@StudentId", studentId);
                SqlDataReader result =  cmd.ExecuteReader();

                while (result.Read())
                {
                    Score s = new Score();
                    s.Id = result.GetString(0);
                    s.StudentId = result.GetString(1);
                    s.CourseId = result.GetString(2);
                    s.Semester = result.GetString(3);               
                    s.value = result.GetFloat(4);
                    scoreList.Add(s);
                }
            }
            catch (Exception ex)
            {
                if (scoreList.Count < 1)
                {
                    MessageBox.Show("There is no score in list.");
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

            return scoreList;
        }      

        public bool insertScore(Score score)
        {
            try
            {
                connection.openConnection();
                string query = $"INSERT INTO tblscore( studentid, courseid, semester,value) " +
                               $"VALUES (@StudentId, @CourseId, @Semester, @Value);";

                SqlCommand cmd = connection.GetSqlCommand(query);
                cmd.Parameters.AddWithValue("@StudentId",score.StudentId);
                cmd.Parameters.AddWithValue("@CourseId",score.CourseId);
                cmd.Parameters.AddWithValue("@Semester",score.Semester);
                cmd.Parameters.AddWithValue("@Value",score.value);

                int result = cmd.ExecuteNonQuery();
                if (result < 1)
                {
                    return false;
                }
                else
                {
                    return true;
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

        public bool deleteCourse(string scoreId) 
        {
            try
            {
                connection.openConnection();
                string query = $"DELETE FROM tblscore " +
                               $"WHERE id = @ScorId;"; 

                SqlCommand cmd = connection.GetSqlCommand(query);
                cmd.Parameters.AddWithValue("@ScorId", scoreId);

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
        
        public bool updateScore(Score score) 
        {
            try
            {
                connection.openConnection();
                string query = $"UPDATE tblscore SET value = @Value " +
                               $"WHERE id = @ScoreId;";

                SqlCommand cmd = connection.GetSqlCommand(query);

                cmd.Parameters.AddWithValue("@Value", score.value);
                cmd.Parameters.AddWithValue("@ScoreId", score.Id);

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

        public bool updateSemester(Score score)
        {
            try
            {
                connection.openConnection();
                string query = $"UPDATE tblscore SET semester = @Semester " +
                               $"WHERE id = @ScoreId;";

                SqlCommand cmd = connection.GetSqlCommand(query);

                cmd.Parameters.AddWithValue("@Semester", score.Semester);
                cmd.Parameters.AddWithValue("@ScoreId", score.Id);

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

        public int studentCountInCourse(string courseId)
        {
            try
            {
                string query = $"SELECT COUNT(*) FROM tblstudent AS student " +
                               $"INNER JOIN tblscore AS score " +
                               $"ON score.studentid = student.id " +
                               $"WHERE score.courseid = @CourseId;";

                connection.openConnection();

                SqlCommand cmd = connection.GetSqlCommand(query);
                cmd.Parameters.AddWithValue("@CourseId", courseId);
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                connection.closeConnection();
            }            
        }

        public List<Student> getStudentInCourse(string courseId, string query)
        {
            List<Student> studentList = new List<Student>();
            try
            {   
                connection.openConnection();

                SqlCommand cmd = connection.GetSqlCommand(query);
                cmd.Parameters.AddWithValue("@CourseId", courseId);

                SqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    Student s = new Student();
                    s.FirstName = result.GetString(0);
                    s.LastName = result.GetString(1);
                    s.Phone = result.GetString(2);
                    s.BirthDate = result.GetDateTime(3);
                    s.Gender = result.GetString(4);
                    s.Address = result.GetString(5);
                    s.Image = (byte[]) result.GetValue(6);
                    studentList.Add(s);
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
            return studentList;
        }
    }
}
