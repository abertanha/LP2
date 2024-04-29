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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            int length = rtbTexto.Text.Length, cont = 0, i = 0,cont2 = 0;
            char[] vetor =  rtbTexto.Text.ToCharArray();

            while (i < length) 
            {
                if (char.IsNumber(vetor[i]))
                    cont++;
                if (char.IsLetter(vetor[i]))
                    cont2++;
                i++;
            }
            MessageBox.Show("Temos" + " " + cont.ToString() + " " + "numeros");
        }

        private void rtbTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlfa_Click(object sender, EventArgs e)
        {
            int length = rtbTexto.Text.Length, cont = 0, i = 0;
            char[] vetor = rtbTexto.Text.ToCharArray();

            while (i < length)
            {
                if (char.IsLetter(vetor[i]))
                    cont++;
                i++;
            }
            MessageBox.Show("Temos" + " " + cont.ToString() + " " + "letras");
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int length = rtbTexto.Text.Length, cont;
            char[] vetor = rtbTexto.Text.ToCharArray();

            for (int i = 0; i < length; i++)
                if (char.IsWhiteSpace(vetor[i]))
                {
                    cont = i + 1;
                    MessageBox.Show("O caracter espaço branco se encontra na " + " " + cont.ToString() + "° " + "posição");
                }
            cont = 0;
        }
    }
}
