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

    public partial class frmExercicio2 : Form
    {
        int NumeroN;
       
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumN_Validated(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumN.Text, out NumeroN))
            {
                MessageBox.Show("Número inválido");
                txtNumN.Focus();
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            double NumeroH = 1;
            double j = 2;

            if (NumeroN > 0)
            {
                if (NumeroN == 1)
                {
                    txtNumH.Text = NumeroH.ToString("N2");
                }
                else
                {
                    for (int i = 0; i < NumeroN - 1; i++)
                        NumeroH += 1 / (j + i);

                    txtNumH.Text = NumeroH.ToString("N2");
                }            
            }
            else
            {
                MessageBox.Show("Número inválido");
                txtNumN.Focus();
            }
        }
    }
}
