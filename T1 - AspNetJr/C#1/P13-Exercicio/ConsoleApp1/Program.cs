using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Programa
    {
        static void Main(String[] args)
        {
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if ( linha < coluna )
                    {
                        break;
                    }
                    Console.Write(coluna +1);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
