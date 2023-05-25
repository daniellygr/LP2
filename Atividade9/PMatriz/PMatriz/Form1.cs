using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace PMatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            string auxiliar = "";

            int[] vetor = new int[20];

            for (int i = 0; i < 20; i++)
            {
                auxiliar = Interaction.InputBox("Digite um número", "Entrada de dados");
                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Número inválido");
                    i--;
                }
            }

            Array.Reverse(vetor);

            auxiliar = "";

            foreach (var i in vetor)
            {
                auxiliar += "\n" + i.ToString();
            }
            MessageBox.Show(auxiliar);
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            double faturamento = 0;
            string auxiliar = "";
            double[] Quantidade = new double[10];
            double[] Preco = new double[10];

            for (var i = 0; i < 10; i++)
            {
                auxiliar = Interaction.InputBox("Digite a quantidade " + (i + 1).ToString(), "Entrada da quantidade");
                if (!double.TryParse(auxiliar, out Quantidade[i]))
                {
                    MessageBox.Show("Quantidade inválida");
                    i--;
                }
                else
                {
                    while (Preco[i] <= 0)
                    {
                        auxiliar = "";
                        auxiliar = Interaction.InputBox("Digite o preço " + (i + 1).ToString(), "Entrada do preço");

                        if (!double.TryParse(auxiliar, out Preco[i]))
                        {
                            MessageBox.Show("Preço inválido");
                        }
                    }
                    faturamento += Quantidade[i] * Preco[i];
                }
            }
            MessageBox.Show("Faturamento: " + faturamento.ToString("N2"));
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", 
                "Jose", "Nelma", "Tobby" };
            Int32 i, Total = 0;
            Int32 n = Alunos.Length;

            for (i = 0; i < n - 1; i++) 
            { 
                Total += Alunos[i].Length; 
            }

            MessageBox.Show(Total.ToString());
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList() {"Ana", "André", "Débora", "Fátima",
                                "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais"};

            alunos.Remove("Otávio");

            foreach (var item in alunos)
            {
                MessageBox.Show(item.ToString());
            }


        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            double[] mediaAluno = new double[20];
            double soma = 0;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string carregar = Interaction.InputBox($"Digite a nota {j + 1} do aluno {i + 1}:", "Entrada" +
                        "de dados");

                    if (!double.TryParse(carregar, out double nota))
                    {
                        MessageBox.Show("Digite um número válido");
                        j--;
                    }
                    else if (nota < 0) 
                    {
                        MessageBox.Show("Digite um valor maior ou igual a zero");
                        j--;
                    }
                    else
                    {
                        notas[i, j] = nota;
                    }
                }
                
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    soma += notas[i, j];
                }

                mediaAluno[i] = soma / 3;
            }

            for (int i = 0; i < 20; i++)
            {
                MessageBox.Show($"Aluno {i + 1}: média " + mediaAluno[i].ToString("N2"));
            }
        }

        private void btnExercicio6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Exercicio6>().Count() > 0)
            {
                MessageBox.Show("Form já existe!");
                Application.OpenForms["Exercicio6"].BringToFront();
            }

            else
            {
                Exercicio6 objEx6 = new Exercicio6();
                objEx6.WindowState = FormWindowState.Normal;
                objEx6.Show();
            }
        }
    }
}
