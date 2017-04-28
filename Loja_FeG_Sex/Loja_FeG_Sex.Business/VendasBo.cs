using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;
using System;
using System.Collections.Generic;

namespace Loja_FeG_Sex.Business
{
    public class VendasBo
    {
        private readonly IVendas repositorio;
        //private VendaRepositorio vendaRepositorio;

        public VendasBo(IVendas repo)
        {
            repositorio = repo;
        }

        public string Salvar(VendasVo vendas)
        {
            return repositorio.Salvar(vendas);
        }

        public IEnumerable<VendasVo> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public decimal ListarValor(int id)
        {
            return repositorio.ListarValor(id);
        }

        public IEnumerable<VendasVo> ListarTodos(string filtroNome, string filtroProduto, DateTime? dataInicial, DateTime? dataFinal)
        {
            return repositorio.ListarTodos(filtroNome, filtroProduto, dataInicial, dataFinal);
        }
    }
}
