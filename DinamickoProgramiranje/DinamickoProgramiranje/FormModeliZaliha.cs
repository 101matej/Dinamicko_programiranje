using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamickoProgramiranje
{
    public partial class FormModeliZaliha : Form
    {
        public FormModeliZaliha()
        {
            InitializeComponent();
        }

        private void btnZad1_Click(object sender, EventArgs e)
        {
            Form FormZadatak1 = new FormZadatak1();
            this.Hide();
            FormZadatak1.ShowDialog();
            this.Show();
        }

        private void btnZad2_Click(object sender, EventArgs e)
        {
            Form FormZadatak2 = new FormZadatak2();
            this.Hide();
            FormZadatak2.ShowDialog();
            this.Show();
        }

        private void btnZad3_Click(object sender, EventArgs e)
        {
            Form FormZadatak3 = new FormZadatak3();
            this.Hide();
            FormZadatak3.ShowDialog();
            this.Show();
        }

        private void btnZad4_Click(object sender, EventArgs e)
        {

        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
