using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CursoDesignPatterns.Impostos
{
    public class DescontoPorMaisDeQuinhentosReais : Desconto
    {
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }

            return Proximo.Desconta(orcamento);

        }

        public Desconto Proximo { get; set; }
    }
}
