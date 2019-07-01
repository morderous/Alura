using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Impostos
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        protected TemplateDeImpostoCondicional(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        protected TemplateDeImpostoCondicional()
        {
            this.OutroImposto = null;
        }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }
    

        public abstract bool DeveUsarMaximaTaxacao (Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
