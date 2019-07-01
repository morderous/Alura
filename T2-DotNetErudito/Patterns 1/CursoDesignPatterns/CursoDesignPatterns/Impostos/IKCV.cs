using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Impostos
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue100Reais(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.15 + CalculaoDoOutroImposto(orcamento);
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculaoDoOutroImposto(orcamento);
        }

         private bool TemItemMaiorQue100Reais(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100)
                {
                    return true;
                }
            }
            return false;
        }

         public IKCV(Imposto outroImposto) : base(outroImposto) { }
         public IKCV() { }
    }
}
