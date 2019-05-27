using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        //classe filha que pega o construtor da base e passa pro construtor filha
        public Diretor(string cpf) : base(5000, cpf)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao()
        {
            // OLD - Bonificação do diretor é outro salário + a bonificação padrão dos funcionarios.
            //return Salario + base.GetBonificacao(); 
            // NEW - Agora é 50% de bonificação
            // base é utilizado para chamar atributos ou metodos de classes mães
            return Salario * 0.5; 
        }
    }
}