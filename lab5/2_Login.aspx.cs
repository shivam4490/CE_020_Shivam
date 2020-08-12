using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class _2_Login : System.Web.UI.Page
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
                Session["login"] = username.Text;
                Response.Redirect("2_Home.aspx");
            }
            else
            {
                Label3.Text = "please enter username and password both as 'admin'";
            }
        }
    }
}