using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class _2_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label5.Text = Session["login"].ToString();
        }
        protected void Place_Order(object sender, EventArgs e)
        {
            int total_value = 0;
            Dictionary<string, int> dic_item = new Dictionary<string, int>();
            foreach (ListItem ite in ListBox1.Items)
            {
                if (ite.Selected == true)
                {
                    dic_item.Add(ite.Text, int.Parse(ite.Value));
                    total_value += int.Parse(ite.Value);
                }
            }
            Session["dic_item"] = dic_item;
            Session["cost"] = total_value;

            total_value = 0;
            Response.Redirect("2_Order.aspx");
        }

        protected void Select_Items(object sender, EventArgs e)
        {

            if (RadioButtonList1.SelectedValue == "Books")
            {
                ListBox1.Items.FindByText("Mobile").Enabled = false;
                ListBox1.Items.FindByText("Laptop").Enabled = false;
                ListBox1.Items.FindByText("Tablets").Enabled = false;
                ListBox1.Items.FindByText("headphones").Enabled = false;
                ListBox1.Items.FindByText("zero to one").Enabled = true;
                ListBox1.Items.FindByText("Autobiography of yogi").Enabled = true;
                ListBox1.Items.FindByText("Inteligent investor").Enabled = true;
                ListBox1.Items.FindByText("The Rudest book ever").Enabled = true;
            }
            else
            {
                ListBox1.Items.FindByText("Mobile").Enabled = true;
                ListBox1.Items.FindByText("Laptop").Enabled = true;
                ListBox1.Items.FindByText("Tablets").Enabled = true;
                ListBox1.Items.FindByText("headphones").Enabled = true;
                ListBox1.Items.FindByText("zero to one").Enabled = false;
                ListBox1.Items.FindByText("Autobiography of yogi").Enabled = false;
                ListBox1.Items.FindByText("Inteligent investor").Enabled = false;
                ListBox1.Items.FindByText("The Rudest book ever").Enabled = false;
            }
        }

    }
}