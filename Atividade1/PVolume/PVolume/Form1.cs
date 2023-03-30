using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {

        double raio;
        double altura;
        double volume;

        public Form1()
        {
              InitializeComponent();
        }

        private void txtRaio_Validated(object sender, EventArgs e)
        {
            //Validar se o valor digitado consegue ser passado para a váriavel raio (double)
            if (!double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("Raio inválido!");
                //txtRaio.Focus();
            }
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            //Validar se o valor digitado consegue ser passado para a váriavel altura (double)
            if (!Double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Altura inválida");
                //txtAltura.Focus();
            }
            //Verificar se a altura é válida (valor maior que zero)
            else
            {
                if (altura <= 0)
                {
                    MessageBox.Show("Altura deve ser maior que zero");
                    //txtAltura.Focus();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if ((!Double.TryParse(txtRaio.Text, out raio)) 
                || (!Double.TryParse(txtAltura.Text, out altura)))
            {
                MessageBox.Show("Valores inválidos");
            }
            else
            {
                if ((altura <= 0) || (raio <= 0))
                {
                    MessageBox.Show("Valores não podem ser menores que zero");
                }
                else
                {
                    volume = Math.PI * Math.Pow(raio, 2) * altura;
                    //N2 = formatar como número com 2 casas decimais
                    txtResultado.Text = volume.ToString("N2");
                }
            }
        }
    }
}
