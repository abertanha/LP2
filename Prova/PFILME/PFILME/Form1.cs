using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PFILME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            double soma1 = 0, soma2 = 0;
            double[,] matriz = new double[12, 2];
            string aux;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    aux = Interaction.InputBox($"Digita a nota do filme: {j + 1}", $"Pessoa {i + 1}");

                    if (!double.TryParse(aux, out matriz[i, j]))
                    {
                        MessageBox.Show("Entrada inválida");
                        j--;
                    }
                    else
                        if (!(matriz[i, j] >= 0 && matriz[i, j] <= 10))
                    {
                        MessageBox.Show("Entrada inválida");
                        j--;
                    }
                    else
                    {
                        if (j % 2 == 0)
                            soma1 += matriz[i, j];
                        else
                            soma2 += matriz[i, j];

                        lbOpiniao.Items.Add($"Pessoa {i + 1}: Nota Filme: {j + 1} ; {matriz[i, j]}").ToString("N2");
                    }
                }
            }
            lbOpiniao.Items.Add("----------------------------------------------------------------");
            lbOpiniao.Items.Add($"Media Filme 1: {(soma1 / 12).ToString("N2")}\n");
            lbOpiniao.Items.Add($"Media Filme 2: {(soma2 / 12).ToString("N2")}");
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbOpiniao.Items.Clear();
        }
    }
}
