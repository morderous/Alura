using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Impostos
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos finalizados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento já finalizado");
        }
    }
}
