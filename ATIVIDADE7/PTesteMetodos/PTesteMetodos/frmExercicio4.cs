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
            int length = rtbTexto.Text.Length, cont = 0;
            char[] vetor =  rtbTexto.Text.ToCharArray();

            while (length > 0) 
            {
                if (char.IsNumber(vetor[length]))
                    cont++;

                length--;
            }
        }
    }
}
