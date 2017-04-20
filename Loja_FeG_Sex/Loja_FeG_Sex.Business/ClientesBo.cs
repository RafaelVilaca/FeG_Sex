using System.Collections.Generic;
using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio;

namespace Loja_FeG_Sex.Business
{
    public class ClientesBo
    {
        private readonly IRepositorio<ClientesVo> repositorio;
        private ClienteRepositorio clienteRepositorio;

        public ClientesBo(IRepositorio<ClientesVo> repo)
        {
            repositorio = repo;
        }

        public string Salvar(ClientesVo clientes)
        {
            return repositorio.Salvar(clientes);
        }

        public IEnumerable<ClientesVo> ListarTodos()
        {
            return repositorio.ListarTodos();
        }        
    }
}
