
namespace PAtividade08
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
            this.btnExer1 = new System.Windows.Forms.Button();
            this.btnExer2 = new System.Windows.Forms.Button();
            this.btnExer3 = new System.Windows.Forms.Button();
            this.btnExer4 = new System.Windows.Forms.Button();
            this.btnExer5 = new System.Windows.Forms.Button();
            this.btnExer6 = new System.Windows.Forms.Button();
            this.btnExer7 = new System.Windows.Forms.Button();
            this.lboxNomes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExer1
            // 
            this.btnExer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExer1.Location = new System.Drawing.Point(39, 40);
            this.btnExer1.Name = "btnExer1";
            this.btnExer1.Size = new System.Drawing.Size(169, 73);
            this.btnExer1.TabIndex = 0;
            this.btnExer1.Text = "Ler 20 Numeros e Inverter";
            this.btnExer1.UseVisualStyleBackColor = true;
            this.btnExer1.Click += new System.EventHandler(this.btnExer1_Click);
            // 
            // btnExer2
            // 
            this.btnExer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExer2.Location = new System.Drawing.Point(214, 40);
            this.btnExer2.Name = "btnExer2";
            this.btnExer2.Size = new System.Drawing.Size(169, 73);
            this.btnExer2.TabIndex = 1;
            this.btnExer2.Text = "Ler 20 Numeros e Inverter(Reverse)";
            this.btnExer2.UseVisualStyleBackColor = true;
            this.btnExer2.Click += new System.EventHandler(this.btnExer2_Click);
            // 
            // btnExer3
            // 
            this.btnExer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExer3.Location = new System.Drawing.Point(39, 128);
            this.btnExer3.Name = "btnExer3";
            this.btnExer3.Size = new System.Drawing.Size(169, 73);
            this.btnExer3.TabIndex = 2;
            this.btnExer3.Text = "Ler Quantidade e Preço Mercadoria";
            this.btnExer3.UseVisualStyleBackColor = true;
            this.btnExer3.Click += new System.EventHandler(this.btnExer3_Click);
            // 
            // btnExer4
            // 
            this.btnExer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExer4.Location = new System.Drawing.Point(214, 128);
            this.btnExer4.Name = "btnExer4";
            this.btnExer4.Size = new System.Drawing.Size(169, 73);
            this.btnExer4.TabIndex = 3;
            this.btnExer4.Text = "Exercicio4";
            this.btnExer4.UseVisualStyleBackColor = true;
            this.btnExer4.Click += new System.EventHandler(this.btnExer4_Click);
            // 
            // btnExer5
            // 
            this.btnExer5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExer5.Location = new System.Drawing.Point(39, 216);
            this.btnExer5.Name = "btnExer5";
            this.btnExer5.Size = new System.Drawing.Size(169, 73);
            this.btnExer5.TabIndex = 4;
            this.btnExer5.Text = "Exercicio5";
            this.btnExer5.UseVisualStyleBackColor = true;
            this.btnExer5.Click += new System.EventHandler(this.btnExer5_Click);
            // 
            // btnExer6
            // 
            this.btnExer6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExer6.Location = new System.Drawing.Point(214, 216);
            this.btnExer6.Name = "btnExer6";
            this.btnExer6.Size = new System.Drawing.Size(169, 73);
            this.btnExer6.TabIndex = 5;
            this.btnExer6.Text = "Exercicio6";
            this.btnExer6.UseVisualStyleBackColor = true;
            this.btnExer6.Click += new System.EventHandler(this.btnExer6_Click);
            // 
            // btnExer7
            // 
            this.btnExer7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExer7.Location = new System.Drawing.Point(214, 355);
            this.btnExer7.Name = "btnExer7";
            this.btnExer7.Size = new System.Drawing.Size(169, 73);
            this.btnExer7.TabIndex = 6;
            this.btnExer7.Text = "Exercicio7";
            this.btnExer7.UseVisualStyleBackColor = true;
            this.btnExer7.Click += new System.EventHandler(this.btnExer7_Click);
            // 
            // lboxNomes
            // 
            this.lboxNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lboxNomes.FormattingEnabled = true;
            this.lboxNomes.ItemHeight = 24;
            this.lboxNomes.Location = new System.Drawing.Point(423, 40);
            this.lboxNomes.Name = "lboxNomes";
            this.lboxNomes.Size = new System.Drawing.Size(339, 388);
            this.lboxNomes.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lboxNomes);
            this.Controls.Add(this.btnExer7);
            this.Controls.Add(this.btnExer6);
            this.Controls.Add(this.btnExer5);
            this.Controls.Add(this.btnExer4);
            this.Controls.Add(this.btnExer3);
            this.Controls.Add(this.btnExer2);
            this.Controls.Add(this.btnExer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExer1;
        private System.Windows.Forms.Button btnExer2;
        private System.Windows.Forms.Button btnExer3;
        private System.Windows.Forms.Button btnExer4;
        private System.Windows.Forms.Button btnExer5;
        private System.Windows.Forms.Button btnExer6;
        private System.Windows.Forms.Button btnExer7;
        private System.Windows.Forms.ListBox lboxNomes;
    }
}

