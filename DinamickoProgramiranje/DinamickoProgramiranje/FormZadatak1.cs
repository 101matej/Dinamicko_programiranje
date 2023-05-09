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
    public partial class FormZadatak1 : Form
    {
        double numN, numC;
        int numA, numP, numNZaokruzeno;

        public FormZadatak1()
        {
            InitializeComponent();
            gbPostupak.Hide();
            brojA.Maximum = int.MaxValue;
            brojP.Maximum = int.MaxValue;
            brojC.Maximum = int.MaxValue;
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
            numA = (int)brojA.Value;
            numP = (int)brojP.Value;
            numC = (double)(brojC.Value/100);
        }

        private void izracunaj()
        {
            numN = Math.Round(Math.Sqrt((numA*numC)/(2*numP)),2);
            numNZaokruzeno = (int)Math.Round(numN,0);
            rtbPostupak.AppendText($"N = √((A*C)/(2*P))\n");
            rtbPostupak.AppendText($"N = √(({numA}*{numC})/(2*{numP}))\n");
            rtbPostupak.AppendText($"N = {numN}\n");        
            rtbPostupak.AppendText($"N ≈ {numNZaokruzeno}\n");
        }
    }
}
