using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Horista : Empregado
        //não posso herdar mais de uma classe não existe herança múltipla
    {
        //prop e 2x tab cria a estrutura da propriedade
        public Double SalarioHora { get; set; }
        public Double NumeroHora { get; set; }
        public int DiasFalta { get; set; }

        public override double SalarioBruto()
        {
            return SalarioHora * NumeroHora;
        }

        //override indica sobrescrever

        public override int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days - DiasFalta);
        }
    }
}
