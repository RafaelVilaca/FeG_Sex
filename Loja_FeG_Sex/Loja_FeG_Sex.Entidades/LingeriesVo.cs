using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_FeG_Sex.Entidades
{
    public class LingeriesVo : BaseVo
    {

        public string Descricao { get; set; }

        public DateTime Data_Cadastro { get; set; }

        public ClientesVo Cliente { get; set; }

        public decimal Vl_Receber { get; set; }

        public DateTime Data_Evento { get; set; }

        public LingeriesVo()
        {
            this.Cliente = new ClientesVo();
        }

        public string valorFormatado => $"R$ {Vl_Receber}";

        public string NomeCliente => Cliente.Nome;
    }
}
