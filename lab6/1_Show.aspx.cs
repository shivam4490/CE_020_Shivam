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
    public partial class Show : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            try
            {
                using (connection)
                {
                    connection.Open();
                    string query = "select * from Student";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader rdr = command.ExecuteReader();
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();

                }

            }
            catch(Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
    }
}