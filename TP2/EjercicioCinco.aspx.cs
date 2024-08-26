using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class EjercicioCinco1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            float price = 0;

            price += float.Parse(ddlRAM.SelectedValue);

            foreach (ListItem item in cblAccesories.Items)
            {
                if (item.Selected)
                {
                    price += float.Parse(item.Value);
                }
            }

            string finalPrice = price.ToString("F2");

            lblPrice.Text = $"El precio final es de {finalPrice}$";
        }
    }
}