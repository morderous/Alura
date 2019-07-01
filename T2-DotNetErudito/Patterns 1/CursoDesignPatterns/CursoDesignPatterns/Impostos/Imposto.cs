using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public abstract class Imposto
    {

        public Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculaoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null)
            {
                return 0;
            }
            return OutroImposto.Calcula(orcamento);
        }

        public Imposto()
        {
            this.OutroImposto = null;
        }
    }
}
