﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBank
{
    class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; }
        public LeitorDeArquivo(string arquivo)

        {
            Arquivo = arquivo;
            //throw new FileNotFoundException();
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");
            return "Linha do arquivo";
        }
        public void Dispose()
        {
            Console.WriteLine("Fechando Arquivo.");
        }
    }
}
