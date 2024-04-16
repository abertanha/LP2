using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    internal class Horista : Empregado
    {
        public double SalarioHora { get; set; }

        public double NumeroHora { get; set; }

        public int DiasFalta { get; set; }

        public override double SalarioBruto()
        {
            return SalarioHora * NumeroHora;
        }
        public override int TempoTrabalho()
        {
            TimeSpan span =
                DateTime.Today.Subtract(DataEntradaEmpresa);//substituindo o método de quantificação de horas.
            return (Convert.ToInt32(span.Days) - DiasFalta);
        }

    }
}
