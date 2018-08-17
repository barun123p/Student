using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Connection
    {
        public static string GetConnection()
        {
            return @"Data Source = DESKTOP-MKI4C5K\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True;";
        }

    }
}
