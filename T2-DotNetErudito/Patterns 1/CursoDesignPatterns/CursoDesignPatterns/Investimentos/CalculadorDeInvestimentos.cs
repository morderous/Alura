using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    class CalculadorDeInvestimentos
    {
        public void RealizaCalculo(Saldo saldo, Investimento investimento)
        {
            double valor = investimento.Calcula(saldo);
            Console.WriteLine(valor);
        }
    }
}