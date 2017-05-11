using System;

namespace Loja_FeG_Sex.Entidades
{
    public class ProdutosVo : BaseVo
    {
        public string Descricao { get; set; }
        public int Qtde { get; set; }
        public DateTime DtCadastro { get; set; }
        public decimal VlCompra { get; set; }
        public decimal VlVenda { get; set; }
        public bool Ativo { get; set; }

        public string CompraFormatado => $"R$ {VlCompra}";
        public string VendaFormatado => $"R$ {VlVenda}";
        public string Situacao => Ativo ? "Ativo" : "Desativo";
    }
}
