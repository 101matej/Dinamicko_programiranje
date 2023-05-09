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

            izracunajiPopunifZaPrvoRazdoblje();
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
                        column.Name = "QStupac" + broj;
                    }
                    else
                    {
                        int broj = (i + 1) / 2;
                        column.HeaderText = "f (" + broj + ")";
                        column.Name = "fStupac" + broj;
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

        private void izracunajiPopunifZaPrvoRazdoblje()
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

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
