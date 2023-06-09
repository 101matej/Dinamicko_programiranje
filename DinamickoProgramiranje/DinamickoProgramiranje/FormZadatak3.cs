﻿using System;
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

        private void FormZadatak3_Load(object sender, EventArgs e)
        {
            GroupBox gbCP = gbPojmovnik;
            gbCP.Anchor = AnchorStyles.None;
            gbCP.Location = new Point((this.ClientSize.Width - gbCP.Width) / 2, 30);

            GroupBox gbCI = gbIzracun;
            gbCI.Anchor = AnchorStyles.None;
            gbCI.Location = new Point((this.ClientSize.Width - gbCI.Width) / 2, gbCP.Height + 50);

            GroupBox gbP = gbPostupak;
            gbP.Anchor = AnchorStyles.None;
            gbP.Location = new Point((this.ClientSize.Width - gbP.Width) / 2, 2 * gbCP.Height + 155);

            Button btnNazadC = btnNazad;
            btnNazadC.Anchor = AnchorStyles.None;
            btnNazadC.Location = new Point(((this.ClientSize.Width - btnNazadC.Width) / 2), (2 * gbCI.Height + 190));
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
            rtbPostupak.SelectionFont = new Font(rtbPostupak.Font, FontStyle.Bold);
            rtbPostupak.AppendText($"T ≈ {numTZaokruzeno}\n");
        }
    }
}
