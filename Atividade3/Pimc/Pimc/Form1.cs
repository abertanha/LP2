using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pimc
{
    public partial class Form1 : Form
    {
        double peso, altura, IMC;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void mskAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskAltura.Text, out altura))
                MessageBox.Show("Valor Inválido");
            else
                if (altura < 0.675 || altura > 2.51)
                {
                    MessageBox.Show("Valor Inválido", "Erro" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskAltura.Focus();
                } 
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            IMC = peso / (altura * altura);
            IMC = Math.Round(IMC, 1);
            txtIMC.Text = IMC.ToString("N2");
            if (IMC < 18.5)
                txtClassificacao.Text = ("Magreza");
                else
                    if (IMC < 24.9)
                        txtClassificacao.Text = ("Normal");
                    else
                        if (IMC < 29.9)
                            txtClassificacao.Text = ("Sobrepeso");
                        else
                            if (IMC < 39.9)
                                txtClassificacao.Text = ("Obesidade");
                            else
                                txtClassificacao.Text = ("Obesidade Grave");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = string.Empty;
            txtIMC.Text = string.Empty;
            txtClassificacao.Text = string.Empty;
            mskAltura.Text = string.Empty;
        }

        private void txtPeso_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Valor Inválido");
                txtPeso.Focus();
            }
        }
    }
}
