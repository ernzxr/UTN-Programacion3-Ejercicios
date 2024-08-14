using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ06
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ValidarOk()
        {
            //Habilita el Boton, siempre y cuando txtNombre tenga datos.
            btnAccept.Enabled = (txtName.BackColor != Color.Red);
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
                tb.BackColor = Color.Red;
            else
                tb.BackColor = System.Drawing.SystemColors.Window;
            ValidarOk();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Deshabilito el Boton Ok.
            btnAccept.Enabled = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //No valido datos ya que si el Boton esta Habilitado
            //es porque paso el Evento Validating del Nombre.
            String salida; //Declaro una variable para armar la salida.
            salida = "Nombre: " + txtName.Text + "\r\n";
            salida += "Ocupación: " + (cbxProgrammer.Checked ?
            "PROGRAMADOR" : "OTRO") + "\r\n";
            salida += "Sexo: " + (rbtnMale.Checked ? "HOMBRE" :
            "MUJER") + "\r\n";
            //Vuelco la salida al TextBox Salida.
            txtOutput.Text = salida;
        }
    }
}
