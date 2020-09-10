using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7_4
{
    public partial class 4_Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert_Record_Click(object sender, EventArgs e)
        {
            StudentDataContext db = new StudentDataContext();
            Student student = new Student();
            student.name = name.Text;
            student.sem = int.Parse(sem.Text);
            student.cpi = float.Parse(cpi.Text);
            student.contactno = long.Parse(cno.Text);
            student.email = email.Text;
            db.Students.InsertOnSubmit(student);
            db.SubmitChanges();

            Label1.Text = "Inserted";
            Label1.ForeColor = System.Drawing.Color.Green;
        }
    }
}