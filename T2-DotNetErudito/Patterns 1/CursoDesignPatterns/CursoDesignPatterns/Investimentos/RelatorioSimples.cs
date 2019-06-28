using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class RelatorioSimples : TemplateRelatorios
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
        }

        protected override void Rodape()
        {
            Console.WriteLine("(47) 1234-5678");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Titular + " - " + c.Saldo);
            }
        }
    }
}
