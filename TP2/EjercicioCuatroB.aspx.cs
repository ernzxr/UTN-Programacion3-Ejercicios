﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class EjercicioCuatroB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Request.QueryString["msj"];
            userName = char.ToUpper(userName[0]) + userName.Substring(1);
            lblWelcome.Text = $"Bienvenido a mi página Sr./a {userName}";
        }
    }
}