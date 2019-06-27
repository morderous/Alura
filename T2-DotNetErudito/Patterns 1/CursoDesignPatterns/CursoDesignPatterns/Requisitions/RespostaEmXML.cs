using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Requisitions
{
    public class RespostaEmXml : Resposta
    {
        public Resposta OutraResposta { get; set; }

        public RespostaEmXml(Resposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public RespostaEmXml()
        {
            this.OutraResposta = null;
        }

        public void Responde(Requisition req, Conta conta)
        {
            if (req.Formato == Formato.Xml)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else if (OutraResposta != null)
            {
                OutraResposta.Responde(req, conta);
            }
            throw new Exception("Formato de resposta não encontrado");

        }

    }
}
