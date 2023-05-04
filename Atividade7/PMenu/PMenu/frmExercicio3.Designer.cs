namespace PMenu
{
    partial class frmExercicio3
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
            this.btnInvertePalavra = new System.Windows.Forms.Button();
            this.btnRemoveOcorrenciasReplace = new System.Windows.Forms.Button();
            this.btnRemoveOcorrencias = new System.Windows.Forms.Button();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInvertePalavra
            // 
            this.btnInvertePalavra.Location = new System.Drawing.Point(248, 117);
            this.btnInvertePalavra.Name = "btnInvertePalavra";
            this.btnInvertePalavra.Size = new System.Drawing.Size(93, 51);
            this.btnInvertePalavra.TabIndex = 13;
            this.btnInvertePalavra.Text = "Inverte Palavra";
            this.btnInvertePalavra.UseVisualStyleBackColor = true;
            this.btnInvertePalavra.Click += new System.EventHandler(this.btnInvertePalavra_Click);
            // 
            // btnRemoveOcorrenciasReplace
            // 
            this.btnRemoveOcorrenciasReplace.Location = new System.Drawing.Point(149, 117);
            this.btnRemoveOcorrenciasReplace.Name = "btnRemoveOcorrenciasReplace";
            this.btnRemoveOcorrenciasReplace.Size = new System.Drawing.Size(93, 51);
            this.btnRemoveOcorrenciasReplace.TabIndex = 12;
            this.btnRemoveOcorrenciasReplace.Text = "Remove Ocorrências (replace)";
            this.btnRemoveOcorrenciasReplace.UseVisualStyleBackColor = true;
            this.btnRemoveOcorrenciasReplace.Click += new System.EventHandler(this.btnRemoveOcorrenciasReplace_Click);
            // 
            // btnRemoveOcorrencias
            // 
            this.btnRemoveOcorrencias.Location = new System.Drawing.Point(50, 117);
            this.btnRemoveOcorrencias.Name = "btnRemoveOcorrencias";
            this.btnRemoveOcorrencias.Size = new System.Drawing.Size(93, 51);
            this.btnRemoveOcorrencias.TabIndex = 11;
            this.btnRemoveOcorrencias.Text = "Remove Ocorrências";
            this.btnRemoveOcorrencias.UseVisualStyleBackColor = true;
            this.btnRemoveOcorrencias.Click += new System.EventHandler(this.btnRemoveOcorrencias_Click);
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra2.Location = new System.Drawing.Point(48, 77);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(88, 20);
            this.lblPalavra2.TabIndex = 10;
            this.lblPalavra2.Text = "Palavra 2:";
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra1.Location = new System.Drawing.Point(48, 36);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(88, 20);
            this.lblPalavra1.TabIndex = 9;
            this.lblPalavra1.Text = "Palavra 1:";
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(142, 77);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(199, 20);
            this.txtPalavra2.TabIndex = 8;
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(142, 38);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(199, 20);
            this.txtPalavra1.TabIndex = 7;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(266, 187);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(167, 187);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnInvertePalavra);
            this.Controls.Add(this.btnRemoveOcorrenciasReplace);
            this.Controls.Add(this.btnRemoveOcorrencias);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvertePalavra;
        private System.Windows.Forms.Button btnRemoveOcorrenciasReplace;
        private System.Windows.Forms.Button btnRemoveOcorrencias;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}