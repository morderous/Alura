using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class Moderado : Investimento 
    {
        public double Calcula(Conta conta)
        {
            int escolhido = new Random().Next(101);
            if (escolhido <= 50)
            {
                Console.WriteLine("Investimento com retorno de 2.5%:");
                return conta.Saldo * 0.025;
            }
            Console.WriteLine("Investimento com retorno de 0.7%:");
            return conta.Saldo * 0.007;
        }
    }
}
