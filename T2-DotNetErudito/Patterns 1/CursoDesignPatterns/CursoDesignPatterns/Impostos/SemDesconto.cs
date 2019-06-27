using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Impostos
{
    public class SemDesconto : Desconto
    {
        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }

        public  Desconto Proximo { get; set; }
    }
}
