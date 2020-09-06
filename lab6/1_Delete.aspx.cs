using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
namespace Lab6
{
    public partial class Delete : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            
            
        }

        

        protected void Button2_Click(object sender, EventArgs e) 
        {
   

            try
            {
                using (connection)
                {
                    connection.Open();
                    string command = "delete from Student where sid=@sid";
                    SqlCommand cmd = new SqlCommand(command, connection);

                    cmd.Parameters.AddWithValue("sid", sid.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        Label1.Text = "Deleted Successfully...";
                        Label1.ForeColor = System.Drawing.Color.Green;
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