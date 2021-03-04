using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        double nu1, nu2, resultado;

        public Form1()
        {
            InitializeComponent();
        }


        private void BtSoma_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(Num1.Text, out nu1) || !double.TryParse(Num2.Text, out nu2))
                MessageBox.Show("Valores inválidos");

            else
            {
                resultado = nu1 + nu2;
                Res.Text = resultado.ToString("N2");
            }
        }
        private void BtMult_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(Num1.Text, out nu1) || !double.TryParse(Num2.Text, out nu2))
            MessageBox.Show("Valores inválidos");
            else
            {
                resultado = nu1 * nu2;
                Res.Text = resultado.ToString("N2");
            }
        }            
        private void BtDiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Num1.Text, out nu1) || !double.TryParse(Num2.Text, out nu2))
                if (nu2 == 0)
                {
                    MessageBox.Show("Valores inválidos");
                }
                else
                {
                    resultado = nu1 / nu2;
                    Res.Text = resultado.ToString("N2");
                }
            else
                MessageBox.Show("Valores inválidos");
        }

        private void BtSub_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(Num1.Text, out nu1) || !double.TryParse(Num2.Text, out nu2))
                MessageBox.Show("Valores inválidos");

            else
            {
                resultado = nu1 - nu2;
                Res.Text = resultado.ToString("N2");
            }
        }

        private void Limpa_Click(object sender, EventArgs e)
        {
            Num1.Clear();
            Num2.Clear();
            Res.Clear();
            Num1.Focus();
        }
        private void Fecha_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
