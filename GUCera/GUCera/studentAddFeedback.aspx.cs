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
    public partial class studentAddFeedback : System.Web.UI.Page
    {
        protected void Home(object sender, EventArgs e)
        { Response.Redirect("studentHome.aspx"); }
        protected void Page_Load(object sender, EventArgs e)
        {}
        protected void Feedback(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int Course = Int16.Parse(course.Text);
            String FB = fb.Text;
            // int loggedUser = (int)Session["user"];
            int loggedUser = 1034;

            SqlCommand addFB = new SqlCommand("addFeedback", conn);
            addFB.CommandType = System.Data.CommandType.StoredProcedure;

            addFB.Parameters.Add(new SqlParameter("@comment", FB));
            addFB.Parameters.Add(new SqlParameter("@cid", Course));
            addFB.Parameters.Add(new SqlParameter("@sid", loggedUser));

            conn.Open();
            try
            {
                addFB.ExecuteNonQuery();

                String bye = "<br /><br /><hr /><br />" +
                             "&nbsp;&nbsp;&nbsp;" +
                             "Your feedback was submitted Successfuly! <br /><br /><hr /><br />";
                PlaceHolder1.Controls.Add(new Literal { Text = bye });
                feebackDiv.Style.Add("visibility", "hidden");
            }
            catch (Exception) {
                Response.Write("Invalid Input(s)!");
            }

            conn.Close();

        }
    }
}