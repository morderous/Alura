using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Impostos
{
    public class ImpostoMuitoAlto : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.2) + CalculaoDoOutroImposto(orcamento);
        }

        public ImpostoMuitoAlto(Imposto outroImposto) : base(outroImposto) { }

        public ImpostoMuitoAlto() { }
    }
}

