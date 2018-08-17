using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class StudentDataAccess
    {
        public List<StudentInfo> GetStudentInfos()
        {
            List<StudentInfo> studInfo = new List<StudentInfo>();
            SqlConnection conn = new SqlConnection(Connection.GetConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("getstudentdata", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                studInfo.Add(new StudentInfo
                {
                    StudentId = Convert.ToInt32(rd["StudentId"].ToString()),
                    FirstName = rd["FirstName"].ToString(),
                   LastName = rd["LastName"].ToString()
                });
            }
            return studInfo;
        } 


        public void insertStudentInfo(StudentInfo student)
        {
         
            SqlConnection conn = new SqlConnection(Connection.GetConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("ADDSTUDENT", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@StudentId", SqlDbType.Int).Value = student.StudentId;
            cmd.Parameters.Add("@FIRSTNAME", SqlDbType.VarChar,50).Value = student.FirstName;
            cmd.Parameters.Add("@LASTNAME", SqlDbType.VarChar,50).Value = student.LastName;
            cmd.ExecuteNonQuery();

        }
        
        public void updateStudentInfo(StudentInfo student)
        {
            SqlConnection conn = new SqlConnection(Connection.GetConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATESTUDENT", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
           cmd.Parameters.Add("@StudentId", SqlDbType.Int).Value = student.StudentId;
            cmd.Parameters.Add("@FIRSTNAME", SqlDbType.VarChar, 50).Value = student.FirstName;
            cmd.Parameters.Add("@LASTNAME", SqlDbType.VarChar, 50).Value = student.LastName;
            cmd.ExecuteNonQuery();
        }


        public void DeleteStudent(int id)
        {
            SqlConnection conn = new SqlConnection(Connection.GetConnection());
            SqlCommand cmd = new SqlCommand("DELETESTUDENT", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@StudentId", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
        }

    }
}
