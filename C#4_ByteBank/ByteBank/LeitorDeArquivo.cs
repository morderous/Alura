using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class LeitorDeArquivo
    {
        public string Arquivo { get; }
        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");
            return "Linha do arquivo";
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando Arquivo.");
        }
    }
}
