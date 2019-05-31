using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ByteBank_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaNum1 = new ContaCorrente(0121, 342509, 100.50);
            Console.WriteLine("Contas Criadas até o momento:   " + ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine("Agencia: " + contaNum1.Agencia);
            Console.WriteLine("C/C:     " + contaNum1.Conta);
            Console.WriteLine("Saldo:   " + contaNum1.Saldo);
            Console.WriteLine("------------------------------------------------------------------------");

            ContaCorrente contaNum2 = new ContaCorrente(0099, 19994, 340.98);
            Console.WriteLine("Contas Criadas até o momento:   " + ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine("Agencia: " + contaNum2.Agencia);
            Console.WriteLine("C/C:     " + contaNum2.Conta);
            Console.WriteLine("Saldo:   " + contaNum2.Saldo);
            Console.WriteLine("------------------------------------------------------------------------");

            ContaCorrente contaNum3 = new ContaCorrente(444, 000023, 9340.00);
            Console.WriteLine("Contas Criadas até o momento:   " + ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine("Agencia: " + contaNum3.Agencia);
            Console.WriteLine("C/C:     " + contaNum3.Conta);
            Console.WriteLine("Saldo:   " + contaNum3.Saldo);

            Console.ReadLine();
        }
    }
}
