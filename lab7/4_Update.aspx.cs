using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7_4
{
    public partial class 4_Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void FetchRecord_Click(object sender, EventArgs e)
        {
            StudentDataContext dbcontext = new StudentDataContext();
            Student student = new Student();
            int id = Int32.Parse(student_id.Text);
            student = dbcontext.Students.SingleOrDefault(x => x.sid == id);
            name.Text = student.name;
            sem.Text = student.sem.ToString();
            cpi.Text = student.cpi.ToString();
            mob.Text = student.contactno.ToString();
            email.Text = student.email;
            
        }

        protected void RecordUpdated_Click(object sender, EventArgs e)
        {

            StudentDataContext db = new StudentDataContext();
            Student s = new Student();
            int id = Int32.Parse(student_id.Text);
            s = db.Students.SingleOrDefault(x => x.sid == id);
            s.name = name.Text;
            s.sem = int.Parse(sem.Text);
            s.cpi = float.Parse(cpi.Text);
            s.contactno = long.Parse(mob.Text);
            s.email = email.Text;
            db.SubmitChanges();
           
            Label2.Text = "Updated";
            Label2.ForeColor = System.Drawing.Color.Green;
        }
    }
}