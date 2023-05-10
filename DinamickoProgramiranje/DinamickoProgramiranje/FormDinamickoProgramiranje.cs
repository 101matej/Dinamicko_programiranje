using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DinamickoProgramiranje
{
    public partial class FormDinamickoProgramiranje : Form
    {
        int potraznjaPrvogRazdoblja = 0;
        int vrijednostOdPrvogRazdoblja;
        int vrijednostDoPrvogRazdoblja;
        int vrijednostOdSljedecegRazdoblja;
        int vrijednostDoSljedecegRazdoblja;
        public FormDinamickoProgramiranje()
        {
            InitializeComponent();
        }

        private void tbBrojRazdoblja_TextChanged(object sender, EventArgs e)
        {
            panelKontejner.Controls.Clear();

            int brojRazdoblja;

            if (int.TryParse(tbBrojRazdoblja.Text, out brojRazdoblja))
            {
                for (int i = 0; i < brojRazdoblja; i++)
                {
                    Label label = new Label();
                    label.Text = "Razdoblje " + (i + 1).ToString();
                    label.Location = new Point(0, 5 + i * 40);
                    label.Size = new Size(100, 22);
                    panelKontejner.Controls.Add(label);

                    TextBox textBox = new TextBox();
                    textBox.Name = "tbRazdoblje" + i;
                    textBox.Location = new Point(100, 0 + i * 40);
                    textBox.Size = new Size(89, 22);
                    panelKontejner.Controls.Add(textBox);
                }
            }
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            if (!provjeraIspravnostiUnesenihPodataka())
            {
                dgvTablica1.Columns.Clear();
                dgvTablica1.Rows.Clear();
                return;
            }

            postaviBrojStupaca();
            postaviBrojRedaka();

            izracunajQZaPrvoRazdoblje(out vrijednostOdPrvogRazdoblja, out vrijednostDoPrvogRazdoblja);
            popunjavanjeQZaPrvoRazdoblje();
            izracunajIPopunifZaPrvoRazdoblje();

            izracunajIPopuniQifZaOstalaRazdoblja();
        }

        private bool provjeraIspravnostiUnesenihPodataka()
        {
            bool ispravno = true;
            if (tbIznosRata.Text == "" || tbMaksimalnaKolicinaZaliha.Text == "" || tbMaksimalnaKolicinaNarucivanja.Text == ""
                || tbTroskoviSkladistenja.Text == "" || tbTroskoviPoNarudzbi.Text == "" || tbBrojRazdoblja.Text == "")
            {
                MessageBox.Show("Morate ispuniti sve tražene podatke vezane uz zadatak!");
                ispravno = false;
            }
            return ispravno;
        }

        private void postaviBrojStupaca()
        {
            dgvTablica1.Columns.Clear();

            int brojRazdoblja;

            if (int.TryParse(tbBrojRazdoblja.Text, out brojRazdoblja))
            {
                int brojStupaca = brojRazdoblja * 2 + 1;

                for (int i = 0; i < brojStupaca; i++)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();

                    if (i == 0)
                    {
                        column.HeaderText = "I";
                    }
                    else if (i % 2 == 1)
                    {
                        int broj = i / 2 + 1;
                        column.HeaderText = "Q (" + broj + ")";
                    }
                    else
                    {
                        int broj = (i + 1) / 2;
                        column.HeaderText = "f (" + broj + ")";
                    }

                    dgvTablica1.Columns.Add(column);
                }
            }
        }

        private void postaviBrojRedaka()
        {
            dgvTablica1.Rows.Clear();

            int maksimalnaKolicinaZaliha = int.Parse(tbMaksimalnaKolicinaZaliha.Text);
            int iznosRata = int.Parse(tbIznosRata.Text);
            int brojRedaka = 0;

            for (int j = 0; j <= maksimalnaKolicinaZaliha; j = j + iznosRata)
            {
                dgvTablica1.Rows.Add();

                dgvTablica1.Rows[brojRedaka].Cells[0].Value = j;

                brojRedaka++;
            }
        }

        private void izracunajQZaPrvoRazdoblje(out int vrijednostOdPrvogRazdoblja, out int vrijednostDoPrvogRazdoblja)
        {
            int maksimalnaKolicinaZaliha = int.Parse(tbMaksimalnaKolicinaZaliha.Text);

            TextBox prvoRazdoblje = (TextBox)panelKontejner.Controls["tbRazdoblje0"];
            potraznjaPrvogRazdoblja = int.Parse(prvoRazdoblje.Text);

            vrijednostOdPrvogRazdoblja = maksimalnaKolicinaZaliha + potraznjaPrvogRazdoblja - maksimalnaKolicinaZaliha;
            vrijednostDoPrvogRazdoblja = maksimalnaKolicinaZaliha + potraznjaPrvogRazdoblja;
        }

        private void popunjavanjeQZaPrvoRazdoblje()
        {
            int iznosRata = int.Parse(tbIznosRata.Text);
            int brojRedaka = 0;

            for (int i = vrijednostOdPrvogRazdoblja; i <= vrijednostDoPrvogRazdoblja; i = i + iznosRata)
            {
                dgvTablica1.Rows[brojRedaka].Cells[1].Value = i;

                brojRedaka++;
            }
        }

        private void izracunajIPopunifZaPrvoRazdoblje()
        {
            int troskoviPoNarudzbi = int.Parse(tbTroskoviPoNarudzbi.Text);
            int troskoviSkladistenja = int.Parse(tbTroskoviSkladistenja.Text);
            int maksimalnaKolicinaZaliha = int.Parse(tbMaksimalnaKolicinaZaliha.Text);
            int iznosRata = int.Parse(tbIznosRata.Text);
            int brojRedaka = 0;

            for (int i = 0; i <= maksimalnaKolicinaZaliha; i = i + iznosRata)
            {
                dgvTablica1.Rows[brojRedaka].Cells[2].Value = troskoviPoNarudzbi + i * troskoviSkladistenja;

                brojRedaka++;
            }
        }

        private void izracunajIPopuniQifZaOstalaRazdoblja()
        {
            int iznosRata = int.Parse(tbIznosRata.Text);
            int maksimalnaKolicinaZaliha = int.Parse(tbMaksimalnaKolicinaZaliha.Text);
            int troskoviSkladistenja = int.Parse(tbTroskoviSkladistenja.Text);
            int troskoviPoNarudzbi = int.Parse(tbTroskoviPoNarudzbi.Text);
            int brojRazdoblja = int.Parse(tbBrojRazdoblja.Text);
            int sljedeceRazdoblje;
            int potraznjaSljedecegRazdoblja;
            int brojRedaka = 0;

            for (sljedeceRazdoblje = 1; sljedeceRazdoblje < brojRazdoblja; sljedeceRazdoblje++)
            {
                string imeTekstualnogOkvira = "tbRazdoblje" + sljedeceRazdoblje;
                TextBox sljedeceRazdobljeTextBox = panelKontejner.Controls.Find(imeTekstualnogOkvira, true).FirstOrDefault() as TextBox;

                if (sljedeceRazdobljeTextBox != null)
                {
                    potraznjaSljedecegRazdoblja = int.Parse(sljedeceRazdobljeTextBox.Text);

                    for (int i = 0; i <= maksimalnaKolicinaZaliha; i = i + iznosRata)
                    {
                        List<int> listaRezultata = new List<int>();
                        List<int> listaNabave = new List<int>();
                        vrijednostOdSljedecegRazdoblja = i + potraznjaSljedecegRazdoblja - maksimalnaKolicinaZaliha;
                        if (vrijednostOdSljedecegRazdoblja < 0)
                        {
                            vrijednostOdSljedecegRazdoblja = 0;
                        }
                        vrijednostDoSljedecegRazdoblja = i + potraznjaSljedecegRazdoblja;

                        for (int j = vrijednostOdSljedecegRazdoblja; j <= vrijednostDoSljedecegRazdoblja; j = j + iznosRata)
                        {
                            int nabava = j;
                            listaNabave.Add(nabava);
                            int zalihe = i;
                            int uglataZagrada = zalihe + potraznjaSljedecegRazdoblja - nabava;
                            int cijenaNabave = 0;
                            if (nabava > 0)
                            {
                                cijenaNabave = troskoviPoNarudzbi;
                            }
                            int cijenaSkladistenja = zalihe * troskoviSkladistenja;
                            string trazenaVrijednost = uglataZagrada.ToString();

                            foreach (DataGridViewRow row in dgvTablica1.Rows)
                            {
                                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == trazenaVrijednost)
                                {
                                    if (row.Cells[sljedeceRazdoblje * 2].Value != null)
                                    {
                                        string trazenaVrijednostfPrethodnogRazdoblja = row.Cells[sljedeceRazdoblje * 2].Value.ToString();
                                        int trazenaVrijednostfPrethodnogRazdobljaInteger = int.Parse(trazenaVrijednostfPrethodnogRazdoblja);
                                        int rezultat = cijenaNabave + cijenaSkladistenja + trazenaVrijednostfPrethodnogRazdobljaInteger;
                                        listaRezultata.Add(rezultat);
                                    }
                                    break;
                                }
                            }
                        }
                        int f = listaRezultata.Min();
                        int pozicija = listaRezultata.IndexOf(f);
                        int nabavaQ = listaNabave[pozicija];

                        dgvTablica1.Rows[brojRedaka].Cells[sljedeceRazdoblje * 2 + 2].Value = f;
                        dgvTablica1.Rows[brojRedaka].Cells[sljedeceRazdoblje * 2 + 1].Value = nabavaQ;
                        brojRedaka++;
                    }
                    brojRedaka = 0;
                }
                else
                {
                    return;
                }
            }
        }

        private void btnAnaliza_Click(object sender, EventArgs e)
        {
            if (!provjeraIspravnostiUnesenihPodataka())
            {
                dgvTablica2.Columns.Clear();
                dgvTablica2.Rows.Clear();
                return;
            }

            postaviBrojStupacaTablicaAnalize();
            postaviBrojRedakaTablicaAnalize();
            postaviNuleUTablicu();

            izracunajOstaleVrijednosti();
        }

        private void postaviBrojStupacaTablicaAnalize()
        {
            dgvTablica2.Columns.Clear();

            int brojStupaca = 7;

            for (int i = 1; i <= brojStupaca; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();

                switch (i)
                {
                    case 1:
                        column.HeaderText = "Razdoblje (i)";
                        break;
                    case 2:
                        column.HeaderText = "Zalihe I(i-1)";
                        break;
                    case 3:
                        column.HeaderText = "Nabava Q(i)";
                        break;
                    case 4:
                        column.HeaderText = "Potražnja D(i)";
                        break;
                    case 5:
                        column.HeaderText = "Zalihe I(i)";
                        break;
                    case 6:
                        column.HeaderText = "Trošak nabave Cp(i)";
                        break;
                    case 7:
                        column.HeaderText = "Trošak zaliha Ch(i)";
                        break;
                }

                dgvTablica2.Columns.Add(column);
            }
        }

        private void postaviBrojRedakaTablicaAnalize()
        {
            dgvTablica2.Rows.Clear();

            int brojRedaka = int.Parse(tbBrojRazdoblja.Text) + 2;
            int potraznjaSljedecegRazdoblja;

            for (int i = 0; i < brojRedaka; i++)
            {
                dgvTablica2.Rows.Add();

                if (brojRedaka - 2 > i)
                {
                    dgvTablica2.Rows[i].Cells[0].Value = i + 1;
                }

                string imeTekstualnogOkvira = "tbRazdoblje" + i;
                TextBox sljedeceRazdobljeTextBox = panelKontejner.Controls.Find(imeTekstualnogOkvira, true).FirstOrDefault() as TextBox;

                if (sljedeceRazdobljeTextBox != null)
                {
                    potraznjaSljedecegRazdoblja = int.Parse(sljedeceRazdobljeTextBox.Text);
                    dgvTablica2.Rows[i].Cells[3].Value = potraznjaSljedecegRazdoblja;
                }
            }
        }

        private void postaviNuleUTablicu()
        {
            int brojRazdoblja = int.Parse(tbBrojRazdoblja.Text);

            dgvTablica2.Rows[0].Cells[1].Value = 0;
            dgvTablica2.Rows[brojRazdoblja - 1].Cells[4].Value = 0;
            dgvTablica2.Rows[brojRazdoblja].Cells[4].Value = "SUMA STUPACA";
            dgvTablica2.Rows[brojRazdoblja + 1].Cells[5].Value = "UKUPNO";

            dgvTablica2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTablica2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTablica2.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void izracunajOstaleVrijednosti()
        {
            int brojRazdoblja = int.Parse(tbBrojRazdoblja.Text);
            int troskoviPoNarudzbi = int.Parse(tbTroskoviPoNarudzbi.Text);
            int troskoviSkladistenja = int.Parse(tbTroskoviSkladistenja.Text);
            int trazenaVrijednostQInteger = 0;
            int sumaCp = 0;
            int sumaCh = 0;
            int ukupno = 0;

            for (int i = brojRazdoblja - 1; i >= 0; i--)
            {
                int trazeneZalihe = Convert.ToInt32(dgvTablica2.Rows[i].Cells[4].Value);
                string trazenaVrijednost = trazeneZalihe.ToString();

                foreach (DataGridViewRow row in dgvTablica1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == trazenaVrijednost)
                    {
                        if (row.Cells[i * 2 + 1].Value != null)
                        {
                            string trazenaVrijednostQ = row.Cells[i * 2 + 1].Value.ToString();
                            trazenaVrijednostQInteger = int.Parse(trazenaVrijednostQ);
                        }
                        break;
                    }
                }

                dgvTablica2.Rows[i].Cells[2].Value = trazenaVrijednostQInteger;
                int I = Convert.ToInt32(dgvTablica2.Rows[i].Cells[4].Value);
                int D = Convert.ToInt32(dgvTablica2.Rows[i].Cells[3].Value);
                int Q = Convert.ToInt32(dgvTablica2.Rows[i].Cells[2].Value);
                dgvTablica2.Rows[i].Cells[1].Value = I + D - Q;
                if(i - 1 >= 0)
                {
                    dgvTablica2.Rows[i - 1].Cells[4].Value = I + D - Q;
                }

                if(Convert.ToInt32(dgvTablica2.Rows[i].Cells[2].Value) > 0)
                {
                    dgvTablica2.Rows[i].Cells[5].Value = troskoviPoNarudzbi;
                }
                else
                {
                    dgvTablica2.Rows[i].Cells[5].Value = 0;
                }

                dgvTablica2.Rows[i].Cells[6].Value = Convert.ToInt32(dgvTablica2.Rows[i].Cells[4].Value) * troskoviSkladistenja;
            }

            for (int i = brojRazdoblja - 1; i >= 0; i--)
            {
                sumaCp += Convert.ToInt32(dgvTablica2.Rows[i].Cells[5].Value);
                sumaCh += Convert.ToInt32(dgvTablica2.Rows[i].Cells[6].Value);
            }

            dgvTablica2.Rows[brojRazdoblja].Cells[5].Value = sumaCp;
            dgvTablica2.Rows[brojRazdoblja].Cells[6].Value = sumaCh;
            ukupno = sumaCp + sumaCh;
            dgvTablica2.Rows[brojRazdoblja + 1].Cells[6].Value = ukupno;

            dgvTablica2.Rows[brojRazdoblja + 1].Cells[5].Style.Font = new Font(dgvTablica2.Font, FontStyle.Bold);
            dgvTablica2.Rows[brojRazdoblja].Cells[4].Style.Font = new Font(dgvTablica2.Font, FontStyle.Bold);

            dgvTablica2.Rows[brojRazdoblja + 1].Cells[5].Style.BackColor = Color.LightGreen;
            dgvTablica2.Rows[brojRazdoblja + 1].Cells[6].Style.BackColor = Color.LightGreen;
            
            dgvTablica2.Rows[brojRazdoblja].Cells[4].Style.BackColor = Color.LightCoral;
            dgvTablica2.Rows[brojRazdoblja].Cells[5].Style.BackColor = Color.LightCoral;
            dgvTablica2.Rows[brojRazdoblja].Cells[6].Style.BackColor = Color.LightCoral;

            rtbRjesenje.AppendText("Cijena optimalne količine naručivanja i skladištenja iznosi: " + ukupno + ".");
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
