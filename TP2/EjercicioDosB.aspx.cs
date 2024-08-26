using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class EjercicioDosB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name, lastname, zone, themes = "";
            DropDownList city;
            CheckBoxList cblThemes;

            name = ((TextBox)PreviousPage.FindControl("txtName")).Text;
            lastname = ((TextBox)PreviousPage.FindControl("txtLastname")).Text;
            city = ((DropDownList)PreviousPage.FindControl("ddlCity"));
            cblThemes = ((CheckBoxList)PreviousPage.FindControl("cblThemes"));

            zone = city.SelectedValue.Split(' ')[1];
            zone = char.ToUpper(zone[0]) + zone.Substring(1);

            bool firstItem = true;

            foreach (ListItem item in cblThemes.Items)
            {
                if (item.Selected)
                {
                    if(firstItem)
                    {
                        themes = item.Value;
                        firstItem = false;
                    }
                    else
                    {
                        themes += "<br />";
                        themes += item.Value;
                    }
                }
            }

            lblName.Text = name;
            lblLastName.Text = lastname;
            lblZone.Text = zone;
            if (themes == "")
            {
                themes = "No se seleccionaron temas";
            }
            else
            {
                lblSelectedThemes.Text = themes;
            }
        }
    }
}