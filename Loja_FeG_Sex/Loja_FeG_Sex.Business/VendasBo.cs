using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;
using System;
using System.Collections.Generic;

namespace Loja_FeG_Sex.Business
{
    public class VendasBo
    {
        private readonly IVendas _repositorio;
        //private VendaRepositorio vendaRepositorio;

        public VendasBo(IVendas repo)
        {
            _repositorio = repo;
        }

        public string Salvar(VendasVo vendas)
        {
            return _repositorio.Salvar(vendas);
        }

        public IEnumerable<VendasVo> ListarTodos()
        {
            return _repositorio.ListarTodos();
        }

        public IEnumerable<VendasVo> ListarTodos(string filtroNome, string filtroProduto, DateTime? dataInicial, DateTime? dataFinal)
        {
            return _repositorio.ListarTodos(filtroNome, filtroProduto, dataInicial, dataFinal);
        }
    }
}
