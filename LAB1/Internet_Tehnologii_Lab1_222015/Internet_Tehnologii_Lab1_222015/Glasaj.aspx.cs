using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Internet_Tehnologii_Lab1_222015
{
    public partial class Glasaj : System.Web.UI.Page
    {
        List<string> teachers { set; get; }
        List<string> subjects { set; get; }
        List<int> credits { set; get; }
        protected void Page_Load(object sender, EventArgs e)
        {

            teachers = new List<string>();
            subjects = new List<string>();
            credits = new List<int>();

            if (!IsPostBack)
            {
                // Fill the lists when it is not a postback
                subjects.AddRange(new string[] { "IT", "IPKS", "OPP", "SP", "OP", "KM" });
                teachers.AddRange(new string[] { "Goce", "Vlatko", "Stefan", "Emil", "Igor", "Gusev" });
                credits.AddRange(new int[] { 5, 5, 6, 5, 6, 4 });

                ViewState["Subjects"] = subjects;
                ViewState["Teachers"] = teachers;
                ViewState["Credits"] = credits;

                ddlPredmeti.DataSource = subjects;
                ddlPredmeti.DataBind();
                ddlKrediti.DataSource = credits;
                ddlKrediti.DataBind();
            }
            else
            {
                subjects = ViewState["Subjects"] as List<string> ?? new List<string>();
                teachers = ViewState["Teachers"] as List<string> ?? new List<string>();
                credits = ViewState["Credits"] as List<int> ?? new List<int>();
            }
            // Debugging statement to check the count of teachers
            //Debug.WriteLine($"Teachers count: {teachers.Count}");

            // Debugging statement to check the content of teachers
            //Debug.WriteLine("Teachers: " + string.Join(", ", teachers));

        }

        protected void btnVote_Click(object sender, EventArgs e)
        {
            if (ddlPredmeti.SelectedIndex != -1 && ddlKrediti.SelectedIndex != -1)
                Response.Redirect("UspesnoGlasanje.aspx");
        }

        protected void ddlPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Debugging statement to check the count of teachers
            //  Debug.WriteLine($"Teachers count: {teachers.Count}");

            // Debugging statement to check the content of teachers
            //Debug.WriteLine("Teachers: " + string.Join(", ", teachers));

            if (ddlPredmeti.SelectedIndex != -1)
            {
                LabelProfesor.Text = teachers[ddlPredmeti.SelectedIndex].ToString();
                ddlKrediti.SelectedIndex = ddlPredmeti.SelectedIndex;
            }
        }
    }
}