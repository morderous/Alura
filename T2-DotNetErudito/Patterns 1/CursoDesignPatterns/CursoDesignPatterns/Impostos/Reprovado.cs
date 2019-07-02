using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Impostos
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados não recebem desconto extra");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja está reprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja está reprovado, não pode ser reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
