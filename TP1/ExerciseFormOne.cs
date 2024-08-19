using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TP1
{
    public partial class ExerciseFormOne : Form
    {
        public ExerciseFormOne()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string _name = txtName.Text.Trim();
            bool nameExists = false;

            foreach (string name in lbAddedNames.Items)
            {
                if (name.ToUpper().Equals(_name.ToUpper()))
                {
                    MessageBox.Show("El nombre ya fue agregado.");
                    nameExists = true;
                    break;
                }
            }

            if (!nameExists)
            {
                foreach (string name in lbSelectedNames.Items)
                {
                    if (name.ToUpper().Equals(_name.ToUpper()))
                    {
                        MessageBox.Show("El nombre ya fue agregado.");
                        nameExists = true;
                        break;
                    }
                }
            }

            if (!nameExists)
            {
                lbAddedNames.Items.Add(_name);
                txtName.Text = "";
                UpdateButtonsStates();
            }
        }

        private void UpdateAddState()
        {
            btnAdd.Enabled = !btnAdd.Enabled;
        }

        private void UpdateButtonsStates()
        {
            btnMoveSelection.Enabled = lbAddedNames.Items.Count > 0;
            btnMoveAll.Enabled = lbAddedNames.Items.Count > 0;
        }

        private void btnMoveSelection_Click(object sender, EventArgs e)
        {
            if (lbAddedNames.SelectedItem != null)
            {
                lbSelectedNames.Items.Add(lbAddedNames.SelectedItem);
                lbAddedNames.Items.Remove(lbAddedNames.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un nombre para mover.");
            }
            UpdateButtonsStates();
        }

        private void btnMoveAll_Click(object sender, EventArgs e)
        {
            lbSelectedNames.Items.AddRange(lbAddedNames.Items);
            lbAddedNames.Items.Clear();
            UpdateButtonsStates();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if(name.Length > 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
    }
}
