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
    public partial class ExerciseFormTwo : Form
    {
        public ExerciseFormTwo()
        {
            InitializeComponent();
        }

        private bool ValidateFullName(string fullName)
        {
            foreach (string _fullName in lbFullName.Items)
            {
                if (_fullName.ToUpper().Equals(fullName.ToUpper()))
                {
                    return false;
                }
            }
            return true;
        }

        private void ValidateCompletedFullName()
        {
            if(txtName.Text.Trim().Length > 0 && txtLastName.Text.Trim().Length > 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string _name = txtName.Text.Trim();
            string _lastName = txtLastName.Text.Trim();
            string _fullName = _name + " " + _lastName;
            if(ValidateFullName(_fullName))
            {
                lbFullName.Items.Add(_fullName);
                txtName.Text = "";
                txtLastName.Text = "";
                btnAdd.Enabled = false;
            }
            else
            {
                MessageBox.Show("La persona ya se encuentra registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ValidateCompletedFullName();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateCompletedFullName();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbFullName.SelectedItem != null)
            {
                lbFullName.Items.Remove(lbFullName.SelectedItem);
                UpdateButtonsState();
            }
            else
            {
                MessageBox.Show("Seleccione un elemento de la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbFullName_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateButtonsState();
        }

        private void UpdateButtonsState()
        {
            bool hasSelectedItem = lbFullName.SelectedItem != null;
            btnDelete.Enabled = hasSelectedItem;
            btnUnselect.Enabled = hasSelectedItem;
        }

        private void btnUnselect_Click(object sender, EventArgs e)
        {
            lbFullName.SelectedItem = null;
            UpdateButtonsState();
        }

        private void lbFullName_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbFullName.IndexFromPoint(e.Location) == ListBox.NoMatches)
            {
                lbFullName.SelectedItem = null;
                UpdateButtonsState();
            }
        }
    }
}
