using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;
using System.Collections.Generic;

namespace Loja_FeG_Sex.Business
{
    public class LingeriesBo
    {
        private readonly ILingeries repositorio;
        //private ClienteRepositorio clienteRepositorio;

        public LingeriesBo(ILingeries repo)
        {
            repositorio = repo;
        }

        public string Salvar(LingeriesVo clientes)
        {
            return repositorio.Salvar(clientes);
        }

        public IEnumerable<LingeriesVo> ListarTodos()
        {
            return repositorio.ListarTodos();
        }
    }
}
