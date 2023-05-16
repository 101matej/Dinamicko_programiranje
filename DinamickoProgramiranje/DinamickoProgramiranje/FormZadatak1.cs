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
    public partial class FormZadatak1 : Form
    {
        double numN, numC;
        int numA, numP, numNZaokruzeno, numM, numR, numAUmnozak;
        bool tipA = false;
        bool tipMR = false;

        public FormZadatak1()
        {
            InitializeComponent();
            gbPostupak.Hide();
            brojA.Maximum = int.MaxValue;
            brojP.Maximum = int.MaxValue;
            brojC.Maximum = int.MaxValue;
            brojR.Maximum = int.MaxValue;
            brojM.Maximum = int.MaxValue;
            brojA.Enabled = false;
            brojM.Enabled = false;
            brojR.Enabled = false;
        }

        private void btnTipA_Click(object sender, EventArgs e)
        {
            brojA.Enabled = true;
            brojM.Enabled = false;
            brojR.Enabled = false;
            tipA = true;
            tipMR = false;
            brojM.Value = 0;
            brojR.Value = 0;
            btnTipA.FlatAppearance.BorderColor = Color.Purple;
            btnTipA.FlatAppearance.BorderSize = 2;
            btnTipA.FlatStyle = FlatStyle.Flat;

            btnTipMR.FlatAppearance.BorderColor = Color.White;
            btnTipMR.FlatAppearance.BorderSize = 0;
            btnTipMR.FlatStyle = FlatStyle.Standard;
        }

        private void btnTipMR_Click(object sender, EventArgs e)
        {
            brojA.Enabled = false;
            brojM.Enabled = true;
            brojR.Enabled = true;
            tipMR = true;
            tipA = false;
            brojA.Value = 0;
            btnTipMR.FlatAppearance.BorderColor = Color.Purple;
            btnTipMR.FlatAppearance.BorderSize = 2;
            btnTipMR.FlatStyle = FlatStyle.Flat;

            btnTipA.FlatAppearance.BorderColor = Color.White;
            btnTipA.FlatAppearance.BorderSize = 0;
            btnTipA.FlatStyle = FlatStyle.Standard;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormZadatak1_Load(object sender, EventArgs e)
        {
            GroupBox gbCP = gbPojmovnik;
            gbCP.Anchor = AnchorStyles.None;
            gbCP.Location = new Point((this.ClientSize.Width - gbCP.Width) / 2, 10);

            GroupBox gbT = gbTip;
            gbT.Anchor = AnchorStyles.None;
            gbT.Location = new Point((this.ClientSize.Width - gbT.Width) / 2, gbT.Height + 100);

            GroupBox gbCI = gbIzracun;
            gbCI.Anchor = AnchorStyles.None;
            gbCI.Location = new Point((this.ClientSize.Width - gbCI.Width) / 2, gbCP.Height + 125);

            GroupBox gbP = gbPostupak;
            gbP.Anchor = AnchorStyles.None;
            gbP.Location = new Point((this.ClientSize.Width - gbP.Width) / 2, 2*gbCI.Height + 70);

            Button btnNazadC = btnNazad;
            btnNazadC.Anchor = AnchorStyles.None;
            btnNazadC.Location = new Point(((this.ClientSize.Width - btnNazadC.Width) / 2), (3 * gbCI.Height + 85));

            btnTipA.FlatAppearance.BorderColor = Color.White;
            btnTipA.FlatAppearance.BorderSize = 0;
            btnTipA.FlatStyle = FlatStyle.Standard;

            btnTipMR.FlatAppearance.BorderColor = Color.White;
            btnTipMR.FlatAppearance.BorderSize = 0;
            btnTipMR.FlatStyle = FlatStyle.Standard;   
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
            numA = (int)brojA.Value;
            numP = (int)brojP.Value;
            numC = (double)(brojC.Value/100);
            numM = (int)brojM.Value;
            numR = (int)brojR.Value;
        }

        private void izracunaj()
        {
            if (tipA == true)
            {
                numN = Math.Round(Math.Sqrt((numA * numC) / (2 * numP)), 2);
                numNZaokruzeno = (int)Math.Round(numN, 0);
                rtbPostupak.AppendText($"N = √((A*C)/(2*P))\n");
                rtbPostupak.AppendText($"N = √(({numA}*{numC})/(2*{numP}))\n");
                rtbPostupak.AppendText($"N = {numN}\n");
                rtbPostupak.SelectionFont = new Font(rtbPostupak.Font, FontStyle.Bold);
                rtbPostupak.AppendText($"N ≈ {numNZaokruzeno}\n");
            }

            if (tipMR == true)
            {
                numAUmnozak = numM * numR;
                rtbPostupak.AppendText($"A = M*R\n");
                rtbPostupak.AppendText($"A = {numM}*{numR}\n");
                rtbPostupak.AppendText($"A = {numAUmnozak}\n");
                numN = Math.Round(Math.Sqrt((numAUmnozak * numC) / (2 * numP)), 2);
                numNZaokruzeno = (int)Math.Round(numN, 0);
                rtbPostupak.AppendText($"N = √((A*C)/(2*P))\n");
                rtbPostupak.AppendText($"N = √(({numAUmnozak}*{numC})/(2*{numP}))\n");
                rtbPostupak.AppendText($"N = {numN}\n");
                rtbPostupak.SelectionFont = new Font(rtbPostupak.Font, FontStyle.Bold);
                rtbPostupak.AppendText($"N ≈ {numNZaokruzeno}\n");
            }

            
        }
    }
}
