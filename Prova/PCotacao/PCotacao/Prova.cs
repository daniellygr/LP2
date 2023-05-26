using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PCotacao
{
    public partial class Prova : Form
    {
        public Prova()
        {
            InitializeComponent();
        }

        private void BtnExecutar_Click(object sender, EventArgs e)
        {
            double[,] cotacao = new double[9,3];
            double[] mediaGeral = new double[9];
            double soma = 0;
            double auxiliar;
            double media;
            string recebimento;

            for (int i = 0; i < 9; i++) //Modelo de notebook
            {
                for (int j = 0; j < 3; j++) //Lojas
                {
                    //Entrada de dados do usuário
                    recebimento = Interaction.InputBox($"Digite o valor do modelo {i+1} da loja {j + 1}:", "Entrada de dados");

                    // Verificar se o usuário cancelou a entrada de dados
                    if (string.IsNullOrEmpty(recebimento))
                    {
                        MessageBox.Show("Entrada de dados cancelada. O programa será encerrado.");
                        return; // Encerrar o programa
                    }
                    //Verificar se a entrada é um valor numérico
                    else if (!double.TryParse(recebimento, out double nota))
                    {
                        MessageBox.Show("Digite um valor válido!");
                        j--;
                    }
                    //Verificar se o valor é maior que zero
                    else if (nota <= 0)
                    {
                        MessageBox.Show("Digite um valor maior que zero");
                        j--;
                    }
                    //Atribuir o valor recebido na matriz
                    else
                    {
                        cotacao[i, j] = nota;
                    }
                }

                //Cálculo da média de cada notebook nas 3 lojas
                media = ((cotacao[i, 0]) + (cotacao[i, 1]) + (cotacao[i, 2])) / 3;

                //Adicionar a informação de cada notebook no Listbox
                lstbxCotacao.Items.Add($"Notebook {i + 1} - Loja 1: {(cotacao[i, 0]):C2}, loja 2: {(cotacao[i, 1]):C2} e loja 3: {(cotacao[i, 2]):C2}. Média: {media:C2}");

                //Atribuir a media de cada notebook ao vetor de média geral
                mediaGeral[i] = media;
            }

            lstbxCotacao.Items.Add("-----------------------------------------------------");

            //Incrementar a media unitária na variável 'soma'
            for (int i = 0; i < 9; i++)
            {
                soma += mediaGeral[i];
            }

            //Cálculo da média geral
            auxiliar = soma / 9;

            //Adicionar a informação da média geral ao Listbox
            lstbxCotacao.Items.Add($"Média geral dos computadores: {auxiliar:C2}");

        }
    }
}
