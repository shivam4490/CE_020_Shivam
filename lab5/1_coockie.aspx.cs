using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class _1_coockie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_1(object sender, EventArgs e)
        {
            if (username1.Text != null)
            {
                HttpCookie cokie = new HttpCookie("user_info");
                cokie.Values.Add("username", username1.Text);
                cokie.Values.Add("age", age1.Text);
                cokie.Expires = DateTime.MaxValue;
                Response.Cookies.Add(cokie);
                username1.Text = age1.Text = string.Empty;
            }
        }

        protected void Delete_btn1(object sender, EventArgs e)
        {
            if (Request.Cookies["user_info"] != null)
            {
                HttpCookie cokie = Request.Cookies["user_info"];
                cokie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cokie);
            }
        }

        protected void Show_btn1(object sender, EventArgs e)
        {
            if (Request.Cookies["user_info"] == null)
            {
                showcockie.Text = "there is no coockies";
            }
            else
            {
                //showcockie.Text = Request.Cookies["user_info"].Value;
                HttpCookie reqcookie = Request.Cookies["user_info"];
                showcockie.Text = "username:- " + reqcookie["username"].ToString() + "<br />";
                showcockie.Text += "age:- " + reqcookie["age"].ToString();

            }
        }
    }
}