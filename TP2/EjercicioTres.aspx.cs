using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class EjercicioTres : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnRed_Click(object sender, EventArgs e)
        {
            lblTextColor.ForeColor = System.Drawing.Color.Red;
        }

        protected void lbtnBlue_Click(object sender, EventArgs e)
        {
            lblTextColor.ForeColor = System.Drawing.Color.Blue;
        }

        protected void lbtnGreen_Click(object sender, EventArgs e)
        {
            lblTextColor.ForeColor = System.Drawing.Color.Green;
        }
    }
}