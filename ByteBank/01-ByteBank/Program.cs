using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela Voss";
            contaDaGabriela.numero = 123;
            contaDaGabriela.agencia = 1;
            contaDaGabriela.saldo = 1529.30;
            Console.WriteLine(contaDaGabriela.titular);
            Console.ReadLine();
        }
    }
}
