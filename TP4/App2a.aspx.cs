using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4
{
    public partial class App2a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", cn);

            SqlDataReader dr = cmd.ExecuteReader();

            ddlProductos.DataSource = dr;

            ddlProductos.DataTextField = "NombreProducto";
            ddlProductos.DataValueField = "IdProducto";

            ddlProductos.DataBind();

            cn.Close();
        }
    }
}