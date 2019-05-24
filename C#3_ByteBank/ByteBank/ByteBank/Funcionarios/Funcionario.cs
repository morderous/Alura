using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
        {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        //construtor da classe mãe que obriga a informar um cpf por parametro
        public Funcionario(string cpf)
        {
            CPF = cpf;
            TotalDeFuncionarios++;
        }

        //virtual é palavra reservada para utlizar override nas classes filhas
        public virtual double GetBonificacao() 
        {
            // Bonificação do funcionário é 10%
            return Salario * 0.10; 
        }
    }
}
