using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace Lab6_2
{
    public partial class Product : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SqlConnection conection = new SqlConnection();
                conection.ConnectionString = WebConfigurationManager.ConnectionStrings["conTest1"].ConnectionString;
                if (Session["uname"] != null )
                {                   
                    try
                    {
                        using (conection)
                        {
                            conection.Open();
                            string query = "select pid,pname from [Product]";
                            SqlCommand command = new SqlCommand(query, conection);

                            SqlDataReader reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                itemList.Items.Add(new ListItem(reader["pname"].ToString(), reader["pid"].ToString()));
                            }


                        }

                    }
                    catch (Exception err)
                    {
                        Label1.Text = err.Message;
                    }
                }
                else
                {
                    Response.Redirect("~/2_Login.aspx");
                }
            }
            
        }

        protected void Place_Order_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["conTest1"].ConnectionString;
            try
            {
                using (conn)
                {
                    conn.Open();
                    
                    
                    foreach (ListItem item in orderList.Items)
                    {
                        string query = "insert into [Order](uid,pid) values(@userid,@prodid)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@userid", Int32.Parse(Session["uid"].ToString()));
                        cmd.Parameters.AddWithValue("@prodid", Int32.Parse(item.Value.ToString()));
                        int res = cmd.ExecuteNonQuery();
                        if (res == 0)
                        {
                            Label1.Text = "Items Not Added..";
                            Label1.ForeColor = System.Drawing.Color.Red;
                            
                        }
                        
                        
                    }
                    
                }
               
            }
            catch(Exception ex)
            {
                Label1.Text = ex.Message.ToString();
            }
            Response.Redirect("~/2_Order.aspx");
        }

        protected void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemList.SelectedIndex > -1)
            {
                orderList.Items.Add(itemList.SelectedItem);
                itemList.ClearSelection();
            }
        }

       
    }
}