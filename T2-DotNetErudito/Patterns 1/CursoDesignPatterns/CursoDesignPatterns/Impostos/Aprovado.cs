using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Impostos
{
    public  class Aprovado : EstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoAplicado = true;
            }
            throw new Exception("Desconto já aplicado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja está aprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja está aprovado, não pode ser reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
