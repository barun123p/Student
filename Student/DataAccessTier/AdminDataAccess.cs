using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Student.DataAccessTier
{
    public class AdminDataAccess
    {
        public List<AdminUser> GetAdminUsers()
        {
            List<AdminUser> adminUsers = new List<AdminUser>();
            SqlConnection conn = new SqlConnection(Connection.GetConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("getAdmin", conn);
            SqlDataReader rd = cmd.ExecuteReader();


            while (rd.Read())
            {
                adminUsers.Add(new AdminUser
                {
                    UserName = rd["UserName"].ToString(),
                    PassWord = rd["UserPassWord"].ToString(),

                });

            }
            return adminUsers;



        }
    }
}
