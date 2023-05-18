using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLacos
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspacoBranco_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach (char letra in rchTxtBx.Text)
            {
                if (char.IsWhiteSpace(letra))
                {
                    contador += 1;
                }
            }

            MessageBox.Show("Quantidade de espaços em branco: " + contador);
        }

        private void btnQtdR_Click(object sender, EventArgs e)
        {

            int contador = 0;

            for (int i = 0; i < rchTxtBx.Text.Length; i++) {

                if (((rchTxtBx.Text[i]) == 'r') || ((rchTxtBx.Text[i]) == 'R')) {

                    contador += 1;
                }

            }

            MessageBox.Show("Quantidade de 'r': " + contador);

        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int contador = 0;
            
            for (int i = 0; i < rchTxtBx.Text.Length - 2; i++)
                //(int i = 1; i < rchTxtBx.Text.Lenght; i++)
            {
                // rchTxtBx.Text[i] == rchTxtBx.Text[i-1]
                if (rchTxtBx.Text[i] == rchTxtBx.Text[i+1])
                {
                    contador += 1;
                }
            }

            MessageBox.Show("Quantidade de pares de letras: " + contador);

        }
    }
 }
