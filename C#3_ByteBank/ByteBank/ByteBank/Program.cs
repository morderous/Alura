using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario Carlos = new Funcionario("030.368.369-15");

            Carlos.Nome = "Carlos Alberto Koehler";
            Carlos.Salario = 3140.70;
            gerenciador.Registrar(Carlos);

            Diretor Roberta = new Diretor("454.658.148-32");
            Roberta.Nome = "Roberta Mathiussi";
            Roberta.Salario = 5000;
            gerenciador.Registrar(Roberta);

            Console.WriteLine(Carlos.Nome);
            Console.WriteLine(Carlos.GetBonificacao());
            Console.WriteLine(Roberta.Nome);
            Console.WriteLine(Roberta.GetBonificacao());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Total de bonificações consedidas: " + gerenciador.GetTotalBonificacao());
            Console.WriteLine("Total de Funcionários: " + Funcionario.TotalDeFuncionarios);


            Console.ReadLine();
        }
    }
}
