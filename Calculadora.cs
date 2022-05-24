using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        public double valorA;
        public double valorB;

        public Calculadora()
        {
            valorA = 0;
            valorB = 0;
        }

        public Calculadora(double a, double b)
        {
            valorA = a;
            valorB = b;
        }

        public double getAdicao()
        {
            return valorA + valorB;
        }

        public double getSubtracao()
        {
            return valorA - valorB;
        }

        public double getProduto()
        {
            return valorA * valorB;
        }

        public double getDivisao()
        {
            return valorA / valorB;
        }
    }
}
