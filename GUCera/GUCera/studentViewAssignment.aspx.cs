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
    public partial class studentViewAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {}
        protected void Home(object sender, EventArgs e)
        { Response.Redirect("studentHome.aspx"); }

        protected void Assignment(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int cID = Int16.Parse(course.Text);
            // String loggedUser = Session["user"].ToString();
            String loggedUser = "1034";

            SqlCommand assignproc = new SqlCommand("viewAssign", conn);
            assignproc.CommandType = System.Data.CommandType.StoredProcedure;
            assignproc.Parameters.Add(new SqlParameter("@courseId", cID));
            assignproc.Parameters.Add(new SqlParameter("@Sid", loggedUser));

            conn.Open();
            assignproc.ExecuteNonQuery();
          //SqlDataReader rdr = assignproc.ExecuteReader(CommandBehavior.CloseConnection);
            StringBuilder table = new StringBuilder();

          
                SqlDataReader rdr = assignproc.ExecuteReader();
                table.Append("<table border='1'>");
                table.Append("<tr><th>CourseID</th>" +
                             "<th>Assignment Number</th>" +
                             "<th>Assignment Type</th>" +
                             "<th>Full Grade</th>" +
                             "<th>Weight</th>" +
                             "<th>Deadline</th>" +
                             "<th>Content</th>");
                table.Append("</tr>");
                if (rdr.HasRows) {
                    while (rdr.Read()) {
                        table.Append("<tr>");
                        table.Append("<td>" +rdr[0]+"</td>");
                        table.Append("<td>" +rdr[1]+ "</td>");
                        table.Append("<td>" +rdr[2]+ "</td>");
                        table.Append("<td>" +rdr[3]+ "</td>");
                        table.Append("<td>" +rdr[4]+ "</td>");
                        table.Append("<td>" +rdr[4]+ "</td>");
                        table.Append("<td>" +rdr[6]+ "</td>");
                        table.Append("</tr>");
                    }
                }
                table.Append("</table>");
                PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
                rdr.Close();
           
            
            conn.Close();


            /*
            Label a1 = new Label();
            a1.Text = "Course ID.....";
            Label a2 = new Label();
            a2.Text = "Assignment Number.....";
            Label a3 = new Label();
            a3.Text = "Assignment Type.....";
            Label a4 = new Label();
            a4.Text = "Full Grade.....";
            Label a5 = new Label();
            a5.Text = "Weight.....";
            Label a6 = new Label();
            a6.Text = "Deadline.....";
            Label a7 = new Label();
            a7.Text = "Content.....";

            form1.Controls.Add(a1);
            form1.Controls.Add(a2);
            form1.Controls.Add(a3);
            form1.Controls.Add(a4);
            form1.Controls.Add(a5);
            form1.Controls.Add(a6);
            form1.Controls.Add(a7);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(new LiteralControl("<br />"));
            while (rdr.Read())
            {
               int a = rdr.GetInt32(rdr.GetOrdinal("cid"));
                Label Course = new Label();
                Course.Text = a.ToString()+" ----  ";
                form1.Controls.Add(Course);
                ////
                int b = rdr.GetInt32(rdr.GetOrdinal("number"));
                Label AssignmentNumber = new Label();
                AssignmentNumber.Text = b.ToString() + " ----  ";
                form1.Controls.Add(AssignmentNumber);
                ////
                String c = rdr.GetString(rdr.GetOrdinal("type"));
                Label Type = new Label();
                Type.Text =c + " ----  ";
                form1.Controls.Add(Type);
                ////
                int d = rdr.GetInt32(rdr.GetOrdinal("fullGrade"));
                Label FullGrade = new Label();
                FullGrade.Text =d.ToString() + " ----  ";
                form1.Controls.Add(FullGrade);
                ////
                decimal ee = rdr.GetDecimal(rdr.GetOrdinal("weight"));
                Label Weight = new Label();
                Weight.Text =ee.ToString() + " ----  ";
                form1.Controls.Add(Weight);
                ////
                DateTime f = rdr.GetDateTime(rdr.GetOrdinal("deadline"));
                Label Deadline = new Label();
                Deadline.Text =f.ToString() + " ----  ";
                form1.Controls.Add(Deadline);
                ////
                String g = rdr.GetString(rdr.GetOrdinal("content"));
                Label Content = new Label();
                Content.Text =g;
                form1.Controls.Add(Content);
                form1.Controls.Add(new LiteralControl("<br />"));
            }*/
        }
    }
}