using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Contacts : StudentInfo
    {
        public string City { get; set; }
        public String StateName { get; set; }
        public int ZipCode { get; set; }
        public int PhoneNo { get; set; }
    }
}
