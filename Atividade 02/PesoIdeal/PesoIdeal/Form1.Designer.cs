
namespace PesoIdeal
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
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.txtPes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.limpaSapora = new System.Windows.Forms.Button();
            this.saiDesgraça = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdeal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSex.Location = new System.Drawing.Point(218, 106);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(368, 29);
            this.txtSex.TabIndex = 0;
            // 
            // txtAlt
            // 
            this.txtAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtAlt.Location = new System.Drawing.Point(218, 163);
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(368, 29);
            this.txtAlt.TabIndex = 1;
            // 
            // txtPes
            // 
            this.txtPes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPes.Location = new System.Drawing.Point(218, 219);
            this.txtPes.Name = "txtPes";
            this.txtPes.Size = new System.Drawing.Size(368, 29);
            this.txtPes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(97, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(97, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(97, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peso";
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.calc.Location = new System.Drawing.Point(218, 319);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(94, 39);
            this.calc.TabIndex = 6;
            this.calc.Text = "Calcular";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // limpaSapora
            // 
            this.limpaSapora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.limpaSapora.Location = new System.Drawing.Point(353, 319);
            this.limpaSapora.Name = "limpaSapora";
            this.limpaSapora.Size = new System.Drawing.Size(94, 39);
            this.limpaSapora.TabIndex = 7;
            this.limpaSapora.Text = "Limpar";
            this.limpaSapora.UseVisualStyleBackColor = true;
            this.limpaSapora.Click += new System.EventHandler(this.limpaSapora_Click);
            // 
            // saiDesgraça
            // 
            this.saiDesgraça.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.saiDesgraça.Location = new System.Drawing.Point(492, 319);
            this.saiDesgraça.Name = "saiDesgraça";
            this.saiDesgraça.Size = new System.Drawing.Size(94, 39);
            this.saiDesgraça.TabIndex = 8;
            this.saiDesgraça.Text = "Sair";
            this.saiDesgraça.UseVisualStyleBackColor = true;
            this.saiDesgraça.Click += new System.EventHandler(this.saiDesgraça_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(97, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Peso Ideal";
            // 
            // txtIdeal
            // 
            this.txtIdeal.Enabled = false;
            this.txtIdeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtIdeal.Location = new System.Drawing.Point(218, 269);
            this.txtIdeal.Name = "txtIdeal";
            this.txtIdeal.Size = new System.Drawing.Size(368, 29);
            this.txtIdeal.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdeal);
            this.Controls.Add(this.saiDesgraça);
            this.Controls.Add(this.limpaSapora);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPes);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.txtSex);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtAlt;
        private System.Windows.Forms.TextBox txtPes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button limpaSapora;
        private System.Windows.Forms.Button saiDesgraça;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdeal;
    }
}

