using System;
using System.Collections.Generic;
using Loja_FeG_Sex.Entidades;

namespace Loja_FeG_Sex.Repositorio.Repositorio
{
    public interface IVendas : IRepositorio<VendasVo>
    {
        IEnumerable<VendasVo> ListarTodos(string filtroNome, string filtroProduto, DateTime? dataInicial, DateTime? dataFinal);
    }
}
