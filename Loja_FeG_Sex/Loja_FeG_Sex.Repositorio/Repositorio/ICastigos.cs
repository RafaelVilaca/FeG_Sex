using System.Collections.Generic;
using Loja_FeG_Sex.Entidades;

namespace Loja_FeG_Sex.Repositorio.Repositorio
{
    public interface ICastigos : IRepositorio<CastigosVo>
    {
        IEnumerable<CastigosVo> ListarTodos(bool pessoa);

        IEnumerable<CastigosVo> ListarTodos(string descricao);
    }
}
