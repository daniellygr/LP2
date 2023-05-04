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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            if ((int.TryParse(txtNumero1.Text, out int numero1)) &&
                (int.TryParse(txtNumero2.Text, out int numero2)))

                if (numero1 > numero2)
                {
                    MessageBox.Show("O número 1 deve ser menor que o número 2!");
                }
                else 
                {
                    Random random = new Random();
                    double aleatorio = random.Next(numero1, numero2);

                    MessageBox.Show("O número aleatório sorteado é " + aleatorio);
                }

            else
            {
                MessageBox.Show("Digite dois números inteiros válidos");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
        }
    }
}
