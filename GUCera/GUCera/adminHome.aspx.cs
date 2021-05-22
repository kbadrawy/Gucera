using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class adminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {}
        protected void mobile(object sender, EventArgs e)
        { Response.Redirect("mobileNumber.aspx"); }
        protected void allC(object sender, EventArgs e)
        { Response.Redirect("AdminListAllCourses.aspx"); }
        protected void notAcc(object sender, EventArgs e)
        { Response.Redirect("AdminListCoursesNotAccepted.aspx"); }
        protected void acc(object sender, EventArgs e)
        { Response.Redirect("AdminAcceptReqCourses.aspx"); }
        protected void createPC(object sender, EventArgs e)
        { Response.Redirect("AdminCreatePromoCode.aspx"); }
        protected void issuePC(object sender, EventArgs e)
        { Response.Redirect("AdminIssuePromoCode.aspx"); }
    }
}