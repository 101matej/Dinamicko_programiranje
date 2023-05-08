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

        private void btnModelZaliha_Click(object sender, EventArgs e)
        {
            Form ModeliZaliha = new FormModeliZaliha();
            ModeliZaliha.ShowDialog();
        }
    }
}
