using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { }
        protected void NewAccount(object sender, EventArgs e)
        {
            newAccount.Style.Add("visibility", "visible");
        }
        protected void Inst(object sender, EventArgs e)
        {
            Response.Redirect("InstructorRegister.aspx");
        }
        protected void Stud(object sender, EventArgs e)
        {
            Response.Redirect("StudentRegister.aspx");
        }
            protected void login(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(UserName.Text);
            String pass = Password.Text;

            SqlCommand loginproc = new SqlCommand("userLogin", conn);

            loginproc.CommandType = System.Data.CommandType.StoredProcedure;
            
            loginproc.Parameters.Add(new SqlParameter("@id", id));
            loginproc.Parameters.Add(new SqlParameter("@password", pass));

            SqlParameter success = loginproc.Parameters.Add("@success", SqlDbType.Int);
            SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.Int);

            success.Direction = ParameterDirection.Output;
            type.Direction = ParameterDirection.Output;


            //Executing the SQLCommand
            conn.Open();
            loginproc.ExecuteNonQuery();
            conn.Close();

            if (success.Value.ToString() == "1")
            {
                Session["user"] = id;
                Response.Write("Hello");
                if (type.Value.ToString() == "1") {
                    Response.Redirect("adminHome.aspx");
                }
                else {
                    if (type.Value.ToString() == "2") {
                        Response.Redirect("studentHome.aspx");
                    }
                    else {
                        Response.Write("Instructor logged in successfully, however we did NOT implement its component!");
                    } 
                }
            }
        }
    }
}
