using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    internal class Mensalista : Empregado
    {
        public static String Empresa = "Toyota";
        public const String Filial = "Filial Sorocaba";

        public double SalarioMensal { get; set; }

        public override double SalarioBruto()
        { return SalarioMensal; }

        public Mensalista() 
        {
            System.Windows.Forms.MessageBox.Show("aqui é mensalista");
        }
        public Mensalista(int matx, string nomex, DateTime datax, double salx) 
        {
            this.NomeEmpregado = nomex;
            this.Matricula = matx;
            this.DataEntradaEmpresa = datax;
            this.SalarioMensal = salx;
        }
    }
}
