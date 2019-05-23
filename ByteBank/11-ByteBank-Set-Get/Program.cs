using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ByteBank_Set_Get
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente Bruno = new Cliente();
            Bruno.CPF = "129000000019011";
            Console.WriteLine(Bruno.CPF);
            Console.ReadLine();
        }
    }
}
