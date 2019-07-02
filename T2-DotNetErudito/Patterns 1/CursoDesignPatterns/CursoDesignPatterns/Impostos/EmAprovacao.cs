using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Impostos
{
    public class EmAprovacao : EstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
                descontoAplicado = true;
            }
            throw new Exception("Desconto já aplicado!");
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento em aprovação não pode ir direto para finalizado");
        }
    }
}
