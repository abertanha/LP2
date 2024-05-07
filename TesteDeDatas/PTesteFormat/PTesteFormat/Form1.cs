using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToString_Click(object sender, EventArgs e)
        {
            DateTime dataExemplo = DateTime.Now;
            MessageBox.Show(dataExemplo.ToString(""));
            MessageBox.Show(dataExemplo.ToString("d"));
            MessageBox.Show(dataExemplo.ToString("D"));
            MessageBox.Show(dataExemplo.ToString("dd/MM/yyyy"));
        }

        private void btnMetDT_Click(object sender, EventArgs e)
        {
            DateTime dataExemplo = DateTime.Now;
            MessageBox.Show("ToShortDateString: " + dataExemplo.ToShortDateString());
            MessageBox.Show("ToShortTimeString: " + dataExemplo.ToShortTimeString());
            MessageBox.Show("ToLongDateString : " + dataExemplo.ToLongDateString());
            MessageBox.Show("ToLongTimeString : " + dataExemplo.ToLongTimeString());
        }

        private void btnStrFrmt_Click(object sender, EventArgs e)
        {
            string dataHoje = String.Format("Hoje é {0:d} às {0:t}", DateTime.Now);
            MessageBox.Show(dataHoje);
            DateTime data1 = Convert.ToDateTime("01/01/2024");
            DateTime data2 = Convert.ToDateTime("06/05/2024");
            string datas = String.Format("Primeira Data é {0:d} e segunda Data é {1:d}", data1, data2);
            MessageBox.Show(datas);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double valor = 1255.686;

            MessageBox.Show("Moeda 3 casas decimais " + valor.ToString("C3"));
            MessageBox.Show("Fixo 2 casas decimais " + valor.ToString("F2"));
            MessageBox.Show("Número 2 casas decimais " + valor.ToString("N2"));
        }

        private void btnFrmtValStrFmrt_Click(object sender, EventArgs e)
        {
            double valor = 1255.686;

            MessageBox.Show("Moeda 3 casas decimais " + String.Format("{0:C3}", valor));
            MessageBox.Show("Fixo 2 casas decimais " + String.Format("{0:F2}", valor));
            MessageBox.Show("Número 2 casas decimais " + String.Format("{0:N2}", valor));
        }

        private void btnOpDatas_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            MessageBox.Show("Soma 2 dias: " + dt.AddDays(2).ToShortDateString());
            MessageBox.Show("Soma 2 horas: " + dt.AddHours(2).ToLongTimeString());
            MessageBox.Show("Dia da semana: " + dt.DayOfWeek.ToString());
            MessageBox.Show("Dias no mês 2/2000: " + DateTime.DaysInMonth(2000, 2));
            DateTime dt2 = Convert.ToDateTime("01/02/2023");
            DateTime dt1 = DateTime.Today;
            double dias = dt1.Subtract(dt2).TotalDays;
            MessageBox.Show("Diferença entre hoje e 01/02/2023: " + dias);

        }

        private void btnDatasCalend_Click(object sender, EventArgs e)
        {
            DateTime dt1 = monthCalendar1.SelectionStart;
            DateTime dt2;
            dt2 = dateTimePicker1.Value;
            MessageBox.Show(String.Format("{0:d}", dt1));
            MessageBox.Show(dt2.ToString());
        }
    }
}
