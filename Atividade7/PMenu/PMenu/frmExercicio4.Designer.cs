namespace PMenu
{
    partial class frmExercicio4
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
            this.richTxtBox = new System.Windows.Forms.RichTextBox();
            this.btnQtdNumericos = new System.Windows.Forms.Button();
            this.btnQtdAlfabeticos = new System.Windows.Forms.Button();
            this.btnPrimeiroBranco = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTxtBox
            // 
            this.richTxtBox.Location = new System.Drawing.Point(30, 12);
            this.richTxtBox.Name = "richTxtBox";
            this.richTxtBox.Size = new System.Drawing.Size(181, 96);
            this.richTxtBox.TabIndex = 0;
            this.richTxtBox.Text = "";
            // 
            // btnQtdNumericos
            // 
            this.btnQtdNumericos.Location = new System.Drawing.Point(217, 12);
            this.btnQtdNumericos.Name = "btnQtdNumericos";
            this.btnQtdNumericos.Size = new System.Drawing.Size(163, 23);
            this.btnQtdNumericos.TabIndex = 1;
            this.btnQtdNumericos.Text = "Quantos caracteres numéricos";
            this.btnQtdNumericos.UseVisualStyleBackColor = true;
            this.btnQtdNumericos.Click += new System.EventHandler(this.btnQtdNumericos_Click);
            // 
            // btnQtdAlfabeticos
            // 
            this.btnQtdAlfabeticos.Location = new System.Drawing.Point(217, 84);
            this.btnQtdAlfabeticos.Name = "btnQtdAlfabeticos";
            this.btnQtdAlfabeticos.Size = new System.Drawing.Size(163, 23);
            this.btnQtdAlfabeticos.TabIndex = 2;
            this.btnQtdAlfabeticos.Text = "Quantos caracteres alfabéticos";
            this.btnQtdAlfabeticos.UseVisualStyleBackColor = true;
            this.btnQtdAlfabeticos.Click += new System.EventHandler(this.btnQtdAlfabeticos_Click);
            // 
            // btnPrimeiroBranco
            // 
            this.btnPrimeiroBranco.Location = new System.Drawing.Point(217, 48);
            this.btnPrimeiroBranco.Name = "btnPrimeiroBranco";
            this.btnPrimeiroBranco.Size = new System.Drawing.Size(163, 23);
            this.btnPrimeiroBranco.TabIndex = 3;
            this.btnPrimeiroBranco.Text = "Primeiro espaço";
            this.btnPrimeiroBranco.UseVisualStyleBackColor = true;
            this.btnPrimeiroBranco.Click += new System.EventHandler(this.btnPrimeiroBranco_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(305, 129);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(217, 129);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPrimeiroBranco);
            this.Controls.Add(this.btnQtdAlfabeticos);
            this.Controls.Add(this.btnQtdNumericos);
            this.Controls.Add(this.richTxtBox);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtBox;
        private System.Windows.Forms.Button btnQtdNumericos;
        private System.Windows.Forms.Button btnQtdAlfabeticos;
        private System.Windows.Forms.Button btnPrimeiroBranco;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}