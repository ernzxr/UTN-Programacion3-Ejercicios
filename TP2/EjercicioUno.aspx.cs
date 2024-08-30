using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class EjercicioCinco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        bool ValidateData(ref int productOneUnits, ref int productTwoUnits)
        {
            if (string.IsNullOrWhiteSpace(txtProductOneName.Text) ||
                string.IsNullOrWhiteSpace(txtProductTwoName.Text) ||
                !int.TryParse(txtProductTwoUnits.Text, out productTwoUnits) ||
                !int.TryParse(txtProductOneUnits.Text, out productOneUnits) ||
                productOneUnits < 1 ||
                productTwoUnits < 1)
            {
                return false;
            }
            return true;
        }

        protected void btnCreateTable_Click(object sender, EventArgs e)
        {
            int productOneUnits = 0, productTwoUnits = 0;
            if (ValidateData(ref productOneUnits, ref productTwoUnits))
            {
                string table = "<table border='1'>";
                table += "<tr><th>Producto</th><th>Cantidad</th></tr>";
                table += $"<tr><td>{txtProductOneName.Text}</td><td>{productOneUnits}</td></tr>";
                table += $"<tr><td>{txtProductTwoName.Text}</td><td>{productTwoUnits}</td></tr>";
                table += $"<tr><td>TOTAL</td><td>{productOneUnits + productTwoUnits}</td></tr>";
                table += "</table>";
                lblTable.Text = table;
            }
            else
            {
                lblTable.Text = "Por favor, complete los campos correctamente.";
            }
        }
    }
}