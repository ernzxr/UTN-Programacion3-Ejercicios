using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJ01
{
    public partial class App4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void ddlColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMessage.Text = ddlColors.SelectedItem.ToString();
        }
    }
}