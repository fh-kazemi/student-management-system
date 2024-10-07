using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    class DTO
    {
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string CourseName { get; set; }
        public string Semester { get; set; }
        public float value { get; set; }

        DBConnection connection = new DBConnection();
        public List<DTO> getCustomStudentInfo()
        {
            List<DTO> StudentInformationList = new List<DTO>();
            try
            {                
                string query = $"SELECT firstname,lastname, coursename, semester, value FROM tblstudent AS student " +
                               $"INNER JOIN tblscore AS score ON student.id = score.studentid " +
                               $"INNER JOIN tblcourse AS course ON score.courseid = course.id;";

                connection.openConnection();
                SqlCommand cmd = connection.GetSqlCommand(query);

                SqlDataReader result = cmd.ExecuteReader();

               while (result.Read())
                {
                    DTO dto = new DTO();
                    dto.StudentFirstName = result.GetString(0);
                    dto.StudentLastName = result.GetString(1);
                    dto.CourseName = result.GetString(2);
                    dto.Semester = result.GetString(3);
                    dto.value = result.GetFloat(4);
                    StudentInformationList.Add(dto);
                }
                if (StudentInformationList.Count < 1)
                {
                    return null;
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
            return StudentInformationList;
        }

        public List<DTO> searchStudentInfo(string searchItem)
        {
            List<DTO> studentInfoList = new List<DTO>();
            try
            {
                connection.openConnection();

                string query = $"SELECT firstname,lastname, coursename ,semester, value " +
                               $"FROM tblstudent AS student " +
                               $"INNER JOIN tblscore AS score ON student.id = score.studentid " +
                               $"INNER JOIN tblcourse AS course ON score.courseid = course.id " +
                               $"WHERE CONCAT(firstname,lastname) LIKE '%{searchItem}%';";

                SqlCommand cmd = connection.GetSqlCommand(query);

                SqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    DTO d = new DTO();
                    d.StudentFirstName = result.GetString(0);
                    d.StudentLastName = result.GetString(1);
                    d.CourseName = result.GetString(2);
                    d.Semester = result.GetString(3);
                    d.value = result.GetFloat(4);
                    studentInfoList.Add(d);
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.closeConnection();
            }
            return studentInfoList;
        }
    }
}
