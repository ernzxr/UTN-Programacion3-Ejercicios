using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJ01
{
    public partial class App6b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name;
            string lastName;
            name = Request["txtName"].ToString();
            lastName = ((TextBox)PreviousPage.FindControl("txtLastName")).Text;
            lblFullName.Text = $"Bienvenido/a {lastName} {name}";
        }
    }
}