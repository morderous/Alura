using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;
            for (int num = 1; num <= 10; num++)
            {
                fatorial *= num;
                Console.WriteLine(num + " fatorial= " + fatorial);

            }
            Console.ReadLine();

            
        }
    }
}
