using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double vlrRaio, vlrAltura;
            if ((!double.TryParse(txtRaio.Text, out vlrRaio)) || (!double.TryParse(txtAltura.Text, out vlrAltura)))
            {
                MessageBox.Show("Valores Inválidos");
                txtRaio.Focus();
            }
            else
                if (vlrAltura <= 0 || vlrRaio <= 0)
            {
                MessageBox.Show("Valores devem ser maiores que zero!");
                txtRaio.Focus(); 
            }
            else 
            {
                double volume;

                volume = Math.PI * Math.Pow(vlrRaio, 2) * vlrAltura; //volume = 3.1415 * vlrRaio * vlrRaio *vlrAltura;
                txtVolume.Text = volume.ToString("N2");
            }
        }
        private void txtRaio_Validated(object sender, EventArgs e)
        {
            double vlrRaio;

            if (!double.TryParse(txtRaio.Text, out vlrRaio))
                MessageBox.Show("Raio Inválido");
            else
                if (vlrRaio <= 0)
                MessageBox.Show("Raio Inválido");

        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            double vlrAltura;

            if (!double.TryParse(txtRaio.Text, out vlrAltura))
                MessageBox.Show("Altura Inválida");
            else
                if (vlrAltura <= 0)
                MessageBox.Show("Altura Inválida");
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
