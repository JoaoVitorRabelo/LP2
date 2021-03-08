using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        double ladoA, ladoB, ladoC;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtmFec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtmLim_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
        }

        private void BtmCal_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLadoA.Text, out ladoA) && double.TryParse(txtLadoB.Text, out ladoB) && double.TryParse(txtLadoC.Text, out ladoC))
            {
                if (Math.Sqrt((ladoB - ladoC) * (ladoB - ladoC)) < ladoA && ladoA < ladoB + ladoC &&
                   (Math.Sqrt((ladoA - ladoC) * (ladoA - ladoC)) < ladoB && ladoB < ladoA + ladoC &&
                   (Math.Sqrt((ladoA - ladoB) * (ladoA - ladoB)) < ladoC && ladoC < ladoA + ladoB)))
                {
                    if ((ladoA == ladoB) && (ladoB == ladoC))
                    {
                        MessageBox.Show("Equilátero.");
                    }
                    else
                    {
                        if ((ladoA != ladoB) && (ladoB != ladoC) && (ladoC != ladoA))
                        {
                            MessageBox.Show("Escaleno.");
                        }
                        else
                        {
                            MessageBox.Show("Isósceles.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Dados não formam um triangulo!");
                }
            }
            else
            {
                MessageBox.Show("São permitidos apenas números!");
            }
        }
    }
}
