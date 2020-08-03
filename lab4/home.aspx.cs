using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webapp4
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }
        protected void PanServerValidate1(object sender, ServerValidateEventArgs e)
        {
            if ((e.Value.Length == 10) && ((e.Value[0] == 'A') || (e.Value[0] == 'B')))
                e.IsValid = true;
            else
            {
                e.IsValid = false;

            }
        }

        protected void Drop_Load(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Gujarat")
            {
                DropDownList2.Items.Add("Ahemdabad");
                DropDownList2.Items.Add("Vadodara");
                DropDownList2.Items.Remove("Mumbai");
                DropDownList2.Items.Remove("Pune");
            }
            else
            {
                DropDownList2.Items.Remove("Ahemdabad");
                DropDownList2.Items.Remove("Vadodara");
                DropDownList2.Items.Add("Mumbai");
                DropDownList2.Items.Add("Pune");
            }
        }
        protected void Submit_Click1(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                label21.ForeColor = System.Drawing.Color.Green;
                label21.Text = "form is valid";

                username2.Text = "Full name:- " + fullname1.Text;
                age2.Text = "Age:- " + age1.Text;
                password3.Text = "password:- " + password2.Text;
                gender2.Text = "gender:- " + RadioButtonList1.SelectedValue;
                mobile2.Text = "mobile no:- " + mobile1.Text;

                hobbie2.Text = "hobbies:- ";
                foreach (ListItem hobby in CheckBoxList1.Items)
                {
                    if (hobby.Selected == true)
                    {
                        hobbie2.Text += hobby.Text + ", ";
                    }
                }
                state2.Text = "State:- " + DropDownList1.SelectedValue;
                city2.Text = "City:- " + DropDownList2.SelectedValue;
                pan2.Text = "Pan:- " + pan1.Text;
            }
            else
            {
                label21.ForeColor = System.Drawing.Color.Red;
                label21.Text = "form is not valid";
            }


        }

    }
}