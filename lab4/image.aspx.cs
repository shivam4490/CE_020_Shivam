using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webapp4
{
    public partial class image : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Showbtn(object sender, EventArgs e)
        {
            if (Image1.Visible == false)
            {
                Image1.Visible = true;
                imageshow.Text = "hide image";
            }
            else
            {
                Image1.Visible = false;
                imageshow.Text = "show image";
            }

        }
    }
}