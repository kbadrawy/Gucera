using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class studentHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {}
        protected void Home(object sender, EventArgs e)
        { Response.Redirect("studentHome.aspx"); }
        protected void mobile(object sender, EventArgs e)
        {
            Response.Redirect("mobileNumber.aspx");
        }
        protected void profile(object sender, EventArgs e)
        {
            Response.Redirect("viewProfile.aspx");
        }
        protected void acceptedC(object sender, EventArgs e)
        {
            Response.Redirect("courses.aspx");
        }
        protected void enrollC(object sender, EventArgs e)
        {
            Response.Redirect("enroll.aspx");
        }
        protected void credit(object sender, EventArgs e)
        {
            Response.Redirect("addCreditCard.aspx");
        }
        protected void promo(object sender, EventArgs e)
        {
            Response.Redirect("viewPromocode.aspx");
        }
        protected void content(object sender, EventArgs e)
        {
            Response.Redirect("studentViewAssignment.aspx");
        }
        protected void submit(object sender, EventArgs e)
        {
            Response.Redirect("studentSubmitAssignment.aspx");
        }
        protected void grade(object sender, EventArgs e)
        {
            Response.Redirect("studentViewAssignGrade.aspx");
        }
        protected void fb(object sender, EventArgs e)
        {
            Response.Redirect("studentAddFeedback.aspx");
        }
        protected void cer(object sender, EventArgs e)
        {
            Response.Redirect("studentListCertificates.aspx");
        }
    }
}