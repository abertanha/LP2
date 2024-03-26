using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptriangulo
{
    public partial class Form1 : Form
    {
        double ladoA, ladoB, ladoC;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCategoria.Text = String.Empty;
            txtDimensaoA.Text = String.Empty;
            txtDimensaoB.Text = String.Empty;
            txtDimensaoC.Text = String.Empty;
        }

        private void txtDimensaoB_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtDimensaoB.Text, out ladoB) || ladoB == 0)
            {
                MessageBox.Show("Valor Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDimensaoB.Focus();
            }
        }

        private void txtDimensaoC_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtDimensaoC.Text, out ladoC) || ladoC == 0)
            {
                MessageBox.Show("Valor Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDimensaoC.Focus();
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if ((ladoA + ladoB > ladoC) && (ladoA + ladoC > ladoB) && (ladoB + ladoC > ladoA))
            {
                MessageBox.Show("Valores válidos, é um triângulo!");
                if ((ladoA.Equals(ladoB)) && (ladoB.Equals(ladoC)))
                    txtCategoria.Text = ("Equilátero");
                else 
                {
                    if ((ladoA.Equals(ladoB)) || (ladoB.Equals(ladoC)) || (ladoC.Equals(ladoA)))
                        txtCategoria.Text = ("Isósceles");
                    else
                        txtCategoria.Text = ("Escaleno");
                }
            }
            else 
            {
                MessageBox.Show("Valores Inválidos, não é um trîângulo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    private void txtDimensaoA_Validated(object sender, EventArgs e)
    {
            if (!Double.TryParse(txtDimensaoA.Text, out ladoA) || ladoA == 0)
            {
                MessageBox.Show("Valor Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDimensaoA.Focus();
            }    
    }
}
}
