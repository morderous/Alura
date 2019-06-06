using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
            var fulano = new Cliente();
            fulano.Nome = "Lucas Alexandre Hübes";
            fulano.EnderecoDeEntrega = new Endereco()
            {
                Numero = 12,
                Logradouro = "Rua Ribeirão das Pedras",
                Complemento = "Casa",
                Bairro = "Tapajós",
                Cidade = "Indaial"
            };

            using (var contexto = new LojaContext())
            {
                contexto.Clientes.Add(fulano);
                contexto.SaveChanges();
            }
        


            Console.ReadLine();
        }

        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            foreach (var e in entries)
            {
                Console.WriteLine(e.Entity.ToString() + " - " + e.State);
            }

        }
        private static void MuitosParaMuitos()
        {
            var p1 = new Produto() { Categoria = "Frutas", Nome = "Laranja", PrecoUnitario = 8.79, Unidade = "kg" };
            var p2 = new Produto() { Categoria = "Bebidas", Nome = "Suco de Laranja", PrecoUnitario = 15.53, Unidade = "Litros" };
            var p3 = new Produto() { Categoria = "Enlatados", Nome = "Lata de Feijão", PrecoUnitario = 6.99, Unidade = "Litros" };



            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Pascoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);

            promocaoDePascoa.IncluiProduto(p1);
            promocaoDePascoa.IncluiProduto(p2);
            promocaoDePascoa.IncluiProduto(p3);

            using (var contexto = new LojaContext())
            {
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                //contexto.Promocoes.Add(promocaoDePascoa);
                //ExibeEntries(contexto.ChangeTracker.Entries());
                var produtos = contexto.Produtos.Find(4003);
                contexto.Produtos.Remove(produtos);
                ExibeEntries(contexto.ChangeTracker.Entries());
                contexto.SaveChanges();
            }
        }
    }
}
