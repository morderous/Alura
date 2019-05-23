using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoAndre = new ContaCorrente();
            contaDoAndre.titular = new Cliente();

            contaDoAndre.titular.nome = "Andre Huebes";
        }
    }
}
