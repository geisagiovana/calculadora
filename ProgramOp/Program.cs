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

            Operacao operacao;
            Decimal valor1 = 0;
            bool valorValido = false;
            Char sinal = ' ';
            Decimal valor2= 0;
            while (!valorValido)
            {
                Console.WriteLine("Enter valor1: ");


                try
                {
                    valor1 = Convert.ToDecimal(Console.ReadLine());
                    valorValido = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Operação Inválida: Digite apenas números.");
                    valorValido = false;
                }
            }
            valorValido = false;
            while (!valorValido)
            {
                Console.WriteLine("Enter sinal: ");
                try
                {
                    valorValido = true;
                    sinal = Convert.ToChar(Console.ReadLine());
                    if (sinal.CompareTo('+') != 0 && sinal.CompareTo('c') != 0)
                    {
                        throw new OperacaoException();
                    }
                      
                }
                catch (FormatException e)
                {
                   
                    Console.WriteLine("Operação Inválida: Digite apenas operações.");
                    valorValido = false;
                }
                catch(OperacaoException e)
                {
                    valorValido = false;
                    Console.WriteLine("Sinal inválido.");
                }
            }
            Console.WriteLine("Enter valor2: ");
            valor2 = Convert.ToDecimal(Console.ReadLine());

            operacao = new Operacao(sinal, valor1, valor2);

            Console.WriteLine("Resultado: {0} ", operacao.getResultado());

            Console.ReadKey();
            

        }

    }
}
