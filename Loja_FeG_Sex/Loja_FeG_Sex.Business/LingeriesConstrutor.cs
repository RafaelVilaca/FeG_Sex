using Loja_FeG_Sex.Repositorio;

namespace Loja_FeG_Sex.Business
{
    public class LingeriesConstrutor
    {
        public static LingeriesBo LingerieBo()
        {
            return new LingeriesBo(new LingeriesRepositorio());
        }
    }
}
