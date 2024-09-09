using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4
{
    public partial class App2b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Se crea la conexion a SQL Server
            SqlConnection cn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
            cn.Open();

            // Se crea la consulta SQL
            SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", cn);

            // Se ejecuta la consulta y se obtienen los datos
            SqlDataAdapter adap = new SqlDataAdapter(cmd);

            // Se crea un DataSet y se llena con los datos obtenidos
            DataSet ds = new DataSet();
            adap.Fill(ds, "Productos");

            // Se asigna el DataSet al control GridView
            ddlProductos.DataSource = ds.Tables["Productos"];

            ddlProductos.DataTextField = "NombreProducto";
            ddlProductos.DataValueField = "IdProducto";

            ddlProductos.DataBind();

            cn.Close();
        }
    }
}