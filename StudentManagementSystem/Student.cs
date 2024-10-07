using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    class Student
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public byte[] Image { get; set; }
        public List<Score> ScoreList { get; set; } = new List<Score>();


        DBConnection connection = new DBConnection();

        public bool insertStudent(Student student) 
        { 
            try
            {
                connection.openConnection();
                string query = "INSERT INTO tblstudent(firstname,lastname,phone,birthdate,gender,address,image) " +
                               "VALUES(@FirnatName, @LastName, @Phone, @BirthDate, @Gender, @Address, @Image);";

                SqlCommand cmd = connection.GetSqlCommand(query);

                cmd.Parameters.AddWithValue("@FirnatName", student.FirstName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@Phone", student.Phone);
                cmd.Parameters.AddWithValue("@BirthDate", student.BirthDate);
                cmd.Parameters.AddWithValue("@Gender", student.Gender);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                cmd.Parameters.AddWithValue("@Image", student.Image);

                int numberOfInsertion = cmd.ExecuteNonQuery();

                if (numberOfInsertion == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connection.closeConnection();                
            }
        }

        public List<Student> getStudentList()
        {
            List<Student> studentList = new List<Student>();
            try
            {
                string query = "SELECT * FROM tblstudent;";
                connection.openConnection();
                SqlCommand cmd = connection.GetSqlCommand(query);

                SqlDataReader result = cmd.ExecuteReader();
                                
                while (result.Read())
                {
                    Student s = new Student();
                    s.Id = result.GetString(0);
                    s.FirstName = result.GetString(1);
                    s.LastName = result.GetString(2);
                    s.Phone = result.GetString(3);
                    s.BirthDate = (DateTime) result[4];
                    s.Gender = result.GetString(5);
                    s.Address = result.GetString(6);
                    s.Image = (byte[]) result[7];
                    studentList.Add(s);
                }
                
            }catch(Exception ex)
            {
                if (studentList.Count < 1)
                {
                    MessageBox.Show("There is no student in list.");
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

            return studentList;
        }

        public string totalStudentCount()
        {
            return countStudent("SELECT COUNT(*) FROM tblstudent;");
        }
        
        public string maleStudentCount()
        {
            return countStudent("SELECT COUNT(*) FROM tblstudent " +
                                 "WHERE gender = 'Male';");
        }

        public string femaleStudentCount()
        {
            return countStudent("SELECT COUNT(*) FROM tblstudent " +
                                 "WHERE gender = 'Female';");
        }
        public string countStudent(string query)
        {
            connection.openConnection();
            SqlCommand cmd = connection.GetSqlCommand(query);

            string count = cmd.ExecuteScalar().ToString();
            connection.closeConnection();
            
            return count;
        }

        public List<Student> maleStudentList()
        {
            List<Student> studentList = new List<Student>();
            try
            {
                string query = "SELECT * FROM tblstudent WHERE gender = 'Male';";
                connection.openConnection();
                SqlCommand cmd = connection.GetSqlCommand(query);

                SqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    Student s = new Student();
                    s.Id = result.GetString(0);
                    s.FirstName = result.GetString(1);
                    s.LastName = result.GetString(2);
                    s.Phone = result.GetString(3);
                    s.BirthDate = (DateTime)result[4];
                    s.Gender = result.GetString(5);
                    s.Address = result.GetString(6);
                    s.Image = (byte[])result[7];
                    studentList.Add(s);
                }
            }
            catch (Exception ex)
            {
                if (studentList.Count < 1)
                {
                    MessageBox.Show("There is no MALE student in list.");
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

            return studentList;
        }

        public List<Student> femaleStudentList()
        {
            List<Student> studentList = new List<Student>();
            try
            {
                string query = "SELECT * FROM tblstudent WHERE gender = 'Female';";
                connection.openConnection();
                SqlCommand cmd = connection.GetSqlCommand(query);

                SqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    Student s = new Student();
                    s.Id = result.GetString(0);
                    s.FirstName = result.GetString(1);
                    s.LastName = result.GetString(2);
                    s.Phone = result.GetString(3);
                    s.BirthDate = (DateTime)result[4];
                    s.Gender = result.GetString(5);
                    s.Address = result.GetString(6);
                    s.Image = (byte[])result[7];
                    studentList.Add(s);
                }
            }
            catch (Exception ex)
            {
                if (studentList.Count < 1)
                {
                    MessageBox.Show("There is no FEMALE student in list.");
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

            return studentList;
        }

        public List<Student> searchStudent(string searchItem)
        {
            List<Student> studentList = new List<Student>();            
            try
            {
                connection.openConnection();

                string query = $"SELECT * FROM tblstudent " +
                               $"WHERE CONCAT(firstname,lastname,phone,address) " +
                               $"LIKE '%{ searchItem}%';";

                SqlCommand cmd = connection.GetSqlCommand(query);

                SqlDataReader student = cmd.ExecuteReader();

                while (student.Read())
                {
                    Student s = new Student();
                    s.Id = student.GetString(0);
                    s.FirstName = student.GetString(1);
                    s.LastName = student.GetString(2);
                    s.Phone = student.GetString(3);
                    s.BirthDate = (DateTime) student.GetValue(4);
                    s.Gender = student.GetString(5);
                    s.Address = student.GetString(6);
                    s.Image = (byte[]) student.GetValue(7);
                    studentList.Add(s);
                }
                
                return studentList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                connection.closeConnection();
            }
        }

        public bool updateStudent(Student student)
        {
            try
            {
                connection.openConnection();                

                string query =  $"UPDATE tblstudent SET " +
                                $"firstname = @FirnatName, " +
                                $"lastname = @LastName, " +
                                $"phone = @Phone, " +
                                $"birthdate = @BirthDate, " +
                                $"gender = @Gender, " +
                                $"address = @Address, " +
                                $"image = @Image " +
                                $"WHERE id = @Id;";

                SqlCommand cmd = connection.GetSqlCommand(query);

                cmd.Parameters.AddWithValue("@Id", student.Id);
                cmd.Parameters.AddWithValue("@FirnatName", student.FirstName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@Phone", student.Phone);
                cmd.Parameters.AddWithValue("@BirthDate", student.BirthDate);
                cmd.Parameters.AddWithValue("@Gender", student.Gender);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                cmd.Parameters.AddWithValue("@Image", student.Image);
                
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

        public bool deleteStudent(string studentId)
        {
            try
            {
                connection.openConnection();

                string query = $"DELETE FROM tblstudent " +
                                $"WHERE id = '{studentId}';";

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
    }
}
