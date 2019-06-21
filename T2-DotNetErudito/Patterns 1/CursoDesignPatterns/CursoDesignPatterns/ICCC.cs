using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000.00)
            {
                return orcamento.Valor * 0.05;
            }
            else if (orcamento.Valor >= 1000.00 && orcamento.Valor <= 3000.00)
            {
                return orcamento.Valor * 0.07;
            }
            else
            {
                return orcamento.Valor * 0.08 + 30;
            }
        }
    }
}
