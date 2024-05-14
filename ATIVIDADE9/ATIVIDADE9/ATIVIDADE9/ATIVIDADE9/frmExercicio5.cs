using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE9
{
    public partial class frmExercicio5 : Form
    {

        int[,] alunosRespostas = new int[60, 10];
        char[] gabarito = new char[10] { 'A', 'B', 'C', 'C', 'E', 'E', 'A', 'E', 'D', 'B' };

        public frmExercicio5()
        {
            InitializeComponent();
        }
        private void btnComparar_Click(object sender, EventArgs e)
        {
            string aux;

            for (int i = 0; i < alunosRespostas.GetLength(0); i++)
            {
                for (int j = 0; j < alunosRespostas.GetLength(1); j++)
                {
                    aux = Interaction.InputBox($"Digite a nota da questão {j + 1}", $"Aluno {i + 1}");

                    if ((aux.Length == 1) && (aux[0] >= 'A' && aux[0] <= 'E'))
                    {
                        alunosRespostas[i, j] = aux[0];
                        listBoxGabarito.Items.Add($"O aluno{i + 1}; questão {j + 1}: {aux} gabarito: {gabarito[j]} " + "\n").ToString();
                    }
                    else
                    {
                        MessageBox.Show("Entrada inválida");
                        j--;
                    }

                }
            }
        }
    }
}