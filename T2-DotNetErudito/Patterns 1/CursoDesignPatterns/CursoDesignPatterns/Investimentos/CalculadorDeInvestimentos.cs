using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    class CalculadorDeInvestimentos
    {
        public void RealizaCalculo(Conta conta, Investimento investimento)
        {
            double valor = investimento.Calcula(conta);
            Console.WriteLine(valor);
        }
    }
}