using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio;
using Loja_FeG_Sex.Repositorio.Repositorio;
using System.Collections.Generic;

namespace Loja_FeG_Sex.Business
{
    public class ProdutosBo
    {
        private readonly IProdutos repositorio;
        //private ProdutoRepositorio produtoRepositorio;

        public ProdutosBo(IProdutos repo)
        {
            repositorio = repo;
        }

        public string Salvar(ProdutosVo produtos)
        {
            return repositorio.Salvar(produtos);
        }

        public IEnumerable<ProdutosVo> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public IEnumerable<ProdutosVo> ListarAtivos()
        {
            return repositorio.ListarAtivos();
        }
    }
}
