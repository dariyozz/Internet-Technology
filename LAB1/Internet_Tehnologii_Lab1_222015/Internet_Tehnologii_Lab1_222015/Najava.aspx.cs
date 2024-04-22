using System;

namespace Internet_Tehnologii_Lab1_222015
{
    public partial class Najava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(Page.IsValid) {
                Response.Redirect("Glasaj.aspx");
            }
        }

    }
}