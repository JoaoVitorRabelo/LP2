
namespace PCalculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtSoma = new System.Windows.Forms.Button();
            this.BtSub = new System.Windows.Forms.Button();
            this.BtMult = new System.Windows.Forms.Button();
            this.BtDiv = new System.Windows.Forms.Button();
            this.Limpa = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.Res = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(95, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(95, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(95, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // BtSoma
            // 
            this.BtSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtSoma.Location = new System.Drawing.Point(99, 267);
            this.BtSoma.Name = "BtSoma";
            this.BtSoma.Size = new System.Drawing.Size(117, 50);
            this.BtSoma.TabIndex = 3;
            this.BtSoma.Text = "Somar";
            this.BtSoma.UseVisualStyleBackColor = true;
            this.BtSoma.Click += new System.EventHandler(this.BtSoma_Click);
            // 
            // BtSub
            // 
            this.BtSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtSub.Location = new System.Drawing.Point(249, 267);
            this.BtSub.Name = "BtSub";
            this.BtSub.Size = new System.Drawing.Size(117, 50);
            this.BtSub.TabIndex = 4;
            this.BtSub.Text = "Subtrair";
            this.BtSub.UseVisualStyleBackColor = true;
            this.BtSub.Click += new System.EventHandler(this.BtSub_Click);
            // 
            // BtMult
            // 
            this.BtMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtMult.Location = new System.Drawing.Point(411, 267);
            this.BtMult.Name = "BtMult";
            this.BtMult.Size = new System.Drawing.Size(117, 50);
            this.BtMult.TabIndex = 5;
            this.BtMult.Text = "Multiplicar";
            this.BtMult.UseVisualStyleBackColor = true;
            this.BtMult.Click += new System.EventHandler(this.BtMult_Click);
            // 
            // BtDiv
            // 
            this.BtDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtDiv.Location = new System.Drawing.Point(573, 267);
            this.BtDiv.Name = "BtDiv";
            this.BtDiv.Size = new System.Drawing.Size(117, 50);
            this.BtDiv.TabIndex = 6;
            this.BtDiv.Text = "Dividir";
            this.BtDiv.UseVisualStyleBackColor = true;
            this.BtDiv.Click += new System.EventHandler(this.BtDiv_Click);
            // 
            // Limpa
            // 
            this.Limpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Limpa.Location = new System.Drawing.Point(573, 95);
            this.Limpa.Name = "Limpa";
            this.Limpa.Size = new System.Drawing.Size(117, 50);
            this.Limpa.TabIndex = 7;
            this.Limpa.Text = "Limpar";
            this.Limpa.UseVisualStyleBackColor = true;
            this.Limpa.Click += new System.EventHandler(this.Limpa_Click);
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Fecha.Location = new System.Drawing.Point(573, 175);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(117, 50);
            this.Fecha.TabIndex = 8;
            this.Fecha.Text = "Fechar";
            this.Fecha.UseVisualStyleBackColor = true;
            this.Fecha.Click += new System.EventHandler(this.Fecha_Click);
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Num1.Location = new System.Drawing.Point(219, 105);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(309, 29);
            this.Num1.TabIndex = 9;
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Num2.Location = new System.Drawing.Point(219, 154);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(309, 29);
            this.Num2.TabIndex = 10;
            // 
            // Res
            // 
            this.Res.Enabled = false;
            this.Res.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Res.Location = new System.Drawing.Point(219, 196);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(309, 29);
            this.Res.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(799, 449);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Limpa);
            this.Controls.Add(this.BtDiv);
            this.Controls.Add(this.BtMult);
            this.Controls.Add(this.BtSub);
            this.Controls.Add(this.BtSoma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtSoma;
        private System.Windows.Forms.Button BtSub;
        private System.Windows.Forms.Button BtMult;
        private System.Windows.Forms.Button BtDiv;
        private System.Windows.Forms.Button Limpa;
        private System.Windows.Forms.Button Fecha;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.TextBox Res;
    }
}

