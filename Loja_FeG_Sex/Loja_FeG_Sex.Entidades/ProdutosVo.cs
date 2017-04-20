using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_FeG_Sex.Entidades
{
    public class ProdutosVo : BaseVo
    {
        public string Descricao { get; set; }
        public int Qtde { get; set; }
        public DateTime Dt_Cadastro { get; set; }
        public string Vl_Compra { get; set; }
        public string Vl_Venda { get; set; }
    }
}
