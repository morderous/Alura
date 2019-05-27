using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            Console.ReadLine();
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao GerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("030.562.588-15");
            pedro.Nome = "Pedro Gabriel Castro";

            Diretor roberta = new Diretor("454.658.148-32");
            roberta.Nome = "Roberta Mathiussi";

            Auxiliar igor = new Auxiliar("985.659.741-56");
            igor.Nome = "Igor Polufueno";

            GerenteDeConta camila = new GerenteDeConta("000.493.322-77");
            camila.Nome = "Camila da Cunha";

            GerenciadorBonificacao.Registrar(pedro);
            GerenciadorBonificacao.Registrar(roberta);
            GerenciadorBonificacao.Registrar(igor);
            GerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações concedidas no mês: " + GerenciadorBonificacao.GetTotalBonificacao());

        }


    }
}
