using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class FiltroMesmoMes : Filtro
    {
        public FiltroMesmoMes(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public FiltroMesmoMes() : base()
        {
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach (Conta c in contas)
            {
                if (c.DataAbertura.Month == DateTime.Now.Month &&
                    c.DataAbertura.Year == DateTime.Now.Year)
                {
                    filtrada.Add(c);
                }
            }

            foreach (Conta c in Proximo(contas))
            {
                filtrada.Add(c);
            }

            return filtrada;
        }
    }
}
