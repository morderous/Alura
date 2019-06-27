using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ISS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            Console.WriteLine("6% de imposto:");
            return orcamento.Valor * 0.06;
        }
    }
}
