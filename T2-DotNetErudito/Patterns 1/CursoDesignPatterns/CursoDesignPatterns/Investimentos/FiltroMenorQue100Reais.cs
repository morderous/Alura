using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class FiltroMenorQue100Reais : Filtro
    {
        public FiltroMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro) { }

        public FiltroMenorQue100Reais() : base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach (Conta c in contas)
            {
                if (c.Saldo < 100) filtrada.Add(c);
            }
            foreach (Conta c in Proximo(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;
        }
    }
}
