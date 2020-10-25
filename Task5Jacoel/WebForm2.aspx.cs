using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task5Jacoel
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fname = (string) Session["FirstName"];
            string lname = (string) Session["LastName"];

            Label1.Text = fname + " " + lname;
        }
    }
}