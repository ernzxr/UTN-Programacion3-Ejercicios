﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4
{
    public partial class App1b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
                grdProductos.DataSource = ds.Tables["Productos"];
                grdProductos.DataBind();

                cn.Close();
            }
        }
    }
}