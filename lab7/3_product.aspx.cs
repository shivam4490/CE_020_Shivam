using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Lab7_3
{
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if((Request.QueryString["var_pid"]!=null))
                {
                     
                }
            }
        }
        

        protected void DetailsView1_ItemDeleted1(object sender, DetailsViewDeletedEventArgs e)
        {
            Response.Write("Deleted");
        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            Response.Write("Inserted");
        }

        protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            Response.Write("Updated");
        }

       
    }
}