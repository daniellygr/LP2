namespace PClasses
{
    partial class frmHorista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblSalarioHora = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.btnInstanciarHorista = new System.Windows.Forms.Button();
            this.txtNumHoras = new System.Windows.Forms.TextBox();
            this.lblNumHoras = new System.Windows.Forms.Label();
            this.txtDiasFalta = new System.Windows.Forms.TextBox();
            this.lblDiasFalta = new System.Windows.Forms.Label();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxHome
            // 
            this.gbxHome.Controls.Add(this.rbtnNao);
            this.gbxHome.Controls.Add(this.rbtnSim);
            this.gbxHome.Location = new System.Drawing.Point(32, 233);
            this.gbxHome.Margin = new System.Windows.Forms.Padding(5);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Padding = new System.Windows.Forms.Padding(5);
            this.gbxHome.Size = new System.Drawing.Size(133, 58);
            this.gbxHome.TabIndex = 21;
            this.gbxHome.TabStop = false;
            this.gbxHome.Text = "Home Office";
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Checked = true;
            this.rbtnNao.Location = new System.Drawing.Point(68, 25);
            this.rbtnNao.Margin = new System.Windows.Forms.Padding(5);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(51, 20);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(10, 25);
            this.rbtnSim.Margin = new System.Windows.Forms.Padding(5);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(48, 20);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(218, 123);
            this.txtDataEntrada.Margin = new System.Windows.Forms.Padding(5);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(264, 22);
            this.txtDataEntrada.TabIndex = 20;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(120, 84);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(5);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(362, 22);
            this.txtSalario.TabIndex = 19;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(98, 45);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(384, 22);
            this.txtNome.TabIndex = 18;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(98, 6);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(5);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(384, 22);
            this.txtMatricula.TabIndex = 17;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(29, 129);
            this.lblDataEntrada.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(181, 16);
            this.lblDataEntrada.TabIndex = 16;
            this.lblDataEntrada.Text = "Data de Entrada na Empresa";
            // 
            // lblSalarioHora
            // 
            this.lblSalarioHora.AutoSize = true;
            this.lblSalarioHora.Location = new System.Drawing.Point(29, 90);
            this.lblSalarioHora.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSalarioHora.Name = "lblSalarioHora";
            this.lblSalarioHora.Size = new System.Drawing.Size(83, 16);
            this.lblSalarioHora.TabIndex = 15;
            this.lblSalarioHora.Text = "Salário Hora";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(29, 51);
            this.lblNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(29, 12);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(61, 16);
            this.lblMatricula.TabIndex = 13;
            this.lblMatricula.Text = "Matrícula";
            // 
            // btnInstanciarHorista
            // 
            this.btnInstanciarHorista.Location = new System.Drawing.Point(262, 233);
            this.btnInstanciarHorista.Margin = new System.Windows.Forms.Padding(5);
            this.btnInstanciarHorista.Name = "btnInstanciarHorista";
            this.btnInstanciarHorista.Size = new System.Drawing.Size(220, 76);
            this.btnInstanciarHorista.TabIndex = 11;
            this.btnInstanciarHorista.Text = "Instanciar Horista";
            this.btnInstanciarHorista.UseVisualStyleBackColor = true;
            this.btnInstanciarHorista.Click += new System.EventHandler(this.btnInstanciarHorista_Click);
            // 
            // txtNumHoras
            // 
            this.txtNumHoras.Location = new System.Drawing.Point(153, 162);
            this.txtNumHoras.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumHoras.Name = "txtNumHoras";
            this.txtNumHoras.Size = new System.Drawing.Size(329, 22);
            this.txtNumHoras.TabIndex = 23;
            // 
            // lblNumHoras
            // 
            this.lblNumHoras.AutoSize = true;
            this.lblNumHoras.Location = new System.Drawing.Point(29, 168);
            this.lblNumHoras.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumHoras.Name = "lblNumHoras";
            this.lblNumHoras.Size = new System.Drawing.Size(114, 16);
            this.lblNumHoras.TabIndex = 22;
            this.lblNumHoras.Text = "Número de Horas";
            // 
            // txtDiasFalta
            // 
            this.txtDiasFalta.Location = new System.Drawing.Point(125, 201);
            this.txtDiasFalta.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiasFalta.Name = "txtDiasFalta";
            this.txtDiasFalta.Size = new System.Drawing.Size(357, 22);
            this.txtDiasFalta.TabIndex = 25;
            // 
            // lblDiasFalta
            // 
            this.lblDiasFalta.AutoSize = true;
            this.lblDiasFalta.Location = new System.Drawing.Point(29, 207);
            this.lblDiasFalta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiasFalta.Name = "lblDiasFalta";
            this.lblDiasFalta.Size = new System.Drawing.Size(87, 16);
            this.lblDiasFalta.TabIndex = 24;
            this.lblDiasFalta.Text = "Dias de Falta";
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 384);
            this.Controls.Add(this.txtDiasFalta);
            this.Controls.Add(this.lblDiasFalta);
            this.Controls.Add(this.txtNumHoras);
            this.Controls.Add(this.lblNumHoras);
            this.Controls.Add(this.gbxHome);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblSalarioHora);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.btnInstanciarHorista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.gbxHome.ResumeLayout(false);
            this.gbxHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblSalarioHora;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button btnInstanciarHorista;
        private System.Windows.Forms.TextBox txtNumHoras;
        private System.Windows.Forms.Label lblNumHoras;
        private System.Windows.Forms.TextBox txtDiasFalta;
        private System.Windows.Forms.Label lblDiasFalta;
    }
}