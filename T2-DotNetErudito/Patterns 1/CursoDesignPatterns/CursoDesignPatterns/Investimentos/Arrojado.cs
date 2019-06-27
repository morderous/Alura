using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class Arrojado : Investimento
    {
        public double Calcula(Conta conta)
        {
            int escolhido = new Random().Next(101);
            if (escolhido <= 20)
            {
                Console.WriteLine("Investimento com retorno de 5%:");
                return conta.Saldo * 0.05;
            }

            if (escolhido > 20 && escolhido <= 50)
            {
                Console.WriteLine("Investimento com retorno de 3%:");
                return conta.Saldo * 0.03;
            }
            Console.WriteLine("Investimento com retorno de 0.6%:");
            return conta.Saldo * 0.006;
        }

    }
}
