using Microsoft.VisualBasic;
using System;
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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[6];
            string aux;
            int i = 1,length;
            
            foreach (string s in nomes)
            {
                aux = Interaction.InputBox($"Insira o nome: {i}", "Entrada de nomes");
                i++;
                length = aux.Replace(" ",string.Empty).Length;
                lstbResultado.Text = ($"O nome: {aux} tem {length} caracteres" + "\n").ToString();
            }
        }
    }
}
