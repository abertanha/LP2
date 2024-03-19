using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalc
{
    public partial class FormCalc : Form
    {
        double numero1, numero2, resultado;   
        public FormCalc()
        {
            InitializeComponent();
        }

        private void txtNum1_Validated(object sender, EventArgs e)
        {

            if(!double.TryParse(txtNum1.Text, out numero1))
                MessageBox.Show("Número inválido");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = string.Empty;
            txtNum2.Text = string.Empty;
            txtResultado.Text = string.Empty;
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            resultado = numero1 - numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            resultado = numero1 * numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if(numero2 != 0)
            {
                resultado = numero1 / numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Divisão por Zero, por favor insira um divisor válido");
                txtNum2.Focus();
            }

            
        }

        private void txtNum2_Validated(object sender, EventArgs e)
        {

            if (!double.TryParse(txtNum2.Text, out numero2))
                MessageBox.Show("Número inválido");
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            resultado = numero1 + numero2;
            txtResultado.Text = resultado.ToString();
        }
    }
}
