using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente Bruno = new Cliente();

            Bruno.nome = "Bruno";
            Bruno.profissao = "Policial";
            Bruno.cpf = "030.550.200.56";

            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = Bruno;
            contaDoBruno.agencia = 0101;
            contaDoBruno.numero = 123456;

            Console.WriteLine("Conta de " + contaDoBruno.titular.nome);
            Console.WriteLine("CPF: " + contaDoBruno.titular.cpf);
            Console.WriteLine("Profissão: " + contaDoBruno.titular.profissao);
            Console.WriteLine("");

            double valorSaqueBruno = 100;
            bool resultadoSaqueBruno = contaDoBruno.Sacar(valorSaqueBruno);

            Console.WriteLine("Efetuando saque de: " + valorSaqueBruno);
            Console.WriteLine("Saque Aprovado?  " + resultadoSaqueBruno);
            Console.WriteLine("Saldo: " + contaDoBruno.saldo);

            double valorDepositoBruno = 500;
            contaDoBruno.Depositar(valorDepositoBruno);
            Console.WriteLine("Efetuando Deposito de: " + valorDepositoBruno);
            Console.WriteLine("Saldo Final: " + contaDoBruno.saldo);
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("");

            Cliente Rubia = new Cliente();

            Rubia.nome = "Rubia";
            Rubia.profissao = "Aux. Administrativa";
            Rubia.cpf = "580.600.300.90";

            ContaCorrente contaDaRubia = new ContaCorrente();

            contaDaRubia.titular = Rubia;
            contaDaRubia.agencia = 0352;
            contaDaRubia.numero = 456;

            Console.WriteLine("Conta de " + contaDaRubia.titular.nome);
            Console.WriteLine("CPF: " + contaDaRubia.titular.cpf);
            Console.WriteLine("Profissão: " + contaDaRubia.titular.profissao);
            Console.WriteLine("");

            double valorSaque = 1500;
            bool resultadoSaque = contaDaRubia.Sacar(valorSaque);

            Console.WriteLine("Efetuando saque de: " + valorSaque);
            Console.WriteLine("Saque Aprovado?  " + resultadoSaque);
            Console.WriteLine("Saldo: " + contaDaRubia.saldo);

            double valorDeposito = 2270.80;
            contaDaRubia.Depositar(valorDeposito);
            Console.WriteLine("Efetuando Deposito de: " + valorDeposito);
            Console.WriteLine("Saldo Final: " + contaDaRubia.saldo);

            Console.ReadLine();
        }
    }
}
