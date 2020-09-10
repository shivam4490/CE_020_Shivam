using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7_4
{
    public partial class 4_Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DeleterRecord_Click(object sender, EventArgs e)
        {
            StudentDataContext dbcontext = new StudentDataContext();
            Student student = new Student();
            student = dbcontext.Students.Single(x => x.sid == Int32.Parse(id.Text));
            dbcontext.Students.DeleteOnSubmit(student);
            dbcontext.SubmitChanges();
            Label1.Text = "Deleted";
        }
    }
}