using System;
using System.Collections.Generic;
using System.Text;
using CursoDesignPatterns.Investimentos;

namespace CursoDesignPatterns
{
    public class Convervador : Investimento
    {
        public double Calcula(Saldo saldo)
        {
            Console.WriteLine("Investimento com retorno de 0.8%:");
            return (saldo.Valor * 0.008);
        }
    }
}
