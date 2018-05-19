namespace ListaEstruturaCondicionalWFA
{
    partial class Exercicio02
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
            this.lbNumero = new System.Windows.Forms.Label();
            this.rbChecar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(21, 26);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(73, 22);
            this.lbNumero.TabIndex = 0;
            this.lbNumero.Text = "Número";
            // 
            // rbChecar
            // 
            this.rbChecar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChecar.Location = new System.Drawing.Point(21, 355);
            this.rbChecar.Name = "rbChecar";
            this.rbChecar.Size = new System.Drawing.Size(195, 61);
            this.rbChecar.TabIndex = 2;
            this.rbChecar.Text = "Chegcar";
            this.rbChecar.UseVisualStyleBackColor = true;
            this.rbChecar.Click += new System.EventHandler(this.rbChecar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(21, 51);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(157, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // Exercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 452);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.rbChecar);
            this.Controls.Add(this.lbNumero);
            this.Name = "Exercicio02";
            this.Text = "Exercicio02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Button rbChecar;
        private System.Windows.Forms.TextBox txtNumero;
    }
}