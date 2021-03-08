using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        double pes, alt, resultado;
        bool sexx;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void limpaSapora_Click(object sender, EventArgs e)
        {
            txtSex.Clear();
            txtAlt.Clear();
            txtPes.Clear();
            txtIdeal.Clear();
        }

        private void saiDesgraça_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPes.Text, out pes) || !double.TryParse(txtAlt.Text, out alt))
            {
                MessageBox.Show("Valores Inválidos");
            }
            if (txtSex.Text == ("F"))
            {
                resultado = (62.1 * alt) - 44.7;
                txtIdeal.Text = resultado.ToString("N2");

                if (pes < resultado)
                    MessageBox.Show("Abaixo do peso ideal");
                else
                {
                    if (pes > resultado)
                        MessageBox.Show("Acima do peso ideal");
                    else
                        MessageBox.Show("Exatamente no peso ideal");
                }
            }
            else if (txtSex.Text == ("M"))
            {
                resultado = (72.7 * alt) - 58;
                txtIdeal.Text = resultado.ToString("N2");

                if (pes < resultado)
                    MessageBox.Show("Abaixo do peso ideal");
                else
                {
                    if (pes > resultado)
                        MessageBox.Show("Acima do peso ideal");
                    else
                        MessageBox.Show("Exatamente no peso ideal"); 
                }
            }
            else
            {
                MessageBox.Show("Inválido");
            }
            
        }
    }
}
