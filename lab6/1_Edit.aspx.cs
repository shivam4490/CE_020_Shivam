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
    public partial class Edit : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            Panel1.Visible = false;
            Button2.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)    
        {
            Panel1.Visible = true;
            Button2.Visible = true;

            try
            {
                using (connection)
                {
                    connection.Open();
                    string command = "select * from Student where sid=@sid";
                    SqlCommand cmd = new SqlCommand(command, connection);

                    cmd.Parameters.AddWithValue("sid", int.Parse(sid.Text));
                    SqlDataReader rdr = cmd.ExecuteReader();
                    
                    while(rdr.Read())
                    {

                        name.Text = rdr["name"].ToString();
                        sem.Text = rdr["sem"].ToString();
                        mob.Text = rdr["mob_no"].ToString();
                        email.Text = rdr["email_id"].ToString();
                    }
                    
                }
            }
            catch (Exception err)
            {
                Label1.Text = err.Message;
                
            }


        }

        protected void Button2_Click(object sender, EventArgs e)    
        {
            Panel1.Visible = true;
            Button2.Visible = true;


            try
            {
                using (connection)
                {
                    connection.Open();
                    string command = "update Student set name=@name,sem=@sem,mob_no=@mob_no,email_id=@email_id where sid=@sid";
                    SqlCommand cmd = new SqlCommand(command, connection);

                    cmd.Parameters.AddWithValue("name", name.Text);
                    cmd.Parameters.AddWithValue("sem", sem.Text);
                    cmd.Parameters.AddWithValue("mob_no", mob.Text);
                    cmd.Parameters.AddWithValue("email_id", email.Text);
                    cmd.Parameters.AddWithValue("sid", sid.Text);

                    int result = cmd.ExecuteNonQuery();
                    if(result==1)
                    {
                        Label1.Text = "Data Updated...";
                        Label1.ForeColor = System.Drawing.Color.Green;
                    }                    
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;

            }

        }

        
    }
}