using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ICCC : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000.00)
            {
                Console.WriteLine("5% de imposto:");
                return orcamento.Valor * 0.05 + CalculaoDoOutroImposto(orcamento);
            }
            if (orcamento.Valor >= 1000.00 && orcamento.Valor <= 3000.00)
            {
                Console.WriteLine("7% de imposto:");
                return orcamento.Valor * 0.07 + CalculaoDoOutroImposto(orcamento);
            }
            Console.WriteLine("8% de imposto: R$ 30.00:");
            return orcamento.Valor * 0.08 + CalculaoDoOutroImposto(orcamento) + 30;
        }

        public ICCC(Imposto outroImposto) : base(outroImposto) { }
        public ICCC() { }
    }
}
