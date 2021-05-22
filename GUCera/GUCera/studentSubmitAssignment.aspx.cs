using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class studentSubmitAssignment : System.Web.UI.Page
    { protected void Page_Load(object sender, EventArgs e)
        {}
        protected void Home(object sender, EventArgs e)
        { Response.Redirect("studentHome.aspx"); }
        protected void Submit(object sender, EventArgs e)
        {
        string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

        String Type = type.Text;
        int Number = Int16.Parse(number.Text);
        int Course = Int16.Parse(course.Text);
        // int loggedUser = (int)Session["user"];
        int loggedUser = 1034;

        SqlCommand sub = new SqlCommand("submitAssign", conn);
        sub.CommandType = System.Data.CommandType.StoredProcedure;

            sub.Parameters.Add(new SqlParameter("@assignType", Type));
            sub.Parameters.Add(new SqlParameter("@assignnumber", Number));
            sub.Parameters.Add(new SqlParameter("@sid", loggedUser));
            sub.Parameters.Add(new SqlParameter("@cid", Course));
         
         conn.Open();
         sub.ExecuteNonQuery();
         String bye= "<br /><hr /><br />Your assignment was submitted Successfuly! Great Work!<br /><br /><hr /><br />";
         PlaceHolder1.Controls.Add(new Literal { Text = bye});
         divData.Style.Add("visibility", "hidden");
         conn.Close();

        }
    }
}