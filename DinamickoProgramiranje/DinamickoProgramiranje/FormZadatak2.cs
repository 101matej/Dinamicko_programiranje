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

        private void FormZadatak2_Load(object sender, EventArgs e)
        {
            GroupBox gbCP = gbPojmovnik;
            gbCP.Anchor = AnchorStyles.None;
            gbCP.Location = new Point((this.ClientSize.Width - gbCP.Width) / 2, 30);

            GroupBox gbCI = gbIzracun;
            gbCI.Anchor = AnchorStyles.None;
            gbCI.Location = new Point((this.ClientSize.Width - gbCI.Width) / 2, gbCP.Height + 50);

            GroupBox gbP = gbPostupak;
            gbP.Anchor = AnchorStyles.None;
            gbP.Location = new Point((this.ClientSize.Width - gbP.Width) / 2, 2 * gbCP.Height + 135);

            Button btnNazadC = btnNazad;
            btnNazadC.Anchor = AnchorStyles.None;
            btnNazadC.Location = new Point(((this.ClientSize.Width - btnNazadC.Width) / 2), (2 * gbCI.Height + 220));
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
            rtbPostupak.SelectionFont = new Font(rtbPostupak.Font, FontStyle.Bold);
            rtbPostupak.AppendText($"Q ≈ {numQZaokruzeno}\n");
        }
    }
}
