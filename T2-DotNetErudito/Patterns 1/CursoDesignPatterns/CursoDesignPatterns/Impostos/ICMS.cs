using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ICMS : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50 + CalculaoDoOutroImposto(orcamento);
        }

        public ICMS(Imposto outroImposto) : base(outroImposto) { }

        public ICMS() { }
    }
}
