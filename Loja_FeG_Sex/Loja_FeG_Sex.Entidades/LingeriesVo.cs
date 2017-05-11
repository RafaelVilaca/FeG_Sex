using System;

namespace Loja_FeG_Sex.Entidades
{
    public class LingeriesVo : BaseVo
    {

        public string Descricao { get; set; }

        public DateTime DataCadastro { get; set; }

        public ClientesVo Cliente { get; set; }

        public decimal VlReceber { get; set; }

        public DateTime DataEvento { get; set; }

        public LingeriesVo()
        {
            Cliente = new ClientesVo();
        }

        public string ValorFormatado => $"R$ {VlReceber}";

        public string NomeCliente => $"Cliente: {Cliente.Nome},   Data: {DataEvento}";
    }
}
