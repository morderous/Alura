using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Requisitions
{
    public class RespostaEmPorcento : Resposta
    {
        public Resposta OutraResposta { get; set; }

        public RespostaEmPorcento(Resposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public RespostaEmPorcento()
        {
            this.OutraResposta = null;
        }

        public void Responde(Requisition req, Conta conta)
        {
            if (req.Formato == Formato.Porcento)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else if (OutraResposta != null)
            {
                OutraResposta.Responde(req, conta);
            }
            throw new Exception("Formato de resposta não encontrado");

        }

    }
}
