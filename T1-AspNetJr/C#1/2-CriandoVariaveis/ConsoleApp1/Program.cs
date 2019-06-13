using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Programa
    {
        static void Main(string[] args)
        {
            double salario = 3300.00;

            if (salario >= 1900.00 && salario <= 2800.00)
            {
                Console.WriteLine("Pode ser deduzido até R$ 142.00.");
                Console.WriteLine("I.R de 7.5%.");
            }
            if (salario >= 2801.00 && salario <= 3751.00)
            {
                Console.WriteLine("Pode ser deduzido até R$ 350.00.");
                Console.WriteLine("I.R de 15%.");
            }
            if (salario >= 3751.00 && salario <= 4664.00)
            {
                Console.WriteLine("Pode ser deduzido até R$ 636.00.");
                Console.WriteLine("I.R de 22.5%.");
            }


        }
    }
}
