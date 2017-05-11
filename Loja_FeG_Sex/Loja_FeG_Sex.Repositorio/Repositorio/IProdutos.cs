using Loja_FeG_Sex.Entidades;
using System.Collections.Generic;

namespace Loja_FeG_Sex.Repositorio.Repositorio
{
    public interface IProdutos : IRepositorio<ProdutosVo>
    {
        IEnumerable<ProdutosVo> ListarTodos(string filtro);

        IEnumerable<ProdutosVo> ListarAtivos();
    }
}
