using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class Arrojado : Investimento
    {
        public double Calcula(Saldo saldo)
        {
            int escolhido = new Random().Next(101);
            if (escolhido <= 20)
            {
                Console.WriteLine("Investimento com retorno de 5%:");
                return saldo.Valor * 0.05;
            }

            if (escolhido > 20 && escolhido <= 50)
            {
                Console.WriteLine("Investimento com retorno de 3%:");
                return saldo.Valor * 0.03;
            }
            Console.WriteLine("Investimento com retorno de 0.6%:");
            return saldo.Valor * 0.006;
        }

    }
}
