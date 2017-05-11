using System;
using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;
using System.Collections.Generic;

namespace Loja_FeG_Sex.Business
{
    public class LingeriesBo
    {
        private readonly ILingeries _repositorio;
        //private ClienteRepositorio clienteRepositorio;

        public LingeriesBo(ILingeries repo)
        {
            _repositorio = repo;
        }

        public string Salvar(LingeriesVo clientes)
        {
            return _repositorio.Salvar(clientes);
        }

        public IEnumerable<LingeriesVo> ListarTodos()
        {
            return _repositorio.ListarTodos();
        }

        public IEnumerable<LingeriesVo> ListarTodos(string filtro, DateTime? dataInicial, DateTime? dataFinal)
        {
            return _repositorio.ListarTodos(filtro, dataInicial, dataFinal);
        }
    }
}
