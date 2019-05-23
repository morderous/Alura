using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa guilherme = new Pessoa();
            guilherme.endereco = new Endereco();
            guilherme.nome = "Guilherme";
            guilherme.endereco.logradouro = "Avenida XYZ";
            guilherme.endereco.bairro = "Tapajós";

            Console.WriteLine(guilherme.nome);
            Console.WriteLine(guilherme.endereco.bairro);
            Console.WriteLine(guilherme.endereco.logradouro);
            Console.ReadLine();
        }
    }
}
