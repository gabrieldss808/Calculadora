namespace Calculadora
{
    partial class Calc
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
            this.Soma = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Soma
            // 
            this.Soma.Location = new System.Drawing.Point(12, 113);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(75, 23);
            this.Soma.TabIndex = 0;
            this.Soma.Text = "Soma";
            this.Soma.UseVisualStyleBackColor = true;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // subtracao
            // 
            this.subtracao.Location = new System.Drawing.Point(197, 113);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(75, 23);
            this.subtracao.TabIndex = 1;
            this.subtracao.Text = "Subtração";
            this.subtracao.UseVisualStyleBackColor = true;
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(93, 61);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 20);
            this.numero.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.Soma);
            this.Name = "Calc";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

