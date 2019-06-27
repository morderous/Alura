using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Saldo
    {
        public double Valor { get; private set; }

        public Saldo(double valor)
        {
            this.Valor = valor;
        }
    }
}
