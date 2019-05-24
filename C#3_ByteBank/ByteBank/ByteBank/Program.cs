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
            Funcionario Carlos = new Funcionario();

            Carlos.Nome = "Carlos Alberto Koehler";
            Carlos.CPF = "030.368.369-15";
            Carlos.Salario = 3140.70;

            Console.WriteLine(Carlos.GetBonificacao());

            Console.ReadLine();
        }
    }
}
