using Loja_FeG_Sex.Entidades;
using System.Collections.Generic;

namespace Loja_FeG_Sex.Repositorio.Repositorio
{
    public interface ICliente : IRepositorio<ClientesVo>
    {
        IEnumerable<ClientesVo> ListarTodos(string filtro);

        IEnumerable<ClientesVo> ListarAtivos();
    }
}
