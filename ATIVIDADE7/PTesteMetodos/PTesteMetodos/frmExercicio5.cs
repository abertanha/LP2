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
    public partial class frmExercicio5 : Form
    {
        int num1, num2;

        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void txtNum2_Validated(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Número inválido");
                txtNum2.Focus();
            }
            if (num2 < num1)
            {
                MessageBox.Show("Segundo valor precisa ser maior que o primeiro");
                txtNum2.Focus();
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            System.Random numRnd = new System.Random();
            double num = numRnd.Next(num1, num2);
            MessageBox.Show(num.ToString());

        }

        private void txtNum1_Validated(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Número inválido");
                txtNum1.Focus();
            }
        }
    }
}
