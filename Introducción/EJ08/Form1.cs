using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ08
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            clbNumbers.Items.Add("Diez");
        }

        private void btnMove_MouseClick(object sender, MouseEventArgs e)
        {
            if (clbNumbers.CheckedItems.Count > 0)
            {
                lbNumbers.Items.Clear();
                foreach (string item in clbNumbers.CheckedItems)
                {
                    lbNumbers.Items.Add(item);
                }
                for (int i = 0; i < clbNumbers.Items.Count; i++) {
                    //Con el Metodo SetItemChecked, establesco en falso la
                    //casilla de verificación (No esta seleccionado).
                    //Como parametros i-El Indice y el valor de estado en este caso false.
                    clbNumbers.SetItemChecked(i, false);
                }
            }
        }
    }
}
