using System.Collections.Generic;

namespace Loja_FeG_Sex.Repositorio
{
    public interface IRepositorio<T> where T : class
    {        
        string Salvar(T entidade);
        IEnumerable<T> ListarTodos();
    }
}
