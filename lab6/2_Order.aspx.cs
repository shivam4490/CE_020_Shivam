using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
namespace Lab6_2
{
    public partial class Order : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["uname"]!=null)
            {
                connection.ConnectionString = WebConfigurationManager.ConnectionStrings["Test1"].ConnectionString;
                
                try
                {
                    using (connection)
                    {
                        connection.Open();
                        double sum = 0;
                        string query= "select * from [Order] inner join [Product] on [Order].pid=[Product].pid where [Order].uid=@userid and [Order].isPaid=0 ";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@userid", int.Parse(Session["uid"].ToString()));
                        
                        SqlDataReader reader = cmd.ExecuteReader();
                        
                        while (reader.Read())
                        {
                            sum += double.Parse(reader["cost"].ToString());
                        }
                       
                            
                            bill.Text = "Bill: "+ sum.ToString();
                            connection.Close();
                            connection.Open();
                            GridView1.DataSource = cmd.ExecuteReader();
                            GridView1.DataBind();
                       
                        
                        
                    }
                }
                catch(Exception err)
                {
                    Label1.Text = err.Message;
                }
            }
            else
            {
                Response.Redirect("./2_Login.aspx");
            }
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = WebConfigurationManager.ConnectionStrings["Test1"].ConnectionString;
            try
            {
                using (connection)
                {
                    connection.Open();
                    string query = "update [Order] set isPaid=1 where uid=@uid";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@uid", Int32.Parse(Session["uid"].ToString()));
                    
                    int resukt = command.ExecuteNonQuery();
                    Session["uname"] = null;
                    Response.Redirect("./2_Login.aspx");
                }
            }
            catch(Exception ex)
            {
                Label1.Text = ex.Message.ToString();
            }
        }

        
    }
}