using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class _2_Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] != null)
            {
                Label6.Text = Session["login"].ToString();
            }

            if (Session["dic_item"] != null)
            {
                Dictionary<string, int> item_order = new Dictionary<string, int>();
                item_order = (Dictionary<string, int>)Session["dic_item"];

                foreach (var item in item_order)
                {
                    Label9.Text += item.Key + ":- " + item.Value + "<br />";
                }
            }
            Label8.Text = Session["cost"].ToString() + " rs";
        }
    }
}