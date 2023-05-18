namespace PLacos
{
    partial class frmExercicio1
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
            this.rchTxtBx = new System.Windows.Forms.RichTextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnEspacoBranco = new System.Windows.Forms.Button();
            this.btnPares = new System.Windows.Forms.Button();
            this.btnQtdR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTxtBx
            // 
            this.rchTxtBx.Location = new System.Drawing.Point(109, 25);
            this.rchTxtBx.Name = "rchTxtBx";
            this.rchTxtBx.Size = new System.Drawing.Size(286, 96);
            this.rchTxtBx.TabIndex = 0;
            this.rchTxtBx.Text = "";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(68, 25);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(34, 13);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Texto";
            // 
            // btnEspacoBranco
            // 
            this.btnEspacoBranco.Location = new System.Drawing.Point(109, 150);
            this.btnEspacoBranco.Name = "btnEspacoBranco";
            this.btnEspacoBranco.Size = new System.Drawing.Size(75, 48);
            this.btnEspacoBranco.TabIndex = 2;
            this.btnEspacoBranco.Text = "Espaço em branco";
            this.btnEspacoBranco.UseVisualStyleBackColor = true;
            this.btnEspacoBranco.Click += new System.EventHandler(this.btnEspacoBranco_Click);
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(319, 150);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(75, 48);
            this.btnPares.TabIndex = 3;
            this.btnPares.Text = "Pares de letras";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // btnQtdR
            // 
            this.btnQtdR.Location = new System.Drawing.Point(214, 150);
            this.btnQtdR.Name = "btnQtdR";
            this.btnQtdR.Size = new System.Drawing.Size(75, 48);
            this.btnQtdR.TabIndex = 4;
            this.btnQtdR.Text = "Quantidade de r";
            this.btnQtdR.UseVisualStyleBackColor = true;
            this.btnQtdR.Click += new System.EventHandler(this.btnQtdR_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQtdR);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnEspacoBranco);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.rchTxtBx);
            this.Name = "frmExercicio1";
            this.Text = "fmrExercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtBx;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnEspacoBranco;
        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.Button btnQtdR;
    }
}