using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class studentViewAssignGrade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {}
        protected void Home(object sender, EventArgs e)
        { Response.Redirect("studentHome.aspx"); }
        protected void Grade(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int Number = Int16.Parse(number.Text);
            String Type = type.Text;
            int Course = Int16.Parse(course.Text);
            
            // int loggedUser = (int)Session["user"];
            
            int loggedUser = 1034;

            SqlCommand assignGrade = new SqlCommand("viewAssignGrades", conn);
            assignGrade.CommandType = System.Data.CommandType.StoredProcedure;

            assignGrade.Parameters.Add(new SqlParameter("@assignnumber", Number));
            assignGrade.Parameters.Add(new SqlParameter("@assignType", Type));
            assignGrade.Parameters.Add(new SqlParameter("@cid", Course));
            assignGrade.Parameters.Add(new SqlParameter("@sid", loggedUser));

            SqlParameter x = assignGrade.Parameters.Add("@assignGrade", SqlDbType.Int);
            x.Direction = ParameterDirection.Output;

            conn.Open();
            assignGrade.ExecuteNonQuery();
            conn.Close();

            if (!(x is null))
            {
                PlaceHolder1.Controls.Add(new Literal { Text = "Your grade is: " + x.Value.ToString() });
              //  Response.Write("Your grade is: " +x.Value.ToString()) ;
            }


        }

    }
}