using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ByteBank_Set_Get
{
    class ContaCorrente
    {
        private int _agencia;
        private int _conta;
        private double _saldo;
        private Cliente _titular;

       public Cliente Titular { get; set; }
    }
}
