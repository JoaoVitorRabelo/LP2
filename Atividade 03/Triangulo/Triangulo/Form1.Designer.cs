
namespace Triangulo
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
            this.BtmFec = new System.Windows.Forms.Button();
            this.BtmLim = new System.Windows.Forms.Button();
            this.BtmCal = new System.Windows.Forms.Button();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.Lab1 = new System.Windows.Forms.Label();
            this.Lab2 = new System.Windows.Forms.Label();
            this.Lab3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtmFec
            // 
            this.BtmFec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtmFec.Location = new System.Drawing.Point(484, 119);
            this.BtmFec.Name = "BtmFec";
            this.BtmFec.Size = new System.Drawing.Size(90, 29);
            this.BtmFec.TabIndex = 0;
            this.BtmFec.Text = "Fechar";
            this.BtmFec.UseVisualStyleBackColor = true;
            this.BtmFec.Click += new System.EventHandler(this.BtmFec_Click);
            // 
            // BtmLim
            // 
            this.BtmLim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtmLim.Location = new System.Drawing.Point(484, 168);
            this.BtmLim.Name = "BtmLim";
            this.BtmLim.Size = new System.Drawing.Size(90, 29);
            this.BtmLim.TabIndex = 1;
            this.BtmLim.Text = "Limpar";
            this.BtmLim.UseVisualStyleBackColor = true;
            this.BtmLim.Click += new System.EventHandler(this.BtmLim_Click);
            // 
            // BtmCal
            // 
            this.BtmCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtmCal.Location = new System.Drawing.Point(484, 217);
            this.BtmCal.Name = "BtmCal";
            this.BtmCal.Size = new System.Drawing.Size(90, 29);
            this.BtmCal.TabIndex = 2;
            this.BtmCal.Text = "Calcular";
            this.BtmCal.UseVisualStyleBackColor = true;
            this.BtmCal.Click += new System.EventHandler(this.BtmCal_Click);
            // 
            // txtLadoA
            // 
            this.txtLadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtLadoA.Location = new System.Drawing.Point(220, 119);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(242, 29);
            this.txtLadoA.TabIndex = 3;
            // 
            // txtLadoC
            // 
            this.txtLadoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtLadoC.Location = new System.Drawing.Point(220, 217);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(242, 29);
            this.txtLadoC.TabIndex = 4;
            // 
            // txtLadoB
            // 
            this.txtLadoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtLadoB.Location = new System.Drawing.Point(220, 168);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(242, 29);
            this.txtLadoB.TabIndex = 5;
            // 
            // Lab1
            // 
            this.Lab1.AutoSize = true;
            this.Lab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Lab1.Location = new System.Drawing.Point(82, 124);
            this.Lab1.Name = "Lab1";
            this.Lab1.Size = new System.Drawing.Size(70, 24);
            this.Lab1.TabIndex = 6;
            this.Lab1.Text = "Lado A";
            // 
            // Lab2
            // 
            this.Lab2.AutoSize = true;
            this.Lab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Lab2.Location = new System.Drawing.Point(82, 173);
            this.Lab2.Name = "Lab2";
            this.Lab2.Size = new System.Drawing.Size(69, 24);
            this.Lab2.TabIndex = 7;
            this.Lab2.Text = "Lado B";
            // 
            // Lab3
            // 
            this.Lab3.AutoSize = true;
            this.Lab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Lab3.Location = new System.Drawing.Point(82, 222);
            this.Lab3.Name = "Lab3";
            this.Lab3.Size = new System.Drawing.Size(70, 24);
            this.Lab3.TabIndex = 8;
            this.Lab3.Text = "Lado C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lab3);
            this.Controls.Add(this.Lab2);
            this.Controls.Add(this.Lab1);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.BtmCal);
            this.Controls.Add(this.BtmLim);
            this.Controls.Add(this.BtmFec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtmFec;
        private System.Windows.Forms.Button BtmLim;
        private System.Windows.Forms.Button BtmCal;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.Label Lab1;
        private System.Windows.Forms.Label Lab2;
        private System.Windows.Forms.Label Lab3;
    }
}

