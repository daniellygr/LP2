using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double ladoA;
            double ladoB;
            double ladoC;

            if (!double.TryParse(txtLadoA.Text, out ladoA))
            {
                MessageBox.Show("Lado A inválido!");
            }
            else if (!double.TryParse(txtLadoB.Text, out ladoB))
            {
                MessageBox.Show("Lado B inválido!");
            }
            else if (!double.TryParse(txtLadoC.Text, out ladoC))
            {
                MessageBox.Show("Lado C inválido!");
            }
            else // Testar se forma triângulo (soma dos lados internos deve ser 180º)
            {
                if  (ladoA < (ladoB + ladoC) && ladoA > Math.Abs(ladoB -  ladoC) &&
                    ladoB < (ladoA + ladoC) && ladoB > Math.Abs(ladoA - ladoC) &&
                    ladoB < (ladoA + ladoB) && ladoC > Math.Abs(ladoA - ladoB))
                {
                    //Verificar qual o triângulo
                    if ((ladoA == ladoB) && (ladoB == ladoC))
                    {
                        MessageBox.Show("É um triângulo equilátero.");
                    }
                    else if ((ladoA != ladoB) && (ladoB != ladoC) && (ladoA != ladoC))
                    {
                        MessageBox.Show("É um triângulo escaleno.");
                    }
                    else
                    {
                        MessageBox.Show("É um triângulo isósceles.");
                    }
                }
                else
                {
                    MessageBox.Show("Lados não formam triângulo!");
                }
            }
        }
    }
}
