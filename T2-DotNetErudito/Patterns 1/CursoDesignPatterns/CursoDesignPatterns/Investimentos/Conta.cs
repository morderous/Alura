using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Conta
    {
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}
