﻿using System;

namespace CursoDesignPatterns.NotaFiscal
{
    public class ItemDaNota
    {
        public ItemDaNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; set; }
        public  double Valor { get; set; }
    }
}