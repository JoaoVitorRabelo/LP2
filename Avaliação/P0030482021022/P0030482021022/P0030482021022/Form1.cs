﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace P0030482021022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double[,] Valores = new double[6, 4];
            double[] TotalMes = new double[6];
            string valor;
            double totalMeses = 0;

            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    valor = Interaction.InputBox("Digite o valor da semana " + (y + 1) + " Do Mês: " + (x + 1), "Entrada de dados");
                    if (valor == "")
                    {
                        MessageBox.Show("Campo está vazio");
                        y--;
                    }
                    else if (double.TryParse(valor, out Valores[x, y]))
                    {
                        double.TryParse(valor, out Valores[x, y]);
                    }
                    else
                    {
                        MessageBox.Show("Digite apenas números!");
                        y--;
                    }
                }
            }

            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    TotalMes[x] = TotalMes[x] + Valores[x, y];
                }
                totalMeses = totalMeses + TotalMes[x];
            }

            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    lboxRes.Items.Add("Total do Mês: " + (x + 1) + " Semana: " + (y + 1) + ": R$" + Valores[x, y].ToString("N2"));
                }
                lboxRes.Items.Add(">>Total Mês: R$" + TotalMes[x].ToString("N2"));
                lboxRes.Items.Add("...............................");
            }
            lboxRes.Items.Add("Total Geral: R$" + totalMeses.ToString("N2"));
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lboxRes.Items.Clear();
        }
    }
}
