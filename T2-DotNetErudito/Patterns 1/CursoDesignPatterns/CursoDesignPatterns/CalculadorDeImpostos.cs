using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            {
                double valor = imposto.Calcula(orcamento);
                Console.WriteLine(valor);
            }
        }
    }
}
