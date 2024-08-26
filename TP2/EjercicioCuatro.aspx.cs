using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class EjercicioCuatro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidate_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "claudio" && txtPassword.Text == "casas")
            {
                Response.Redirect($"EjercicioCuatroB.aspx?msj={txtUser.Text}");
            }
            else
            {
                Response.Redirect("EjercicioCuatroC.aspx");
            }
        }
    }
}