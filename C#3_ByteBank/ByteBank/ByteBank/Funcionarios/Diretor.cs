using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            // Bonificação do diretor é outro salário + a bonificação padrão dos funcionarios.
            // base é utilizado para chamar atributos ou metodos de classes mães
            return Salario + (base.GetBonificacao()); 
        }
    }
}