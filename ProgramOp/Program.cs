using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1 Hello World 
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            *//*2 Somar
            Operacao operacao = new Operacao();
            int valor = operacao.somar(2, 2);
            Console.WriteLine("Resultado:"+ valor);
            // Keep the console window open in debug mode.
             Console.ReadKey();
            */
            /* 3 Calcular area circulo
            Operacao operacao = new Operacao();
            Console.WriteLine("Enter Radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double areaCirculo = operacao.converter(r);
            Console.WriteLine("Radius: " + r + " Area: " + areaCirculo);
            Console.ReadKey();

            */
            Operacao operacao;

            Console.WriteLine("Enter valor1: ");
            Decimal valor1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter sinal: ");
            Char sinal = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter valor2: ");
            Decimal valor2 = Convert.ToDecimal(Console.ReadLine());

            operacao = new Operacao(sinal, valor1, valor2);

            Console.WriteLine("Resultado: 5 {0} ", operacao.getResultado());

            Console.ReadKey();

        }

    }
}
