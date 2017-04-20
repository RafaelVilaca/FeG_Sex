using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_FeG_Sex.Entidades
{
    public class VendasVo : BaseVo
    {
        public virtual ProdutosVo Produtos { get; set; }
        public virtual ClientesVo Clientes { get; set; }
        public int Qtde { get; set; }
        public string Vl_Venda { get; set; }
        public DateTime Dt_Transacao { get; set; }

        public VendasVo()
        {
            this.Clientes = new ClientesVo();
            this.Produtos = new ProdutosVo();
        }
    }
}
