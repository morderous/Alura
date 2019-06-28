using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Conta
    {
        public string Titular { get; private set; }
        public double Saldo { get; private set; }
        public string Agencia { get; private set; }
        public string Numero { get; private set; }

        public Conta(string titular, double saldo, string agencia, string numero)
        {
            this.Titular = titular;
            this.Saldo = saldo;
            this.Agencia = agencia;
            this.Numero = numero;
        }
    }
}
