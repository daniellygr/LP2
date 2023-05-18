﻿using System;
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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string textoSaida = "";
            string textoRecebido = "";

            for (int i = 0; i < txtTexto.Text.Length; i++)
            {
                if (txtTexto.Text[i] != ' ')
                {
                    textoRecebido += Char.ToLower(txtTexto.Text[i]);
                }
            }

            char[] auxiliar = textoRecebido.ToCharArray();

            Array.Reverse(auxiliar);

            foreach (char caracter in auxiliar)
            {
                textoSaida += caracter;
            }

            if (textoSaida == textoRecebido)
            {
                MessageBox.Show($"O texto é palíndromo: {textoSaida}");
            }
            else
            {
                MessageBox.Show($"O texto não é palíndromo: {textoSaida}");
            }
        }
    }
}
