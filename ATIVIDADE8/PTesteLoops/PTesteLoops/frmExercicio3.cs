using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteLoops
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palavra = txtPalavra.Text.ToLower().Replace(" ", string.Empty);
            string palavraInversa = new string(palavra.Reverse().ToArray());

            if (string.Compare(palavra, palavraInversa) == 0)
            {
                MessageBox.Show("A palavra é um palíndromo");
            }
            else
            { 
                MessageBox.Show("Não é palíndromo");
            }
        }

        private void txtPalavra_TextChanged(object sender, EventArgs e)
        {
            string palavra = txtPalavra.Text;

            if (palavra.Length > 50)
            {
                txtPalavra.Text = string.Empty;
                MessageBox.Show("Favor inserir até 50 caracteres");
                txtPalavra.Focus();
            }
        }
    }
}
