using Loja_FeG_Sex.Repositorio;

namespace Loja_FeG_Sex.Business
{
    public class ClientesConstrutor
    {
        public static ClientesBo ClienteBo()
        {
            return new ClientesBo(new ClienteRepositorio());
        }
    }
}
