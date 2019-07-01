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

            MostraImpostos2();
            //Console.WriteLine("###########################################");
            //MostraInvestimentos();
            //MostraDescontos();
            //MostraResposta();
            //MostraImpostos2();

            Console.ReadKey();
        }

        private static void MostraImpostos2()
        {
            //Imposto iss = new ISS(new ICMS(new IHIT()));
            Imposto impo = new ImpostoMuitoAlto(new IKCV());
            Orcamento orcamento = new Orcamento(1000);
            orcamento.AdicionaItem(new Item("Lapis", 1000));
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Bolsa", 250));
            orcamento.AdicionaItem(new Item("Lapis", 1000));
            orcamento.AdicionaItem(new Item("borracha", 1000));
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            //calculador.RealizaCalculo(orcamento, ikcv);
            //calculador.RealizaCalculo(orcamento, iccp);
            calculador.RealizaCalculo(orcamento, impo);

        }

        private static void MostraResposta()
        {
            Conta c = new Conta("Ricardo", 500, "1203", "4000", DateTime.Now);
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

            Conta conta = new Conta("Andre",25000.00, "12300","23091023", DateTime.Now);

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
            Imposto iss = new ISS(new ICMS(new IHIT()));

            Orcamento orcamento = new Orcamento(10000.00);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, iss);
        }

    }
}

