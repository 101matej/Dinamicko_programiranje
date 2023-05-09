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
    public partial class FormZadatak2 : Form
    {
        double numQ, numC;
        int numM, numP, numR, numQZaokruzeno;

        public FormZadatak2()
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
            numQ = Math.Round(Math.Sqrt((2*numM*numP) / (numR*numC)), 2);
            numQZaokruzeno = (int)Math.Round(numQ, 0);
            rtbPostupak.AppendText($"Q = √((2*M*P)/(R*C))\n");
            rtbPostupak.AppendText($"Q = √((2*{numM}*{numP})/({numR}*{numC}))\n");
            rtbPostupak.AppendText($"Q = {numQ}\n");
            rtbPostupak.AppendText($"Q ≈ {numQZaokruzeno}\n");
        }
    }
}
