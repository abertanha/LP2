using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void btnInstanciarHorista_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioPHora.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasdeFalta.Text);
            objHorista.NumeroHora = Convert.ToInt32(txtNumHoras.Text);

            MessageBox.Show("Nome=" + objHorista.NomeEmpregado + "\n" + "Matrícula=" + objHorista.Matricula + "\n" +
                            "Tempo Trabalho:" + objHorista.TempoTrabalho().ToString() + "\n" + "Salário Final="
                            + objHorista.SalarioBruto().ToString("N2"));
        }
    }
}
