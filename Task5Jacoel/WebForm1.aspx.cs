using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task5Jacoel
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            bool validate = false;
            /// To check if required fields are there
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtPassword2.Text == "")
            {
                if (txtFirstName.Text == "") lblFirstName.Visible = true; else lblFirstName.Visible = false;
                if (txtLastName.Text == "") lblLastName.Visible = true; else lblLastName.Visible = false;
                if (txtEmail.Text == "") lblEmail.Visible = true; else lblEmail.Visible = false;
                if (txtPassword.Text == "") lblPassword.Visible = true; else lblPassword.Visible = false;
                if (txtPassword2.Text == "") { lblPassword2.Text = "*This field is required"; lblPassword2.Visible = true; } else lblPassword2.Visible = false;


            }
            /// To check if the passwords match
            else if (txtPassword.Text != txtPassword2.Text)
            {
                lblPassword2.Text = "*Passwords do not match";
                lblPassword2.Visible = true;
            }
            else
            {
                lblPassword.Visible = false;
                lblPassword2.Visible = false;

                Session["FirstName"] = txtFirstName.Text;
                Session["LastName"] = txtLastName.Text;

                txtDisplay.Text += txtFirstName.Text + " " + txtLastName.Text + "\n";
                txtDisplay.Text += txtEmail.Text + "\n";
                txtDisplay.Text += lstCountry.SelectedValue + "\n";

                Response.Redirect("/WebForm2.aspx");
            }
        }
    }
}