using System;
using System.Collections.Generic;
using System.Text;
using CursoDesignPatterns.Investimentos;

namespace CursoDesignPatterns
{
    public class Conta
    {
        public string Titular { get; private set; }
        public double Saldo { get; set; }
        public string Agencia { get; private set; }
        public string Numero { get; private set; }
        public DateTime DataAbertura { get; private set; }
        public EstadoDaConta Estado { get; set; }

        public Conta(string titular, double saldo, string agencia, string numero, DateTime dataAbertura)
        {
            this.Titular = titular;
            this.Saldo = saldo;
            this.Agencia = agencia;
            this.Numero = numero;
            this.DataAbertura = dataAbertura;
            this.Estado = new Positivo();
        }

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
        }
    }
}
