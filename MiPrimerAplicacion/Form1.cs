using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenidos a mi primer aplicación en C#");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Chau Chau ...");
        }


        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            if (txtDescription.Text == "")
            {
                txtDescription.BackColor = Color.Red;
            }
            else
            {
                txtDescription.BackColor = this.BackColor;
                MessageBox.Show(Text = "Hola " + txtDescription.Text, "Saludo");
            }
        }

        private void lbText_MouseMove(object sender, MouseEventArgs e)
        {
                lbText.BackColor = Color.WhiteSmoke;
            lbText.Cursor = Cursors.Hand;
        }

        private void lbText_MouseLeave(object sender, EventArgs e)
        {
            lbText.BackColor = System.Drawing.SystemColors.Window;
            lbText.Cursor = Cursors.Arrow;
        }


        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtNuevo_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtNuevo.Text.Length + " Caracteres");
        }
    }
}
