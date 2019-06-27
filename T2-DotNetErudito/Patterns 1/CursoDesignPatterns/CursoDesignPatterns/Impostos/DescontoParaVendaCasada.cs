using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace CursoDesignPatterns.Impostos
{
    public class DescontoParaVendaCasada : Desconto
    {

        bool Existe(Orcamento orcamento)
        {
             bool lapis = false;
             bool caneta = false;
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Contains("Lapis"))
                    lapis = true;
                if (item.Nome.Contains("Caneta"))
                    caneta = true;
                if (caneta && lapis) return true;
            }
            return false;
        }

        public double Desconta(Orcamento orcamento)
        {
            if (Existe(orcamento))
            {
            return orcamento.Valor * 0.05;
            }
            return Proximo.Desconta(orcamento);
            
        }
        

        public Desconto Proximo { get; set; }
    }
}
