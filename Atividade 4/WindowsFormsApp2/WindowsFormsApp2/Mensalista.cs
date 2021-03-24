using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Mensalista : Empregado
    {
        public Mensalista()
        {

        }
        public Mensalista(int matx, string nomex, DateTime datax, double salariox)
        {
            Matricula = matx;
            NomeEmpregado = nomex;
            DataEntradaEmpresa = datax;
            SalarioMensal = salariox;
        }
        public double SalarioMensal { get; set; }
        public override double SalarioBruto()
        {
            return SalarioMensal;
        }

    }
}
