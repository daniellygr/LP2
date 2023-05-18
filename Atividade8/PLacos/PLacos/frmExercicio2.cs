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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double numeroH = 0;

            if (!Double.TryParse(txtBx.Text, out Double numeroN))
            {
                MessageBox.Show("Digite um valor válido!");
            }
            else if (numeroN == 0) 
            {
                MessageBox.Show("Digite um valor diferente de zero!");
            }
            else
            {
                for (int i = 0; i < numeroN; i++)
                {
                    numeroH += 1.0 / (Double.Parse(i.ToString("N2")) + 1.00);
                }


                MessageBox.Show($"Valor H = {numeroH:N2}");
            }
        }
    }
}
