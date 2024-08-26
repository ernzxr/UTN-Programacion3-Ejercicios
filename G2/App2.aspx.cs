using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJ01
{
    public partial class App2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNumber.Text);

            string table;
            table = "<table border='1'>";
            table += "<tr>";
            table += "<td>Producto</td>";
            table += "<td>Resultado</td>";
            table += "</tr>";
            for (int i = 0; i <= 10; i++)
            {
                table += "<tr>";
                table += "<td>" + num + " x " + i + "</td>";
                table += "<td>" + num * i + "</td>";
                table += "</tr>";
            }
            table += "</table>";

            lblMessage.Text = table;
        }
    }
}