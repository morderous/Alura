using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ByteBank_Constructor
{
    class ContaCorrente
    {
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public double Saldo { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        public ContaCorrente(int ag, int numero, double saldo)
        {
            Agencia = ag;
            Conta = numero;
            Saldo = saldo;
            TotalDeContasCriadas ++;
        }
        
    }
}
