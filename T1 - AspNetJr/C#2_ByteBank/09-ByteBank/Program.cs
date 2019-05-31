using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.nome = "Guilherme";
            p.endereco.logradouro = "Avenida XYZ";

            Console.WriteLine(p.endereco.logradouro);
            Console.ReadLine();
        }
    }
}
