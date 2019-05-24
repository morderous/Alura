using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
        {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        //virtual é palavra reservada para utlizar override nas classes filhas
        public virtual double GetBonificacao() 
        {
            // Bonificação do funcionário é 10%
            return Salario * 0.10; 
        }
    }
}
