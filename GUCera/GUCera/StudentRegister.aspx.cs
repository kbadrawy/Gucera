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
    public partial class StudentRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {}
        protected void RegDone(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        protected void Register(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String first_name = firstName.Text;
            String last_name = lastName.Text;
            String password = Password.Text;
            String email = Email.Text;
            String address = Address.Text;
            String gender = Gender.Text;
            bool gen;
            if (gender.Equals("female"))
            { gen = true; }
            else { gen = false; }
            // byte[] gender = (byte[]).Parse(Gender.Text);

            SqlCommand stRegisterProc = new SqlCommand("StudentRegister", conn);

            //removed the : proc. ... needs @... which was not supplied
            stRegisterProc.CommandType = System.Data.CommandType.StoredProcedure;

            stRegisterProc.Parameters.Add(new SqlParameter("@first_name", first_name));
            stRegisterProc.Parameters.Add(new SqlParameter("@last_name", last_name));
            stRegisterProc.Parameters.Add(new SqlParameter("@password", password));
            stRegisterProc.Parameters.Add(new SqlParameter("@email", email));
            stRegisterProc.Parameters.Add(new SqlParameter("@address", address));
            stRegisterProc.Parameters.Add(new SqlParameter("@gender", gen));

            /*
            SqlParameter id = instRegisterProc.Parameters.Add("@id", SqlDbType.Int);       
            id.Direction = ParameterDirection.Output;
            */
           
            conn.Open();
            stRegisterProc.ExecuteNonQuery();

            SqlCommand instID = new SqlCommand("select id from Student", conn);
            instID.ExecuteNonQuery();
            SqlDataReader rdr = instID.ExecuteReader();
            String ID = "";
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    ID = (rdr.GetInt32(rdr.GetOrdinal("id"))).ToString();
                }
            }
            conn.Close();
            //string page = "login.aspx";
            string msg = "<br /><hr /><br />Your registration was completed successfuly!" +
                         "<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" +
                         "Your ID is: "
                          + ID +
                          "<br /><br /><hr /><br />";
            PlaceHolder1.Controls.Add(new Literal { Text = msg });
            regDone.Style.Add("visibility", "visible");
            regForm.Style.Add("visibility", "hidden");

            //   ClientScript.RegisterStartupScript
            //     (this.GetType(), "myalert", "alert('" + msg + "');Response.Redirect(page);", true);



            // Response.Write("Your registration was completed successfuly! Your ID is: " + ID); 

            //Response.Redirect("login.aspx");
        }
    }
}