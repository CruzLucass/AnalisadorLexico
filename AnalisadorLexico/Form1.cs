using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisadorLexico
{
    public partial class Form1 : Form
    {
        Scanner scanner = new Scanner();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {          
            txtSaida.Text = scanner.Entrada(txtEntrada.Text);
            grdTblSimbolos.DataSource = scanner.identificadorList;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEntrada.Text = "";
            txtSaida.Text = "";
            grdTblSimbolos.DataSource = null;
        }

        private void btnSelecionaArq_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                var textFile = new StreamReader(openFileDialog1.FileName);
                txtEntrada.Text = textFile.ReadToEnd();
            }
        }
    }
}
