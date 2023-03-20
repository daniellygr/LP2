using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Testar se a tecla apertada é Enter (13 na ASCII), se for, ela vai ter a função de TAB
             e o "som" de erro será desabilidado */
            
            if (e.KeyChar == (char)(13)) {
                SendKeys.Send ("{TAB}");
                e.Handled = true;
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            /* Validar se o endereço é vazio ou se é menor que 20 caracteres, a validação
             ocorre após o foco ter passado para outro componente. Então, após a validação 
             e a mensagem aparecer na tela, o foco retorna para o componente */

            if ((textBox2.Text == "") || (textBox2.Text.Length < 20)) {
                MessageBox.Show ("Endereço inválido");
                textBox2.Focus();
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            /* Validar se o e-mail é vazio, a validação ocorre durante o foco no componente. 
             A validação é cancelada e retorna o foco. */
            if (textBox3.Text == "") {
                MessageBox.Show ("E-mail vazio");
                e.Cancel = true;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            //Quando sair do botão Celular (perder o foco), uma mensagem irá aparecer.
            MessageBox.Show ("Perdendo o foco do celular");
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            //Quando entrar no botão CPF (ganhar o foco), uma mensagem irá aparecer.
            MessageBox.Show ("Digite o CPF: ");
        }
    }
}
