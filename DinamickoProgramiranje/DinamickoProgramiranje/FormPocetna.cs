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
    public partial class FormPocetna : Form
    {
        public FormPocetna()
        {
            InitializeComponent();
        }


        private void btnDinamickoProgramiranje_Click(object sender, EventArgs e)
        {
            FormDinamickoProgramiranje formDInamickoProgramiranje = new FormDinamickoProgramiranje();
            this.Hide();
            formDInamickoProgramiranje.ShowDialog();
            this.Show();
        }
        
        private void btnModelZaliha_Click(object sender, EventArgs e)
        {
            Form FormModeliZaliha = new FormModeliZaliha();
            this.Hide();
            FormModeliZaliha.ShowDialog();
            this.Show();
        }
    }
}
