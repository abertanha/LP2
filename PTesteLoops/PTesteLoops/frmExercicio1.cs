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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }


        private void btnFor_Click(object sender, EventArgs e)
        {
            
            int length = rchtxtFrase.Text.Length, contWS = 0, contR = 0, contP = 0;
            char[] vetor = rchtxtFrase.Text.ToCharArray();

            for (int i = 0; i < length; i++)
            {
                if (char.IsWhiteSpace(vetor[i]))
                    contWS++;
                if (vetor[i] == 'R' || vetor[i] == 'r')
                    contR++;
                for (int j = i + 1; j < length; j++)
                    if (vetor[i] == vetor[j])
                    {
                        contP++;
                    }
                    else
                        break;
            }
            MessageBox.Show("Há " + contWS.ToString() + " espaços em branco");
            MessageBox.Show("Há " + contR.ToString() + " letras R's");
            MessageBox.Show("Há " + contP.ToString() + " pares");
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int length = rchtxtFrase.Text.Length, contWS = 0, contR = 0, contP = 0, i = 0, j;
            char[] vetor = rchtxtFrase.Text.ToCharArray();

            while (i < length)
            {
                if (char.IsWhiteSpace(vetor[i]))
                    contWS++;
                if (vetor[i] == 'R' || vetor[i] == 'r')
                    contR++;
                j = i + 1;
                while (j < length)
                {
                    if (vetor[i] == vetor[j])
                        contP++;
                    else
                        break;
                    j++;
                }
                i++;
            }
            MessageBox.Show("Há " + contWS.ToString() + " espaços em branco");
            MessageBox.Show("Há " + contR.ToString() + " letras R's");
            MessageBox.Show("Há " + contP.ToString() + " pares");
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            int length = rchtxtFrase.Text.Length, contWS = 0, contR = 0, contP = 0, i = 0, j = i + 1;
            char[] vetor = rchtxtFrase.Text.ToCharArray();

            if (vetor.Length > 0)
            {
                do
                {
                    if (char.IsWhiteSpace(vetor[i]))
                        contWS++;
                    if (vetor[i] == 'R' || vetor[i] == 'r')
                        contR++;
                    j = i + 1;
                    while (j < length)
                    {
                        if (vetor[i] == vetor[j])
                            contP++;
                        else
                            break;
                        j++;
                    }
                    i++;

                } while (i < length);
                MessageBox.Show("Há " + contWS.ToString() + " espaços em branco");
                MessageBox.Show("Há " + contR.ToString() + " letras R's");
                MessageBox.Show("Há " + contP.ToString() + " pares");
            }
            else
            {
                MessageBox.Show("Texto inválido");
                rchtxtFrase.Focus();
            }
        }
    }
}
