﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new LojaContext())
            {
                var produtos = contexto.Produtos.ToList();

                ExibeEntries(contexto.ChangeTracker.Entries());

                var novoProduto = new Produto()
                {
                    Nome = "Kaiak",
                    Categoria = "Perfume",
                    Preco = 99.50
                };
                contexto.Produtos.Add(novoProduto);

                ExibeEntries(contexto.ChangeTracker.Entries());

                contexto.Produtos.Remove(novoProduto);

                ExibeEntries(contexto.ChangeTracker.Entries());

                //contexto.SaveChanges();

                var entry = contexto.Entry(novoProduto);
                Console.WriteLine("\n\n" + entry.Entity.ToString() + " - " + entry.State);

            }

            Console.WriteLine("                  ...feito...                ");
            Console.ReadLine();
        }

        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            Console.WriteLine("==============================");
            foreach (var e in entries)
            {
                Console.WriteLine(e.Entity.ToString() + "-" + e.State);
            }
        }
    }
}
