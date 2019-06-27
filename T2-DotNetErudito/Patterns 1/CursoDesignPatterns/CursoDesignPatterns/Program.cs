using System;
using CursoDesignPatterns.Impostos;
using CursoDesignPatterns.Investimentos;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            MostraDescontos();

            //MostraImpostos();
            //Console.WriteLine("###########################################");
            //MostraInvestimentos();
            

            Console.ReadKey();
        }

        private static void MostraDescontos()
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Lapis", 250));
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Fogao", 250));
            orcamento.AdicionaItem(new Item("Geladeira", 250));
            orcamento.AdicionaItem(new Item("Penal", 250));
            orcamento.AdicionaItem(new Item("Bolsa", 250));
            orcamento.AdicionaItem(new Item("Ziper", 250));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);
        }


        private static void MostraInvestimentos()
        {
            Investimento arrojado = new Arrojado();
            Investimento conservador = new Convervador();
            Investimento moderado = new Moderado();

            Saldo saldo = new Saldo(25000.00);

            CalculadorDeInvestimentos calculador = new CalculadorDeInvestimentos();

            Console.WriteLine("Saldo inicial: " + saldo.Valor);
            calculador.RealizaCalculo(saldo, arrojado);
            Console.WriteLine("-------------------------------------");
            calculador.RealizaCalculo(saldo, conservador);
            Console.WriteLine("-------------------------------------");
            calculador.RealizaCalculo(saldo, moderado);
            Console.WriteLine("-------------------------------------");

        }

        private static void MostraImpostos()
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(10000.00);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            Console.WriteLine("Orçamento: " + orcamento.Valor);
            calculador.RealizaCalculo(orcamento, iss);
            Console.WriteLine("-------------------------------------");
            calculador.RealizaCalculo(orcamento, icms);
            Console.WriteLine("-------------------------------------");
            calculador.RealizaCalculo(orcamento, iccc);
            Console.WriteLine("-------------------------------------");
        }
    }
}

