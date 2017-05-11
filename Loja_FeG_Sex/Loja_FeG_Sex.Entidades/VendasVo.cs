using System;

namespace Loja_FeG_Sex.Entidades
{
    public class VendasVo : BaseVo
    {
        public ProdutosVo Produto { get; set; }
        public ClientesVo Cliente { get; set; }
        public int Qtde { get; set; }
        public decimal VlVenda { get; set; }
        public DateTime DtTransacao { get; set; }
        public string TipoRecebimento { get; set; }
        public DateTime DataRecebimento { get; set; }

        public VendasVo()
        {
            Cliente = new ClientesVo();
            Produto = new ProdutosVo();
        }

        public string VendaFormatado => $"R$ {VlVenda}";
        public string PagamentoFormatado => $"{TipoRecebimento}: {DataRecebimento}";
    }
}
