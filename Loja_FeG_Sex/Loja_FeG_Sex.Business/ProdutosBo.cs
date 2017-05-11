using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;
using System.Collections.Generic;

namespace Loja_FeG_Sex.Business
{
    public class ProdutosBo
    {
        private readonly IProdutos _repositorio;
        //private ProdutoRepositorio produtoRepositorio;

        public ProdutosBo(IProdutos repo)
        {
            _repositorio = repo;
        }

        public string Salvar(ProdutosVo produtos)
        {
            return _repositorio.Salvar(produtos);
        }
        
        public IEnumerable<ProdutosVo> ListarTodos(string filtro)
        {
            return _repositorio.ListarTodos(filtro);
        }

        public IEnumerable<ProdutosVo> ListarTodos()
        {
            return _repositorio.ListarTodos();
        }

        public IEnumerable<ProdutosVo> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
    }
}
