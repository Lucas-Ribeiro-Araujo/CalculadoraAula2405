using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora.Test
{
    class TesteCalculadora
    {
        [TestMethod]
        public void TesteAdicao()
        {
            Calculadora calc = new Calculadora(4, 2);
            double retornoEsperado = 6.0;
            double retornoFeito = calc.getAdicao();
            Assert.AreEqual(retornoEsperado, retornoFeito);
        }
    }
}
