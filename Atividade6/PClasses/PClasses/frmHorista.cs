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
            //Não é possível: Empregado obj1 = new Empregado();

            //Instanciar o objeto classe Mensalista
            Horista objHorista = new Horista();

            //set
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalario.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumHoras.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFalta.Text);

            if (rbtnSim.Checked)
            {
                objHorista.HomeOffice = 'S';
            }
            else
            {
                objHorista.HomeOffice = 'N';
            }

            //get
            MessageBox.Show("Matrícula: " + objHorista.Matricula + "\n" +
                            "Nome: " + objHorista.NomeEmpregado + "\n" +
                            "Data de Entrada: " + objHorista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                            "Salário Bruto (R$): " + objHorista.SalarioBruto().ToString("N2") + "\n" +
                            "Tempo de Empresa (dias): " + objHorista.TempoTrabalho() + "\n" + objHorista.VerificaHome());
        }
    }
}
