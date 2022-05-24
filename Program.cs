using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            ConsoleRenderer ren = new ConsoleRenderer(calc);
            ren.run();
        }


    }
    class ConsoleRenderer
    {
        Calculadora calc;

        public ConsoleRenderer(Calculadora calc)
        {
            this.calc = calc;
        }
        public void run()
        {

            Console.WriteLine("Bem vindo a calculadora digital dos guri. \n" +
                "Digite um numero para começar: ");
            calc.valorA = Double.Parse(Console.ReadLine());
            UpdateTerm();

            Console.WriteLine("Digite um segundo numero: ");
            calc.valorB = Double.Parse(Console.ReadLine());
            UpdateTerm();

            while (true)
            {
                SelectOption();
            }

            Console.ReadLine();
        }

        public void UpdateTerm()
        {
            Console.Clear();
            Console.WriteLine($"ValorA:{calc.valorA}");
            Console.WriteLine($"ValorB:{calc.valorB}");
        }

        public void SelectOption()
        {
            double result = 0;


            Console.WriteLine("Escholha uma operação para realizar entre os dois valores: \n" +
                "1 - Adição \n" +
                "2 - Subtração \n" +
                "3 - Produto \n" +
                "4 - Divisão \n" +
                "0 - Fechar programa");
            int opt = int.Parse(Console.ReadLine());
            switch (opt) {
                case 1: result = calc.getAdicao();
                    break;
                case 2: result = calc.getSubtracao();
                    break;
                case 3: result = calc.getProduto();
                    break;
                case 4: result = calc.getDivisao();
                    break;
                default: Environment.Exit(0);
                    break;
            }

            UpdateTerm();
            Console.WriteLine($"Seu resultado: {result}");
        }
    }
}
