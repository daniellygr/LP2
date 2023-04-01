using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CálculoIMC
{
    public partial class Form1 : Form
    {
        double peso;
        double altura;
        double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void mskbxPeso_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(mskbxPeso.Text, out peso))
            {
                MessageBox.Show("Peso inválido!");
            }
        }

        private void maskedTextBox2_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(mskbxAltura.Text, out altura))
            {
                MessageBox.Show("Altura inválida!");
            }
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            if ((Double.TryParse(mskbxPeso.Text, out peso)) && (Double.TryParse(mskbxAltura.Text, out altura)))
            {
                if (peso <= 0)
                {
                    MessageBox.Show("Peso inválido! Insira um valor maior que zero.");
                }
                else if (altura <= 0)
                {
                    MessageBox.Show("Altura inválida! Insira um valor maior que zero.");
                }
                else
                {
                    resultado = peso / (Math.Pow(altura, 2));
                    resultado = Math.Round(resultado, 1);

                    if (resultado < 18.5)
                    {
                        txtClassificacao.Text = "Magreza";
                        txtResultado.Text = resultado.ToString();
                    }
                    else if (resultado <= 24.9)
                    {
                        txtClassificacao.Text = "Normal";
                        txtResultado.Text = resultado.ToString();
                    }
                    else if (resultado <= 29.9)
                    {
                        txtClassificacao.Text = "Sobrepeso";
                        txtResultado.Text = resultado.ToString();
                    }
                    else if (resultado <= 39.9)
                    {
                        txtClassificacao.Text = "Obesidade";
                        txtResultado.Text = resultado.ToString();
                    }
                    else
                    {
                        txtClassificacao.Text = "Obesidade grave";
                        txtResultado.Text = resultado.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Valores inválidos");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtClassificacao.Clear();
            txtResultado.Clear();
            mskbxAltura.Clear();
            mskbxPeso.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
