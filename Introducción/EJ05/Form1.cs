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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string age = txtAge.Text.Trim();
            string address = txtAddress.Text.Trim();

            if(name == "" || surname == "" || age == "" || address == "")
            {
                if (name == "")
                {
                    txtName.BackColor = Color.Red;
                }
                else
                {
                    txtName.BackColor = System.Drawing.SystemColors.Control;
                }

                if (surname == "")
                {
                    txtSurname.BackColor = Color.Red;
                }
                else
                {
                    txtSurname.BackColor = System.Drawing.SystemColors.Control;
                }

                if (age == "")
                {
                    txtAge.BackColor = Color.Red;
                }
                else
                {
                    txtAge.BackColor = System.Drawing.SystemColors.Control;
                }

                if (address == "")
                {
                    txtAddress.BackColor = Color.Red;
                }
                else
                {
                    txtAddress.BackColor = System.Drawing.SystemColors.Control;
                }
            }
            else
            {
                txtName.BackColor = System.Drawing.SystemColors.Control;
                txtSurname.BackColor = System.Drawing.SystemColors.Control;
                txtAge.BackColor = System.Drawing.SystemColors.Control;
                txtAddress.BackColor = System.Drawing.SystemColors.Control;

                txtResult.Text = "Apellido y Nombre: " + surname + " " + name + Environment.NewLine +
                                         "Edad: " + age + Environment.NewLine +
                                         "Dirección: " + address;
            }
        }
    }
}
