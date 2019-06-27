using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Requisitions
{
    public interface Resposta
    {
        void Responde(Requisition req, Conta conta);
        Resposta OutraResposta { get; set; }
    }
}
