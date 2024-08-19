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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExerciseThree_Click(object sender, EventArgs e)
        {
            ExerciseFormThree form = new ExerciseFormThree();
            form.Show();
        }

        private void btnExerciseTwo_Click(object sender, EventArgs e)
        {
            ExerciseFormTwo form = new ExerciseFormTwo();
            form.Show();
        }

        private void btnExerciseOne_Click(object sender, EventArgs e)
        {
            ExerciseFormOne form = new ExerciseFormOne();
            form.Show();
        }
    }
}
