namespace PClasses
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
            this.btnHorista = new System.Windows.Forms.Button();
            this.btnMensalista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHorista
            // 
            this.btnHorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorista.Location = new System.Drawing.Point(85, 60);
            this.btnHorista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHorista.Name = "btnHorista";
            this.btnHorista.Size = new System.Drawing.Size(132, 35);
            this.btnHorista.TabIndex = 0;
            this.btnHorista.Text = "Horista";
            this.btnHorista.UseVisualStyleBackColor = true;
            this.btnHorista.Click += new System.EventHandler(this.btnHorista_Click);
            // 
            // btnMensalista
            // 
            this.btnMensalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensalista.Location = new System.Drawing.Point(335, 60);
            this.btnMensalista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMensalista.Name = "btnMensalista";
            this.btnMensalista.Size = new System.Drawing.Size(132, 35);
            this.btnMensalista.TabIndex = 1;
            this.btnMensalista.Text = "Mensalista";
            this.btnMensalista.UseVisualStyleBackColor = true;
            this.btnMensalista.Click += new System.EventHandler(this.btnMensalista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 176);
            this.Controls.Add(this.btnMensalista);
            this.Controls.Add(this.btnHorista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHorista;
        private System.Windows.Forms.Button btnMensalista;
    }
}

