using System.Collections.Generic;
using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;

namespace Loja_FeG_Sex.Business
{
    public class CastigoBo
    {
        private readonly ICastigos _repositorio;

        public CastigoBo(ICastigos repo)
        {
            _repositorio = repo;
        }

        public string Salvar(CastigosVo castigos)
        {
            return _repositorio.Salvar(castigos);
        }

        public IEnumerable<CastigosVo> ListarTodos(bool pessoa)
        {
            return _repositorio.ListarTodos(pessoa);
        }

        public IEnumerable<CastigosVo> ListarTodos(string descricao)
        {
            return _repositorio.ListarTodos(descricao);
        }

        public IEnumerable<CastigosVo> ListarTodos()
        {
            return _repositorio.ListarTodos();
        }
    }
}
