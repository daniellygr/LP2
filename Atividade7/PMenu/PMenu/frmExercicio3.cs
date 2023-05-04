﻿using System;
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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemoveOcorrencias_Click(object sender, EventArgs e)
        {
            int posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while (posicao >= 0) 
            { 
                txtPalavra2.Text = txtPalavra1.Text.Substring(0, posicao) +
                    txtPalavra2.Text.Substring(posicao+txtPalavra1.Text.Length, txtPalavra2.Text.Length - posicao -
                    txtPalavra1.Text.Length);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void btnInvertePalavra_Click(object sender, EventArgs e)
        {   //passar string para array
            char[] meuArray = txtPalavra1.Text.ToCharArray();
            //inverter o array usando o reverse
            Array.Reverse(meuArray);
            //voltar para string
            foreach (var c in meuArray)
            {
                txtPalavra2.Text += c;
            }
            MessageBox.Show(txtPalavra2.Text);
        }

        private void btnRemoveOcorrenciasReplace_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text,  "");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPalavra1.Clear();
            txtPalavra2.Clear();
        }
    }
}
