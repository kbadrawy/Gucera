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
    public partial class mobileNumber : System.Web.UI.Page
    {
        protected void Home(object sender, EventArgs e)
        {Response.Redirect("studentHome.aspx"); }

        protected void Yes(object sender, EventArgs e)
        {
            Response.Redirect("mobileNumber.aspx"); ;
        }
        protected void Page_Load(object sender, EventArgs e)
        {}
        protected void Mobile(object sender, EventArgs e)
        {
        string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

         //int loggedUser = (int)Session["user"];
         int loggedUser = 1034;
         String number = Number.Text;

        SqlCommand add = new SqlCommand("addMobile", conn);

        add.CommandType = System.Data.CommandType.StoredProcedure;
            
            add.Parameters.Add(new SqlParameter("@ID", loggedUser));
            add.Parameters.Add(new SqlParameter("@mobile_number", number));

            //Executing the SQLCommand
            conn.Open();
            try
            {
                add.ExecuteNonQuery();
                firstOne.Style.Add("visibility", "hidden");
                anotherOne.Style.Add("visibility", "visible");
            }
            catch (Exception ) {
                Response.Write("Invalid Input! Please enter a valid mobile number! ");
            }
            
            conn.Close();

}
    }
}