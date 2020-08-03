using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webapp4
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Convert(object sender, EventArgs e)
        {

            string usr = username.Text;
            string pass = password.Text;

            if ((pass == "admin") && (usr == "admin"))
            {
                Server.Transfer("home.aspx");
            }
            else
            {
                label.ForeColor = System.Drawing.Color.Red;
                label.Text = "incorrect creditial";
            }
        }
    }
}