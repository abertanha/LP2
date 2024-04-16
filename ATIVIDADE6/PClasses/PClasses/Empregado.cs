using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    abstract internal class Empregado
    {
        private int matricula;
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string NomeEmpregado
        { 
            get { return nomeEmpregado;}
            set { nomeEmpregado = value;}
        }
        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }
        public virtual int TempoTrabalho()
        {
            //virtual significa que esse método pode ser reescrito
            TimeSpan span = //representa um intervalo de tempo
                DateTime.Today.Subtract(DataEntradaEmpresa);// variavel tipo data.data de hoje. menos data de entrada na empresa

            return (span.Days);
        }
        public abstract double SalarioBruto();

        public Empregado()
        {
            System.Windows.Forms.MessageBox.Show("aqui é empregado");
        }
        public Empregado(int mat, string nome, DateTime datax) 
        {
            matricula = mat;
            nomeEmpregado = nome;
            dataEntradaEmpresa = datax;
        }
    }

}
