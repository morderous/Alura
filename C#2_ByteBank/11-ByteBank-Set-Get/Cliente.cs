using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ByteBank_Set_Get
{
    public class Cliente
    {
        private string _cpf;
        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                if (value.Length > 11)
                {
                    Console.WriteLine("temos um erro");
                }
                else
                {
                     _cpf = value;
                }
            }
        }
        public string Profissao { get; set; }
    }
}
