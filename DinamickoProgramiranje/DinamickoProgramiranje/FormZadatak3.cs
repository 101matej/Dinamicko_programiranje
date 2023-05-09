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
    public partial class FormZadatak3 : Form
    {
        double numT, numC;
        int numM, numP, numR, numTZaokruzeno;
        int broj = 266450;

        public FormZadatak3()
        {
            InitializeComponent();
            gbPostupak.Hide();
            brojC.Maximum = int.MaxValue;
            brojM.Maximum = int.MaxValue;
            brojP.Maximum = int.MaxValue;
            brojR.Maximum = int.MaxValue;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            rtbPostupak.Clear();
            spremiVrijednosti();
            izracunaj();
            gbPostupak.Show();
        }

        private void spremiVrijednosti()
        {
            numM = (int)brojM.Value;
            numP = (int)brojP.Value;
            numR = (int)brojR.Value;
            numC = (double)(brojC.Value / 100);
        }

        private void izracunaj()
        {
            numT = Math.Round(Math.Sqrt((broj * numP) / (numM * numR * numC)), 2);
            numTZaokruzeno = (int)Math.Round(numT, 0);
            rtbPostupak.AppendText($"T = √((266450*P)/(M*R*C))\n");
            rtbPostupak.AppendText($"T = √(({broj}*{numP})/({numM}*{numR}*{numC}))\n");
            rtbPostupak.AppendText($"T = {numT}\n");
            rtbPostupak.AppendText($"T ≈ {numTZaokruzeno}\n");
        }
    }
}
