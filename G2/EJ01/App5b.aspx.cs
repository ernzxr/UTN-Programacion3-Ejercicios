using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJ01
{
    public partial class App5b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name;
            string lastName;
            name = Request.QueryString["name"];
            lastName = Request.QueryString["lastname"];
            lblFullName.Text = $"Bienvenido {name} {lastName}";
        }
    }
}