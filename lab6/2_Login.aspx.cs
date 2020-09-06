using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration; 
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Lab6_2
{
    public partial class Login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = WebConfigurationManager.ConnectionStrings["Test1"].ConnectionString;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                using (connection)
                {
                    connection.Open();
                    string query = "select * from [User] where uname = @uname";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("uname", name.Text);
                    SqlDataReader reader = command.ExecuteReader();

                    
                        while (reader.Read())
                        {
                            if (passwd.Text.Equals(reader["password"]))
                            {
                                Session["uid"] = reader["uid"];
                                Session["uname"] = reader["uname"];
                                Response.Redirect("~/2_Product.aspx");
                            }
                            else
                            {
                                Label1.Text = "Invalid Username Or Paassword";
                            }
                        }
                    
                    
                }
            }
            catch (Exception err)
            {
                Label1.Text = err.Message;
            }
        }
    }
}