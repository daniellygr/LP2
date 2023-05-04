using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnQtdNumericos_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (int i = 0; i < richTxtBox.Text.Length; i++)
            {
                if (char.IsNumber(richTxtBox.Text[i]))
                {
                    contador += 1;
                }
            }

            MessageBox.Show("Quantidade de números: " + contador);
        }

        private void btnPrimeiroBranco_Click(object sender, EventArgs e)
        {
            int i = 0;

            while (i < richTxtBox.Text.Length)
            {
                if (char.IsWhiteSpace(richTxtBox.Text[i]) == true) 
                {
                    MessageBox.Show($"Caracter em branco na posição: {i+1}");
                    return;
                }

                i++;
            }

            MessageBox.Show("Não existe caracter em branco");
        }

        private void btnQtdAlfabeticos_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach (char letra in richTxtBox.Text)
            {
                if (char.IsLetter(letra))
                {
                    contador += 1;
                }
            }
            MessageBox.Show("Quantidade de letras: " + contador);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            richTxtBox.Clear();
        }
    }
}
