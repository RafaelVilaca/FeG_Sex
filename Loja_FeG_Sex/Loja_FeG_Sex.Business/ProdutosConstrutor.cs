using Loja_FeG_Sex.Repositorio;

namespace Loja_FeG_Sex.Business
{
    public class ProdutosConstrutor
    {
        public static ProdutosBo produtosBo()
        {
            return new ProdutosBo(new ProdutoRepositorio());
        }
    }
}
