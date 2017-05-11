using System.Collections.Generic;
using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;

namespace Loja_FeG_Sex.Business
{
    public class ClientesBo
    {
        private readonly ICliente _repositorio;
        //private ClienteRepositorio clienteRepositorio;

        public ClientesBo(ICliente repo)
        {
            _repositorio = repo;
        }

        public string Salvar(ClientesVo clientes)
        {
            return _repositorio.Salvar(clientes);
        }
        
        public IEnumerable<ClientesVo> ListarTodos(string filtro)
        {
            return _repositorio.ListarTodos(filtro);
        }

        public IEnumerable<ClientesVo> ListarTodos()
        {
            return _repositorio.ListarTodos();
        }

        public IEnumerable<ClientesVo> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
    }
}
