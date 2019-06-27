using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            Console.WriteLine("5% de imposto + R$ 50.00:");
            return (orcamento.Valor * 0.05) + 50;
        }
    }
}
