using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario2
{
    public partial class Form1 : Form
    {
        double salBrut, salLiq, descINSS, descIRPF, salFamilia, numFilhos;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            /*txtAliqINSS = string.Empty;
            txtAliqIRPF = string.Empty;
            txtDescINSS = string.Empty;
            txtDescIRPF = string.Empty;
            txtFuncionario = string.Empty;
            txtSalFamilia = string.Empty;
            txtSalLiquido = string.Empty;*/
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskSalBruto_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskSalBruto.Text, out salBrut))
            {
                MessageBox.Show("Valor Inválido");
                mskSalBruto.Focus();
            }
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            numFilhos = Convert.ToDouble(numpFilhos.Value);

            if (salBrut <= 800.47)
            {
                mskAliqINSS.Text = "07.65%";
                descINSS = 0.0765 * salBrut;
            }
            else
                if (salBrut <= 1050.01)
            {
                mskAliqINSS.Text = "08.65%";
                descINSS = 0.0865 * salBrut;
            }
            else
                    if (salBrut <= 1400.77)
            {
                mskAliqINSS.Text = "09.00%";
                descINSS = 0.09 * salBrut;
            }
            else
                        if (salBrut <= 2801.65)
            {
                mskAliqINSS.Text = "10.00%";
                descINSS = 0.1 * salBrut;
            }
            else
                            if (salBrut > 2801.65)
            {
                mskAliqINSS.Text = "10.00%";
                descINSS = 308.17;
            }

            if (descINSS > 308.17)
                descINSS = 308.17;
            txtDescINSS.Text = descINSS.ToString("N2");

            if (salBrut <= 435.52)
                salFamilia = numFilhos * 22.33;
            else
                if (salBrut <= 654.61)
                salFamilia = numFilhos * 15.74;
            else
                salFamilia = 0;
            txtSalFamilia.Text = salFamilia.ToString("N2");

            if (salBrut <= 1257.12)
            {
                mskAliqIRPF.Text = "Isento";
                descIRPF = 0;
            }
            else
                if (salBrut <= 2512.08)
            {
                mskAliqIRPF.Text = "15.00%";
                descIRPF = 0.15 * salBrut;
            }
            else
                    if (salBrut <= 2512.08)
            {
                mskAliqIRPF.Text = "Teto";
                descIRPF = 0.275 * salBrut;
            }
            txtDescIRPF.Text = descIRPF.ToString("N2");
            salLiq = salBrut - descINSS - descIRPF + salFamilia;
            txtSalLiquido.Text = salLiq.ToString("N2");
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void txtFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) || Char.IsPunctuation(e.KeyChar)))
            {
                MessageBox.Show("caracter inválido");
                SendKeys.Send("{BACKSPACE}");
            }
        }
    }
}
