using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificarDesconto_Click(object sender, EventArgs e)
        {

            txtNomeFuncionario.Focus();

            double descontoINSS;
            double descontoIRPF;
            double salarioBruto;
            double salarioFamilia;
            double salarioLiquido;
            byte numeroFilhos;
            string nomeFuncionario;
            string estadoCivil;

            nomeFuncionario = txtNomeFuncionario.Text;
            numeroFilhos = Convert.ToByte(cbxNumeroFilhos.Text);

            //Verificação do estado civil
            if (rbtnFeminino.Checked)
            {
                if (ckbxCasado.Checked)
                {
                    estadoCivil = "casada";
                }
                else
                {
                    estadoCivil = "solteira";
                }

                lblInformacao.Text = $"Os descontos da Sra. {nomeFuncionario}, {estadoCivil} " +
                    $"e que possui {numeroFilhos} filhos são:";
            }
            else
            {
                if (ckbxCasado.Checked)
                {
                    estadoCivil = "casado";
                }
                else
                {
                    estadoCivil = "solteiro";
                }

                lblInformacao.Text = $"Os descontos do Sr. {nomeFuncionario}, {estadoCivil} " +
                    $"e que possui {numeroFilhos} filhos são:";
            }

            //Validação das entradas
            if((txtNomeFuncionario.Text == "") || (mskbxSalarioBruto.Text == "") || (cbxNumeroFilhos.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!"); 
            } 

            else if ((txtNomeFuncionario.Text == "") || (txtNomeFuncionario.Text.Length < 10))
            {
                MessageBox.Show("Inserir um nome válido");
            }
            
            //Validação do salário
            else if (double.TryParse(mskbxSalarioBruto.Text, out salarioBruto))
            {

                if (salarioBruto <= 0)
                {
                    MessageBox.Show("Digite um valor maior que zero!");
                }
                else 
                {
                    //Cálculo INSS
                    if (salarioBruto <= 800.47)
                    {
                        txtAliquotaINSS.Text = "7.65%";
                        descontoINSS = 0.0765 * salarioBruto;
                    }
                    else if (salarioBruto <= 1050)
                    {
                        txtAliquotaINSS.Text = "8.65%";
                        descontoINSS = 0.0865 * salarioBruto;
                    }
                    else if (salarioBruto <= 1400.77)
                    {
                        txtAliquotaINSS.Text = "9.00%";
                        descontoINSS = 0.09 * salarioBruto;
                    }
                    else if (salarioBruto <= 2801.56)
                    {
                        txtAliquotaINSS.Text = "11.00%";
                        descontoINSS = 0.11 * salarioBruto;
                    }
                    else
                    {
                        txtAliquotaINSS.Text = "Teto";
                        descontoINSS = 308.17;
                    }

                    txtDescontoINSS.Text = $"{descontoINSS:N2}";

                    //Cálculo IRPF
                    if (salarioBruto <= 1257.12)
                    {
                        txtAliquotaIRPF.Text = "0.00%";
                        descontoIRPF = 0 * salarioBruto;
                    }
                    else if (salarioBruto <= 2512.08)
                    {
                        txtAliquotaIRPF.Text = "15.00%";
                        descontoIRPF = 0.15 * salarioBruto;
                    }
                    else
                    {
                        txtAliquotaIRPF.Text = "27.50%";
                        descontoIRPF = 0.275 * salarioBruto;
                    }

                    //Cálculo Salário Família
                    if (salarioBruto <= 435.52)
                    {
                        salarioFamilia = 22.33 * numeroFilhos;
                    }
                    else if (salarioBruto <= 654.61)
                    {
                        salarioFamilia = 15.74 * numeroFilhos;
                    }
                    else
                    {
                        salarioFamilia = 0;
                    }

                    //Cálculo do salário líquido
                    salarioLiquido = salarioBruto - descontoINSS - descontoIRPF + salarioFamilia;

                    //Atribuição às saídas
                    txtDescontoIRPF.Text = $"{descontoIRPF:N2}";
                    txtSalarioFamilia.Text = $"{salarioFamilia:N2}";
                    txtSalarioLiquido.Text = $"{salarioLiquido:N2}";

                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Dados inseridos
            mskbxSalarioBruto.Clear();
            txtNomeFuncionario.Clear();
            ckbxCasado.Checked = false;
            cbxNumeroFilhos.ResetText();

            //Dados de saída
            txtAliquotaINSS.Clear();
            txtAliquotaIRPF.Clear();
            txtDescontoINSS.Clear();
            txtDescontoIRPF.Clear();
            txtSalarioFamilia.Clear();
            txtSalarioLiquido.Clear();
            lblInformacao.Text = null;

        }
    }
}
