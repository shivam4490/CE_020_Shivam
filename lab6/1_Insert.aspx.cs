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
    public partial class Insert : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            connection.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;
                   
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    string query = "Insert into Student(name,sem,mob_no,email_id) values(@name,@sem,@mob_no,@email_id)";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    command.Parameters.AddWithValue("@name", TextBox1.Text);
                    command.Parameters.AddWithValue("@sem", TextBox2.Text);
                    command.Parameters.AddWithValue("@mob_no", TextBox3.Text);
                    command.Parameters.AddWithValue("@email_id", TextBox4.Text);

                   
                    int result = command.ExecuteNonQuery();
                    if(result==1)
                    {
                        Label1.Text = "Data Added Successfully";
                        Label1.ForeColor = System.Drawing.Color.Green;
                    }
                    command.Dispose();
                    connection.Close();
                    
                }
            }
            catch(Exception ex)
            {
                Label1.Text= ex.Message;
            }
            

        }
    }
}