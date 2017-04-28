using System.Collections.Generic;
using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;

namespace Loja_FeG_Sex.Business
{
    public class ClientesBo
    {
        private readonly ICliente repositorio;
        //private ClienteRepositorio clienteRepositorio;

        public ClientesBo(ICliente repo)
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

        public IEnumerable<ClientesVo> ListarTodos(string filtro)
        {
            return repositorio.ListarTodos(filtro);
        }
    }
}
