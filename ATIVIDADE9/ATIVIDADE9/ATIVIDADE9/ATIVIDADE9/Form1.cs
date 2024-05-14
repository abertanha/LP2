using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string aux;

            for (int i = 0; i < vetor.Length; i++)
            {
                aux = Interaction.InputBox($"Digite um número {i + 1}", "Entrada de dados");
                if (!int.TryParse(aux, out vetor[i]))
                {
                    MessageBox.Show("Entrada inválida");
                    i--;
                }
            }
            Array.Reverse(vetor);
            aux = "";
            
            foreach (int i in vetor)
                aux += i + "\n";

            MessageBox.Show(aux);
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList();

            alunos.Add("Ana");
            alunos.Add("André");
            alunos.Add("Débora");
            alunos.Add("Fátima");
            alunos.Add("João");
            alunos.Add("Janete");
            alunos.Add("Otávio");
            alunos.Add("Marcelo");
            alunos.Add("Pedro");
            alunos.Add("Thais");

            alunos.Remove("Otávio");
            string aux = "";
            foreach (string s in alunos)
                aux += s + "\n";

            MessageBox.Show(aux);
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double soma = 0;
            double[,] matriz = new double[20, 3];
            string aux;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    aux = Interaction.InputBox($"Para o aluno: {i + 1}, digite a nota:  {j + 1}", "Entrada de dados");

                    if (!double.TryParse(aux, out matriz[i, j]))
                    {
                        MessageBox.Show("Entrada inválida");
                        j--;
                    }
                    else
                        if(!(matriz[i, j] >= 0 && matriz[i, j] <= 10))
                        {
                            MessageBox.Show("Entrada inválida");
                            j--;
                        }
                    else
                        soma += matriz[i, j];
                }
                MessageBox.Show($"Aluno {i + 1}:média: {(soma/3).ToString("N2")}");
                soma = 0;
            }
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                Application.OpenForms["frmExercicio4"]?.BringToFront();
            }
            else
            {
                frmExercicio4 objFrm4 = new frmExercicio4();
                objFrm4.MdiParent = this;
                objFrm4.WindowState = FormWindowState.Maximized;
                objFrm4.Show();
            }
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio5>().Count() > 0)
            {
                Application.OpenForms["frmExercicio5"]?.BringToFront();
            }
            else
            {
                frmExercicio5 objFrm4 = new frmExercicio5();
                objFrm4.MdiParent = this;
                objFrm4.WindowState = FormWindowState.Maximized;
                objFrm4.Show();
            }
        }
    }
}
