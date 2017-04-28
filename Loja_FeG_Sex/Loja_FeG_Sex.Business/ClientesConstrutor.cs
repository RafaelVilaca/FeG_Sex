using Loja_FeG_Sex.Repositorio;

namespace Loja_FeG_Sex.Business
{
    public class ClientesConstrutor
    {
        public static ClientesBo clienteBo()
        {
            return new ClientesBo(new ClienteRepositorio());
        }
    }
}
