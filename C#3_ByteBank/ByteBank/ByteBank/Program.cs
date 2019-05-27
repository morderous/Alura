using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("454.658.148-32");
            roberta.Nome = "Roberta Mathiussi";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("000.493.322-77");
            camila.Nome = "Camila da Cunha";
            camila.Senha = "12345";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "abc");

            sistemaInterno.Logar(camila, "12345");

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

            Desenvolvedor guilherme = new Desenvolvedor("287.632.948-01");
            guilherme.Nome = "Guilherme da Silva";

            GerenciadorBonificacao.Registrar(pedro);
            GerenciadorBonificacao.Registrar(roberta);
            GerenciadorBonificacao.Registrar(igor);
            GerenciadorBonificacao.Registrar(camila);
            GerenciadorBonificacao.Registrar(guilherme);


            Console.WriteLine("Total de bonificações concedidas no mês: " + GerenciadorBonificacao.GetTotalBonificacao());

        }


    }
}
