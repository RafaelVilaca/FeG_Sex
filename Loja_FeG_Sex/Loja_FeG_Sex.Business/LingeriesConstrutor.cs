using Loja_FeG_Sex.Repositorio;

namespace Loja_FeG_Sex.Business
{
    public class LingeriesConstrutor
    {
        public static LingeriesBo lingerieBo()
        {
            return new LingeriesBo(new LingeriesRepositorio());
        }
    }
}
