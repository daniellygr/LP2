using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Mensalista : Empregado //especialização -> herança
    {
        public Double SalarioMensal { get; set; }

        //sobre-escrevendo o método

        public override double SalarioBruto()
        {
            return SalarioMensal;
        }

        //construtor -> new

        public Mensalista()
        {
            System.Windows.Forms.MessageBox.Show("Passei por aqui");
        }
        public Mensalista(double x)
        {

        }

        public Mensalista(int matx, string nomex, DateTime datax, double salariox)
        {
            Matricula = matx;
            NomeEmpregado = nomex;
            DataEntradaEmpresa = datax;
            SalarioMensal = salariox;
        }
    }
}
