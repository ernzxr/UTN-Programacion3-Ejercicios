using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class ExerciseFormThree : Form
    {
        public ExerciseFormThree()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblPreview.Text = "";
            lblPreview.Text += "Usted seleccionó los siguientes elementos:";

            lblPreview.Text += rbtnMale.Checked
                ? "\nSexo: " + rbtnMale.Text
                : rbtnFemale.Checked
                ? "\nSexo: " + rbtnFemale.Text
                : "\nSexo: " + rbtnOther.Text;

            lblPreview.Text += rbtnMarried.Checked
                ? "\nEstado Civil: " + rbtnMarried.Text
                : "\nEstado civil: " + rbtnSingle.Text;

            lblPreview.Text += "\nOficio:";
            foreach (string job in clbOccupation.CheckedItems)
            {
                lblPreview.Text += "\n  - " + job;
            }
        }

        private void clbOccupation_SelectedValueChanged(object sender, EventArgs e)
        {
            btnShow.Enabled = clbOccupation.CheckedItems.Count > 0;
        }
    }
}
