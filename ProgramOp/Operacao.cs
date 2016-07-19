using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOp
{
    class Operacao
    {
        const double pi = 3.14159;

        private Char sinal;

        private Decimal valor1;

        private Decimal valor2;

        private Decimal resultado;

        public Operacao(Char sinal, Decimal valor1, Decimal valor2)
        {
            this.sinal = sinal;
            this.valor1 = valor1;
            this.valor2 = valor2;

            switch (sinal)
            {
                case '+':
                    {
                        somar();
                        break;
                    }
                case 'r':
                    {
                        converterParaAreaDoCirculo();
                        break;
                    }
            }
        }

        public Decimal somar()
        {
           return this.resultado = valor1 + valor2;
        }

        //Converte o valor1 para o valor da area do circulo
        public void converterParaAreaDoCirculo()
        {
            this.resultado = Convert.ToDecimal(pi * Convert.ToDouble(valor1) * Convert.ToDouble(valor1));
        }

        public Char getSinal()
        {
            return sinal;
        }

        public void setSinal(Char sinal)
        {
            this.sinal = sinal;
        }

        public Decimal getValor1()
        {
            return valor1;
        }

        public void setValor1(Decimal valor1)
        {
            this.valor1 = valor1;
        }

        public Decimal getValor2()
        {
            return valor2;
        }

        public void setValor2(Decimal valor2)
        {
            this.valor2 = valor2;
        }

        public Decimal getResultado()
        {
            return resultado;
        }

        public void setResultado(Decimal resultado)
        {
            this.resultado = resultado;
        }

    }
}