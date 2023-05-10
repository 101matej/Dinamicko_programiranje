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
    public partial class FormZadatak4 : Form
    {
        double numC, numRabat, numQ, numGTS, numARabat, numIPJNRabat, numGTSRabat;
        int numM, numP, numR, numQZaokruzeno, numUkupnoSRabatom, numA, numARabatZaokruzeno, numGTN, numGTNRabat, numIPJN, numIPJNRabatZaokruzeno, numSZUKO, numGTSZaokruzeno, numUkupnoBezRabata, numMinimalno, numPVZRabat, numGTSRabatZaokruzeno;
        bool tablicaPostoji = false;

        private void FormZadatak4_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
            nacrtajTablicu();
            gbTablica.Hide();

            Button btnNazadC = btnNazad;
            btnNazadC.Anchor = AnchorStyles.None;
            btnNazadC.Location = new Point(((this.ClientSize.Width - btnNazadC.Width) / 2), 700);
        }

        public DataGridView tablica;
        public GroupBox gbTablica;

        public FormZadatak4()
        {
            InitializeComponent();
            gbPostupakBezRabata.Hide();
            gbPostupakSRabatom.Hide();
            brojC.Maximum = int.MaxValue;
            brojM.Maximum = int.MaxValue;
            brojP.Maximum = int.MaxValue;
            brojR.Maximum = int.MaxValue;
            brojRabat.Maximum = int.MaxValue;
            brojMinimalno.Maximum = int.MaxValue;   

            //obrisati kasnije
            brojM.Value = 100000;
            brojR.Value = 40;
            brojP.Value = 200;
            brojC.Value = 25;
            brojRabat.Value = 2;
            brojMinimalno.Value = 10000;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            rtbPostupakBezRabata.Clear();
            rtbPostupakSRabatom.Clear();
            spremiVrijednosti();
            izracunaj();
            gbPostupakBezRabata.Show();
            gbPostupakSRabatom.Show();

            foreach (var kontrola in this.Controls)
            {
                if (kontrola.GetType() == typeof(GroupBox))
                {
                    GroupBox trenutniGroupBox = kontrola as GroupBox;
                    if (trenutniGroupBox.Text == "Usporedba:")
                    {
                        tablicaPostoji = true;
                        break;
                    }
                }
            }

            if (tablicaPostoji == true)
            {
                popuniTablicu();
                gbTablica.Show();
            }
        }

        private void spremiVrijednosti()
        {
            numM = (int)brojM.Value;
            numR = (int)brojR.Value;
            numP = (int)brojP.Value;
            numC = (double)(brojC.Value / 100);
            numRabat = (double)(brojRabat.Value / 100);
            numMinimalno = (int)brojMinimalno.Value;
        }

        private void izracunaj()
        {
            izracunajBezRabata();
            izracunajSRabatom();
        }

        private void izracunajBezRabata()
        {
            //OPTIMALAN BROJ JEDINICA PO NARUDŽBI
            numQ = Math.Round(Math.Sqrt((2 * numM * numP) / (numR * numC)), 2);
            numQZaokruzeno = (int)Math.Round(numQ, 0);
            rtbPostupakBezRabata.AppendText("Optimalan broj jedinica po narudžbi (Q)\n");
            rtbPostupakBezRabata.AppendText($"Q = √((2*M*P)/(R*C))\n");
            rtbPostupakBezRabata.AppendText($"Q = √((2*{numM}*{numP})/({numR}*{numC}))\n");
            rtbPostupakBezRabata.AppendText($"Q = {numQ}\n");
            rtbPostupakBezRabata.AppendText($"Q ≈ {numQZaokruzeno}\n\n");

            //UKUPNA VRIJEDNOST MATERIJALA POTREBNOG U JEDNOJ GODINI
            numA = numM * numR;
            rtbPostupakBezRabata.AppendText("Ukupna vrijednost materijala potrebnog u jednoj godini (A)\n");
            rtbPostupakBezRabata.AppendText($"A = M*R\n");
            rtbPostupakBezRabata.AppendText($"A = {numM}*{numR}\n");
            rtbPostupakBezRabata.AppendText($"A = {numA}\n\n");

            //GODIŠNJI TROŠKOVI NARUDŽBE
            numGTN = (numM / numQZaokruzeno) * numP;
            rtbPostupakBezRabata.AppendText("Godišnji troškovi narudžbe (GTN)\n");
            rtbPostupakBezRabata.AppendText($"GTN = (M/Q)*P\n");
            rtbPostupakBezRabata.AppendText($"GTN = ({numM}/{numQZaokruzeno})*{numP}\n");
            rtbPostupakBezRabata.AppendText($"GTN = {numGTN}\n\n");

            //IZNOS PO JEDNOJ NARUDŽBI
            numIPJN = numQZaokruzeno * numR;
            rtbPostupakBezRabata.AppendText("Iznos po jednoj narudžbi (IPJN)\n");
            rtbPostupakBezRabata.AppendText($"IPJN = Q*R\n");
            rtbPostupakBezRabata.AppendText($"IPJN = {numQZaokruzeno}*{numR}\n");
            rtbPostupakBezRabata.AppendText($"IPJN = {numIPJN}\n\n");

            //SMANJENJE ZALIHA U KONSTANTNOM OMJERU
            numSZUKO = (numQZaokruzeno * numR) / 2;
            rtbPostupakBezRabata.AppendText("Smanjenje zaliha u konstantnom omjeru (SZUKO)\n");
            rtbPostupakBezRabata.AppendText($"SZUKO = (Q*R)/2\n");
            rtbPostupakBezRabata.AppendText($"SZUKO = ({numQZaokruzeno}*{numR})/2\n");
            rtbPostupakBezRabata.AppendText($"SZUKO = {numSZUKO}\n\n");

            //GODIŠNJI TROŠKOVI SKLADIŠTENJA
            numGTS = numSZUKO * numC;
            numGTSZaokruzeno = (int)Math.Round(numGTS, 0);
            rtbPostupakBezRabata.AppendText("Godišnji troškovi skladištenja (GTS)\n");
            rtbPostupakBezRabata.AppendText($"GTS = (R*Q*C)/2\n");
            rtbPostupakBezRabata.AppendText($"GTS = ({numR}*{numQZaokruzeno}*{numC})/2\n");
            rtbPostupakBezRabata.AppendText($"GTS = {numGTS}\n");
            rtbPostupakBezRabata.AppendText($"GTS ≈ {numGTSZaokruzeno}\n\n");

            //UKUPNI GODIŠNJI TROŠKOVI MATERIJALA
            numUkupnoBezRabata = numA + numGTN + numGTSZaokruzeno;
            rtbPostupakBezRabata.AppendText("Ukupni godišnji troškovi materijala (bez rabata)\n");
            rtbPostupakBezRabata.AppendText($"A+GTN+GTS\n");
            rtbPostupakBezRabata.AppendText($"{numA}+{numGTN}+{numGTSZaokruzeno}\n");
            rtbPostupakBezRabata.SelectionStart = rtbPostupakBezRabata.Text.Length;
            rtbPostupakBezRabata.SelectionLength = numUkupnoBezRabata.ToString().Length;
            rtbPostupakBezRabata.SelectionFont = new Font(rtbPostupakBezRabata.Font, FontStyle.Bold);
            rtbPostupakBezRabata.AppendText($"{numUkupnoBezRabata}\n\n");
        }

        private void izracunajSRabatom()
        {
            //UKUPNA VRIJEDNOST MATERIJALA POTREBNOG U JEDNOJ GODINI UZ KOLIČINSKI RABAT
            numARabat = numM * numR * (1 - numRabat);
            numARabatZaokruzeno = (int)Math.Round(numARabat, 0);
            rtbPostupakSRabatom.AppendText("Ukupna vrijednost materijala potrebnog u jednoj godini uz količinski rabat (A)\n");
            rtbPostupakSRabatom.AppendText($"A = M*R*(1-Rabat)\n");
            rtbPostupakSRabatom.AppendText($"A = {numM}*{numR}*(1-{numRabat})\n");
            rtbPostupakSRabatom.AppendText($"A = {numARabat}\n");
            rtbPostupakSRabatom.AppendText($"A ≈ {numARabatZaokruzeno}\n\n");

            //GODIŠNJI TROŠAK NARUDŽBE
            numGTNRabat = (numM / numMinimalno) * numP;
            rtbPostupakSRabatom.AppendText("Godišnji trošak narudžbe (GTN)\n");
            rtbPostupakSRabatom.AppendText($"GTN = (M/Min)*P\n");
            rtbPostupakSRabatom.AppendText($"GTN = ({numM}/{numMinimalno})*{numP}\n");
            rtbPostupakSRabatom.AppendText($"GTN = {numGTNRabat}\n\n");

            //IZNOS PO JEDNOJ NARUDŽBI UZ KOLIČINSKI RABAT
            numIPJNRabat = numMinimalno * numR * (1 - numRabat);
            numIPJNRabatZaokruzeno = (int)Math.Round(numIPJNRabat, 0);
            rtbPostupakSRabatom.AppendText("Iznos po jednoj narudžbi uz količinski rabat (IPJN)\n");
            rtbPostupakSRabatom.AppendText($"IPJN = Min*R*(1-Rabat)\n");
            rtbPostupakSRabatom.AppendText($"IPJN = {numMinimalno}*{numR}*(1-{numRabat})\n");
            rtbPostupakSRabatom.AppendText($"IPJN = {numIPJNRabat}\n");
            rtbPostupakSRabatom.AppendText($"IPJN ≈ {numIPJNRabatZaokruzeno}\n\n");

            //PROSJEČNA VRIJEDNOST ZALIHA
            numPVZRabat = numIPJNRabatZaokruzeno / 2;
            rtbPostupakSRabatom.AppendText("Prosječna vrijednost zaliha (PVZ)\n");
            rtbPostupakSRabatom.AppendText($"PVZ = IPJN/2\n");
            rtbPostupakSRabatom.AppendText($"PVZ = {numIPJNRabatZaokruzeno}/2\n");
            rtbPostupakSRabatom.AppendText($"PVZ = {numPVZRabat}\n\n");

            //GODIŠNJI TROŠKOVI SKLADIŠTENJA
            numGTSRabat = numPVZRabat * numC;
            numGTSRabatZaokruzeno = (int)Math.Round(numGTSRabat, 0);
            rtbPostupakSRabatom.AppendText("Godišnji troškovi skladištenja (GTS)\n");
            rtbPostupakSRabatom.AppendText($"GTS = PVZ*C\n");
            rtbPostupakSRabatom.AppendText($"GTS = {numPVZRabat}*{numC}\n");
            rtbPostupakSRabatom.AppendText($"GTS = {numGTSRabat}\n");
            rtbPostupakSRabatom.AppendText($"GTS ≈ {numGTSRabatZaokruzeno}\n\n");

            //UKUPNI GODIŠNJI TROŠKOVI MATERIJALA
            numUkupnoSRabatom = numARabatZaokruzeno + numGTNRabat + numGTSRabatZaokruzeno;
            rtbPostupakSRabatom.AppendText("Ukupni godišnji troškovi materijala (s rabatom)\n");
            rtbPostupakSRabatom.AppendText($"A+GTN+GTS\n");

            rtbPostupakSRabatom.AppendText($"{numARabatZaokruzeno}+{numGTNRabat}+{numGTSRabatZaokruzeno}\n");

            rtbPostupakSRabatom.SelectionStart = rtbPostupakSRabatom.Text.Length;
            rtbPostupakSRabatom.SelectionLength = numUkupnoSRabatom.ToString().Length;
            rtbPostupakSRabatom.SelectionFont = new Font(rtbPostupakSRabatom.Font, FontStyle.Bold);
            rtbPostupakSRabatom.AppendText($"{numUkupnoSRabatom}\n\n");
        }

        private void nacrtajTablicu()
        {
            gbTablica = new GroupBox();
            gbTablica.Text = "Usporedba:";
            Font font = new Font("Comic Sans MS", 13.8f, FontStyle.Bold);
            gbTablica.Font = font;
            gbTablica.Location = new Point(35, 475);
            gbTablica.AutoSize = true;

            Panel panel = new Panel();
            panel.Location = new Point(20, 40);
            panel.Size = new Size(747,135);

            tablica = new DataGridView(); 
            tablica.ColumnCount = 3;
            tablica.RowCount = 5;
            tablica.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular);
  
            tablica.Columns[1].HeaderText = "IZNOS BEZ RABATA";
            tablica.Columns[2].HeaderText = "IZNOS S RABATOM";
            tablica.Rows[0].Cells[0].Value = "Optimalna količina";
            tablica.Rows[1].Cells[0].Value = "Ukupna vrijednost materijala potrebnog u jednoj godini";
            tablica.Rows[2].Cells[0].Value = "Godišnji troškovi narudžbe";
            tablica.Rows[3].Cells[0].Value = "Godišnji troškovi skladištenja";
            tablica.Rows[4].Cells[0].Value = "Ukupni godišnji troškovi materijala";

            tablica.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tablica.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tablica.Dock = DockStyle.Fill;
    
            panel.Controls.Add(tablica);
            gbTablica.Controls.Add(panel);
            this.Controls.Add(gbTablica);
        }

        private void popuniTablicu()
        {
            tablica.Rows[0].Cells[1].Value = numQZaokruzeno;
            tablica.Rows[0].Cells[2].Value = brojMinimalno.Value;
            tablica.Rows[1].Cells[1].Value = numA;
            tablica.Rows[1].Cells[2].Value = numARabatZaokruzeno;
            tablica.Rows[2].Cells[1].Value = numGTN;
            tablica.Rows[2].Cells[2].Value = numGTNRabat;
            tablica.Rows[3].Cells[1].Value = numGTSZaokruzeno;
            tablica.Rows[3].Cells[2].Value = numGTSRabatZaokruzeno;
            tablica.Rows[4].Cells[1].Value = numUkupnoBezRabata;
            tablica.Rows[4].Cells[2].Value = numUkupnoSRabatom;

            if (numUkupnoBezRabata < numUkupnoSRabatom)
            {
                tablica.Columns[1].DefaultCellStyle.BackColor = Color.LightGreen;
                tablica.Columns[2].DefaultCellStyle.BackColor = Color.LightCoral;
            }
            else
            {
                tablica.Columns[1].DefaultCellStyle.BackColor = Color.LightCoral;
                tablica.Columns[2].DefaultCellStyle.BackColor = Color.LightGreen;
            }

            tablica.Rows[4].Cells[1].Style.Font = new Font(tablica.Font, FontStyle.Bold);
            tablica.Rows[4].Cells[2].Style.Font = new Font(tablica.Font, FontStyle.Bold);
        }
    }
}
