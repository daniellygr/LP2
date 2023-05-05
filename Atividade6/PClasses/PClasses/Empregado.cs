using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    abstract class Empregado
    {
        private int matricula; //atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;
        
        public int Matricula //propriedade 
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        public Char HomeOffice
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }

        //método são ações-comportamentos

        public String VerificaHome() //método
        {
            if (homeOffice == 'S')
            {
                return "Empregado trabalha em home office";
            }
            else
            {
                return "Empregado não trabalha em home office";
            }
        }

        public virtual int TempoTrabalho() //virtual: método pode ser sobre-escrito
        {
            //representa um intervalo de tempo
            //Time Span permite que retorne em qualquer unidade de medida
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days);
        }

        //deve ser implementado nas classes filhas (subclasses)
        //o abstrato é o tipo de método que não é obrigatório a implementação, só declaração, 
        //por isso a classe deve ser abstrata

        public abstract double SalarioBruto(); 
    }
}
