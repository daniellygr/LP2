namespace PVolume
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(217, 46);
            this.txtRaio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(148, 26);
            this.txtRaio.TabIndex = 0;
            this.txtRaio.Validated += new System.EventHandler(this.txtRaio_Validated);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(217, 118);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(148, 26);
            this.txtAltura.TabIndex = 1;
            this.txtAltura.Validated += new System.EventHandler(this.txtAltura_Validated);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(217, 190);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(148, 26);
            this.txtResultado.TabIndex = 2;
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(43, 46);
            this.lblRaio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(42, 20);
            this.lblRaio.TabIndex = 3;
            this.lblRaio.Text = "Raio";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(43, 118);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 20);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(43, 190);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(63, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Volume";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(68, 250);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 30);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(239, 250);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Fechar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblRaio);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtRaio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Calculo do Volume do Cilindro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
    }
}

