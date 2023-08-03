namespace Atividade_Calculadora_Windows_Forms
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
            this.mutiplicarButton1 = new System.Windows.Forms.Button();
            this.somarButton2 = new System.Windows.Forms.Button();
            this.numero1TextBox1 = new System.Windows.Forms.TextBox();
            this.numero2TextBox2 = new System.Windows.Forms.TextBox();
            this.dividirButton3 = new System.Windows.Forms.Button();
            this.subitrairButton4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mutiplicarButton1
            // 
            this.mutiplicarButton1.Location = new System.Drawing.Point(72, 85);
            this.mutiplicarButton1.Name = "mutiplicarButton1";
            this.mutiplicarButton1.Size = new System.Drawing.Size(48, 18);
            this.mutiplicarButton1.TabIndex = 0;
            this.mutiplicarButton1.Text = "*";
            this.mutiplicarButton1.UseVisualStyleBackColor = true;
            this.mutiplicarButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // somarButton2
            // 
            this.somarButton2.Location = new System.Drawing.Point(12, 85);
            this.somarButton2.Name = "somarButton2";
            this.somarButton2.Size = new System.Drawing.Size(48, 18);
            this.somarButton2.TabIndex = 1;
            this.somarButton2.Text = "+";
            this.somarButton2.UseVisualStyleBackColor = true;
            this.somarButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numero1TextBox1
            // 
            this.numero1TextBox1.Location = new System.Drawing.Point(12, 17);
            this.numero1TextBox1.Name = "numero1TextBox1";
            this.numero1TextBox1.Size = new System.Drawing.Size(143, 20);
            this.numero1TextBox1.TabIndex = 4;
            // 
            // numero2TextBox2
            // 
            this.numero2TextBox2.Location = new System.Drawing.Point(12, 43);
            this.numero2TextBox2.Name = "numero2TextBox2";
            this.numero2TextBox2.Size = new System.Drawing.Size(143, 20);
            this.numero2TextBox2.TabIndex = 5;
            // 
            // dividirButton3
            // 
            this.dividirButton3.Location = new System.Drawing.Point(72, 109);
            this.dividirButton3.Name = "dividirButton3";
            this.dividirButton3.Size = new System.Drawing.Size(48, 18);
            this.dividirButton3.TabIndex = 6;
            this.dividirButton3.Text = "/";
            this.dividirButton3.UseVisualStyleBackColor = true;
            this.dividirButton3.Click += new System.EventHandler(this.button3_Click);
            // 
            // subitrairButton4
            // 
            this.subitrairButton4.Location = new System.Drawing.Point(12, 109);
            this.subitrairButton4.Name = "subitrairButton4";
            this.subitrairButton4.Size = new System.Drawing.Size(48, 18);
            this.subitrairButton4.TabIndex = 7;
            this.subitrairButton4.Text = "-";
            this.subitrairButton4.UseVisualStyleBackColor = true;
            this.subitrairButton4.Click += new System.EventHandler(this.subitrairButton4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 159);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subitrairButton4);
            this.Controls.Add(this.dividirButton3);
            this.Controls.Add(this.numero2TextBox2);
            this.Controls.Add(this.numero1TextBox1);
            this.Controls.Add(this.somarButton2);
            this.Controls.Add(this.mutiplicarButton1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mutiplicarButton1;
        private System.Windows.Forms.Button somarButton2;
        private System.Windows.Forms.TextBox numero1TextBox1;
        private System.Windows.Forms.TextBox numero2TextBox2;
        private System.Windows.Forms.Button dividirButton3;
        private System.Windows.Forms.Button subitrairButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

