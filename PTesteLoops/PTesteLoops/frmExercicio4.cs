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
    public partial class frmExercicio4 : Form
    {
        int prod;
        double B = 0, C = 0, D = 0, salBrut, sal, grat;
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private TextBox GetTxtSalBrut()
        {
            return txtSalBrut;
        }

        private void textProd_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textProd.Text, out prod))
                MessageBox.Show("Valor inválido");
        }

        private void txtGrat_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtGrat.Text, out grat))
                MessageBox.Show("Valor inválido");
        }

        private void txtSal_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSal.Text, out sal))
                MessageBox.Show("Valor inválido");
        }

        private void btnSalBrut_Click(object sender, EventArgs e)
        {
            if (prod >= 150)
                D = 1;
            if (prod >= 120)
                C = 1;
            if (prod >= 100)
                B = 1;

            salBrut = sal + (sal * (0.05 * B + 0.1 * C + 0.1 * D)) + grat;

            if(salBrut >= 7000)
                salBrut = 7000 + grat;

            txtSalBrut.Text = salBrut.ToString("N2");   
        }
    }
}
