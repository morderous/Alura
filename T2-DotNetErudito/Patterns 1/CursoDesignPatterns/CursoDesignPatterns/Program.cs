using System;
using CursoDesignPatterns.Impostos;
using CursoDesignPatterns.Investimentos;
using CursoDesignPatterns.Requisitions;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //MostraImpostos();
            //Console.WriteLine("###########################################");
            //MostraInvestimentos();
            //MostraDescontos();
            //MostraResposta();
            MostraImpostos2();

            Console.ReadKey();
        }

        private static void MostraImpostos2()
        {
            TemplateDeImpostoCondicional ikcv = new IKCV();
            TemplateDeImpostoCondicional iccp = new ICPP();
            TemplateDeImpostoCondicional ihit = new IHIT();
            Orcamento orcamento = new Orcamento(1000);
            orcamento.AdicionaItem(new Item("Lapis", 1000));
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Bolsa", 250));
            orcamento.AdicionaItem(new Item("Lapis", 1000));
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            //calculador.RealizaCalculo(orcamento, ikcv);
            //calculador.RealizaCalculo(orcamento, iccp);
            calculador.RealizaCalculo(orcamento, ihit);

        }

        private static void MostraResposta()
        {
            Conta c = new Conta("Ricardo", 500, "1203", "4000");
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

            Conta conta = new Conta("Andre",25000.00, "12300","23091023");

            CalculadorDeInvestimentos calculador = new CalculadorDeInvestimentos();

            Console.WriteLine(conta.Titular + " Saldo inicial: " + conta.Saldo);
            calculador.RealizaCalculo(conta, arrojado);
            Console.WriteLine("-------------------------------------");
            calculador.RealizaCalculo(conta, conservador);
            Console.WriteLine("-------------------------------------");
            calculador.RealizaCalculo(conta, moderado);
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

