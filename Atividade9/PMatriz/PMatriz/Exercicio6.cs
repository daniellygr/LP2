using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMatriz
{
    public partial class Exercicio6 : Form
    {
        public Exercicio6()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[7];

            for (int i = 0; i < 7; i++)
            {
                nomes[i] = Interaction.InputBox("Digite o nome " + (i + 1) + ":", "Entrada: ");
            }

            lstBox.Items.Clear();
            foreach (var item in nomes)
            {
                var nomeSemEspaco = item.Replace(" ", "");
                lstBox.Items.Add($"O nome: {item} tem {nomeSemEspaco.Length} caracteres!");
            }
        }
    }
}
