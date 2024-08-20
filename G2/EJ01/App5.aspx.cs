using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJ01
{
    public partial class App5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            Response.Redirect("App5b.aspx?name="+txtName.Text+"&lastname="+txtLastName.Text);
        }
    }
}