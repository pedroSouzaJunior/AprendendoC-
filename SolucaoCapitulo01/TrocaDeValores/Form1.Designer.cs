using System.Windows.Forms;
using System.ComponentModel;

namespace TrocaDeValores {
    partial class frmTrocaDeValores {

        private IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.valor1 = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.botaoSV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toca Valores";
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(12, 34);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(100, 20);
            this.valor1.TabIndex = 1;
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(137, 34);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(100, 20);
            this.valor2.TabIndex = 2;
            // 
            // botaoSV
            // 
            this.botaoSV.Location = new System.Drawing.Point(83, 80);
            this.botaoSV.Name = "botaoSV";
            this.botaoSV.Size = new System.Drawing.Size(75, 23);
            this.botaoSV.TabIndex = 3;
            this.botaoSV.Text = "Trocar";
            this.botaoSV.UseVisualStyleBackColor = true;
            this.botaoSV.Click += new System.EventHandler(this.button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "valor1";
            // 
            // frmTrocaDeValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 109);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botaoSV);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTrocaDeValores";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox valor1;
        private TextBox valor2;
        private Button botaoSV;
        private Label label3;
        private Label label2;
    }
}

