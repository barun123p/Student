using Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentDetails
{
    public partial class DisplayStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentDataAccess studeuntdata = new StudentDataAccess();
            if (!IsPostBack)
            {
                ddlStudentID.DataSource = studeuntdata.GetStudentInfos();
                ddlStudentID.DataTextField = "StudentId";
                ddlStudentID.DataValueField = "StudentId";
                ddlStudentID.DataBind();
                ddlStudentID.Items.Insert(0, "Select");

            }

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            StudentDataAccess studeuntdata = new StudentDataAccess();
            StudentInfo student = new StudentInfo();
            // student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            studeuntdata.insertStudentInfo(student);

        }

        protected void btndisplay_Click(object sender, EventArgs e)
        {
            StudentDataAccess studeuntdata = new StudentDataAccess();
            GridView1.DataSource = studeuntdata.GetStudentInfos();
            GridView1.DataBind();

        }

        protected void ddlStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlStudentID.SelectedValue != "Select")
            {
                int selectedValue = Convert.ToInt32(ddlStudentID.SelectedValue);
                StudentDataAccess studentData = new StudentDataAccess();
                List<StudentInfo> studentinfo = new List<StudentInfo>();
                var student1 = studentData.GetStudentInfos().ToList();

                var student = student1.Where(x => x.StudentId == selectedValue).FirstOrDefault();

                if (student != null)
                {
                    txtFirstName.Text = student.FirstName;
                    txtLastName.Text = student.LastName;
                }
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            StudentDataAccess studeuntdata = new StudentDataAccess();
            StudentInfo studentInfo = new StudentInfo();
            studentInfo.StudentId = Convert.ToInt32(ddlStudentID.SelectedValue);
            studentInfo.FirstName = txtFirstName.Text;
            studentInfo.LastName = txtLastName.Text;
            studeuntdata.updateStudentInfo(studentInfo);
           

            Response.Redirect("DisplayStudent.aspx");
        }

               protected void btnDelete_Click1(object sender, EventArgs e)
        {
            StudentDataAccess studentData = new StudentDataAccess();
            studentData.DeleteStudent(Convert.ToInt32(ddlStudentID.SelectedValue));
            Response.Redirect("DisplayStudent.aspx");
        }

        //protected void btnupdate_Click1(object sender, EventArgs e)
        //{

        //}
    }
}
