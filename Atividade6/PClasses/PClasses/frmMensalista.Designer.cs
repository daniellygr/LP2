namespace PClasses
{
    partial class frmMensalista
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
            this.btnInstanciarMensalista = new System.Windows.Forms.Button();
            this.btnInstanciarMensalistaP = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioMensal = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInstanciarMensalista
            // 
            this.btnInstanciarMensalista.Location = new System.Drawing.Point(33, 245);
            this.btnInstanciarMensalista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInstanciarMensalista.Name = "btnInstanciarMensalista";
            this.btnInstanciarMensalista.Size = new System.Drawing.Size(165, 62);
            this.btnInstanciarMensalista.TabIndex = 0;
            this.btnInstanciarMensalista.Text = "Instanciar Mensalista";
            this.btnInstanciarMensalista.UseVisualStyleBackColor = true;
            this.btnInstanciarMensalista.Click += new System.EventHandler(this.btnInstanciarMensalista_Click);
            // 
            // btnInstanciarMensalistaP
            // 
            this.btnInstanciarMensalistaP.Location = new System.Drawing.Point(206, 245);
            this.btnInstanciarMensalistaP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInstanciarMensalistaP.Name = "btnInstanciarMensalistaP";
            this.btnInstanciarMensalistaP.Size = new System.Drawing.Size(165, 62);
            this.btnInstanciarMensalistaP.TabIndex = 1;
            this.btnInstanciarMensalistaP.Text = "Instanciar Mensalista Passando Parâmetros";
            this.btnInstanciarMensalistaP.UseVisualStyleBackColor = true;
            this.btnInstanciarMensalistaP.Click += new System.EventHandler(this.btnInstanciarMensalistaP_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(30, 24);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(61, 16);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 57);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblSalarioMensal
            // 
            this.lblSalarioMensal.AutoSize = true;
            this.lblSalarioMensal.Location = new System.Drawing.Point(30, 90);
            this.lblSalarioMensal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioMensal.Name = "lblSalarioMensal";
            this.lblSalarioMensal.Size = new System.Drawing.Size(97, 16);
            this.lblSalarioMensal.TabIndex = 4;
            this.lblSalarioMensal.Text = "Salário Mensal";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(30, 123);
            this.lblDataEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(181, 16);
            this.lblDataEntrada.TabIndex = 5;
            this.lblDataEntrada.Text = "Data de Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(98, 18);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(272, 22);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(99, 48);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(272, 22);
            this.txtNome.TabIndex = 7;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(134, 86);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(236, 22);
            this.txtSalario.TabIndex = 8;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(219, 119);
            this.txtDataEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(151, 22);
            this.txtDataEntrada.TabIndex = 9;
            // 
            // gbxHome
            // 
            this.gbxHome.Controls.Add(this.rbtnNao);
            this.gbxHome.Controls.Add(this.rbtnSim);
            this.gbxHome.Location = new System.Drawing.Point(33, 172);
            this.gbxHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxHome.Size = new System.Drawing.Size(128, 55);
            this.gbxHome.TabIndex = 10;
            this.gbxHome.TabStop = false;
            this.gbxHome.Text = "Home Office";
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(10, 23);
            this.rbtnSim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(48, 20);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Checked = true;
            this.rbtnNao.Location = new System.Drawing.Point(66, 23);
            this.rbtnNao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(51, 20);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 335);
            this.Controls.Add(this.gbxHome);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblSalarioMensal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.btnInstanciarMensalistaP);
            this.Controls.Add(this.btnInstanciarMensalista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.gbxHome.ResumeLayout(false);
            this.gbxHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstanciarMensalista;
        private System.Windows.Forms.Button btnInstanciarMensalistaP;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioMensal;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
    }
}