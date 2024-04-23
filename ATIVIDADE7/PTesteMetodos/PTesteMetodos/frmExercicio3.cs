using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmExercicio3_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtPalavra1.Text == "" || txtPalavra2.Text == "")
                MessageBox.Show("Entrada inválida, digite algo");
            else 
            {
                txtPalavra1.Text = txtPalavra1.Text.ToUpper();
                txtPalavra2.Text = txtPalavra2.Text.ToUpper();
                txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            char[] vetor = txtPalavra1.Text.ToCharArray();
            Array.Reverse(vetor); // inverte a string supra-criada.

            txtPalavra2.Text = new string(vetor);
        }
    }
}
