using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{

    public partial class Form1 : Form
    {
        double numero1; //variaveis globais
        double numero2;
        double resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNum1.Text, out numero1))
            {
                MessageBox.Show("Número 1 inválido");
                // txtNum1.Focus();
            }
        }

        private void txtNum2_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse (txtNum2.Text, out numero2))
            {
                MessageBox.Show("Número 2 inválido!");
                // txtNum2.Focus();
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if ((Double.TryParse (txtNum1.Text, out numero1)) && (Double.TryParse(txtNum2.Text, out numero2)))
            {
                resultado = numero1 + numero2;
                txtResult.Text = resultado.ToString("F4");
            }
            else
            {
                MessageBox.Show("Número inválido");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if ((Double.TryParse(txtNum1.Text, out numero1)) && (Double.TryParse(txtNum2.Text, out numero2)))
            {
                resultado = numero1 - numero2;
                txtResult.Text = resultado.ToString("F4");
            }
            else
            {
                MessageBox.Show("Números inválidos");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if ((Double.TryParse(txtNum1.Text, out numero1)) && (Double.TryParse(txtNum2.Text, out numero2)))
            {
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    txtResult.Text = resultado.ToString("F4");
                }
                else
                {
                    MessageBox.Show("Número 2 tem que ser diferente de zero!");
                }
            }
            else
            {
                MessageBox.Show("Números inválidos");
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if ((Double.TryParse(txtNum1.Text, out numero1)) && (Double.TryParse(txtNum2.Text, out numero2))) 
            {
                resultado = numero1 * numero2;
                txtResult.Text = resultado.ToString("F4") ;
            }
            else
            {
                MessageBox.Show("Números inválidos");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResult.Clear();
        }
    }
}
