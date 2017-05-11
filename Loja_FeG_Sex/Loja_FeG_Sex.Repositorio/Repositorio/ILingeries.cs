using System;
using System.Collections.Generic;
using Loja_FeG_Sex.Entidades;

namespace Loja_FeG_Sex.Repositorio.Repositorio
{
    public interface ILingeries : IRepositorio<LingeriesVo>
    {
        IEnumerable<LingeriesVo> ListarTodos(string filtro, DateTime? dataInicial, DateTime? dataFinal);
    }
}
