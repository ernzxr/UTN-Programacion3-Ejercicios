using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4
{
    public partial class App1a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                // Connection to SQL Server
                string rutaNeptunoSQL = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = rutaNeptunoSQL;
                cn.Open();

                // Query
                // SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", cn);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Productos";
                cmd.Connection = cn;

                // Get data from query
                SqlDataReader dr = cmd.ExecuteReader();

                // Show data
                grdProductos.DataSource = dr;
                grdProductos.DataBind();

                cn.Close();
            }
        }
    }
}