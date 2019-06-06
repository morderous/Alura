using Microsoft.EntityFrameworkCore;
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
            using (var contexto = new LojaContext())
            {
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                //var cliente = contexto.Clientes.Include(c => c.EnderecoDeEntrega).FirstOrDefault();

                //Console.WriteLine($"Endereço de entrega: {cliente.EnderecoDeEntrega.Logradouro}");

                //var produto = contexto.Produtos.Where(p => p.Id == 4002).FirstOrDefault();

                //contexto.Entry(produto).Collection(p => p.Compras).Query().Where(c => c.Preco > 1).Load();

                //Console.WriteLine($"Mostrando compras do produto {produto.Nome}");
                //foreach (var item in produto.Compras)
                //{
                //    Console.WriteLine("\t" + item);
                //}

                var produto = contexto.Produtos.Where(p => p.Id == 6003).FirstOrDefault();
                var compra = new Compra();
                compra.Produto = produto;
                compra.Quantidade = 100;
                compra.Preco = produto.PrecoUnitario * compra.Quantidade;
                contexto.Add(compra);
                ExibeEntries(contexto.ChangeTracker.Entries());

                contexto.SaveChanges();
            }

            Console.ReadLine();
        }

        private static void ExibeProdutosDaPromocao()
        {
            using (var contexto2 = new LojaContext())
            {
                var serviceProvider = contexto2.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                var promocao = contexto2.Promocoes.Include(p => p.Produtos).ThenInclude(pp => pp.Produto).FirstOrDefault();
                Console.WriteLine("\nMostrando os produtos da promoção... ");
                foreach (var item in promocao.Produtos)
                {
                    Console.WriteLine(item.Produto);
                }
            }
        }

        private static void IncluirPromocao()
        {
            using (var contexto = new LojaContext())
            {
                

                var promocao = new Promocao();
                promocao.Descricao = "Queima total de Janeiro";
                promocao.DataInicio = new DateTime(2017, 1, 1);
                promocao.DataTermino = new DateTime(2017, 1, 31);

                var produtos = contexto.Produtos.Where(p => p.Categoria == "Bebidas").ToList();
                foreach (var item in produtos)
                {
                    promocao.IncluiProduto(item);
                }
                contexto.Promocoes.Add(promocao);

                ExibeEntries(contexto.ChangeTracker.Entries());

                contexto.SaveChanges();

            }
        }

        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            foreach (var e in entries)
            {
                Console.WriteLine(e.Entity.ToString() + " - " + e.State);
            }

        }
        private static void UmParaUm()
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
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                contexto.Clientes.Add(fulano);
                contexto.SaveChanges();
            }
        }
        private static void MuitosParaMuitos()
        {
            var p1 = new Produto() { Categoria = "Bebidas", Nome = "Guaraná Jesus", PrecoUnitario = 5.79, Unidade = "kg" };
            var p2 = new Produto() { Categoria = "Bebidas", Nome = "Coca-Cola", PrecoUnitario = 6.99, Unidade = "Litros" };
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
                //var promocao = contexto.Promocoes.Find(2);
                //contexto.Promocoes.Remove(promocao);
                //contexto.Produtos.Add(p1);
                //contexto.Produtos.Add(p2);

                ExibeEntries(contexto.ChangeTracker.Entries());
                contexto.SaveChanges();
            }
        }
    }
}
