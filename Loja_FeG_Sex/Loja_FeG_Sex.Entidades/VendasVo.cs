﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_FeG_Sex.Entidades
{
    public class VendasVo : BaseVo
    {
        public virtual ProdutosVo Produto { get; set; }
        public virtual ClientesVo Cliente { get; set; }
        public int Qtde { get; set; }
        public decimal Vl_Venda { get; set; }
        public DateTime Dt_Transacao { get; set; }

        public VendasVo()
        {
            this.Cliente = new ClientesVo();
            this.Produto = new ProdutosVo();
        }

        public string vendaFormatado => $"R${Vl_Venda}";
    }
}
