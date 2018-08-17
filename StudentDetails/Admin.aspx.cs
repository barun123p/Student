using Student.DataAccessTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentDetails
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AdminDataAccess adminData = new AdminDataAccess();
            //if ((adminData.GetAdminUsers().Select(x => x.UserName == txtUsername.Text)).FirstOrDefault()
            //    && (adminData.GetAdminUsers().Select(x => x.PassWord == txtPassword.Text)).FirstOrDefault())

                if(adminData.GetAdminUsers().ToList().Where(x=> (x.UserName==txtUsername.Text && x.PassWord==txtPassword.Text)).Any())
            {
                Response.Redirect("DisplayStudent.aspx");
            }
            else
            {
                errorMessage.Text = " Enter a valid Username or a Password";
            }

        }
    }
}