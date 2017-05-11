using Loja_FeG_Sex.Repositorio;

namespace Loja_FeG_Sex.Business
{
    public class CastigoConstrutor
    {
        public static CastigoBo CastigosBo()
        {
            return new CastigoBo(new CastigosRepositorio());
        }
    }
}
