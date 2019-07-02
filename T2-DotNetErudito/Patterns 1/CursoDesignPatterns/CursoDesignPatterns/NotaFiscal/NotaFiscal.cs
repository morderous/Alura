using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.NotaFiscal
{
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao, double valorBruto, double impostos, IList<ItemDaNota> itens, string observacoes)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            DataDeEmissao = dataDeEmissao;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Itens = itens;
            this.observacoes = observacoes;
        }

        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public string observacoes { get; set; } 

    }


}
