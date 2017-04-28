using Loja_FeG_Sex.Repositorio;

namespace Loja_FeG_Sex.Business
{
    public class VendasConstrutor
    {
        public static VendasBo vendasBo()
        {
            return new VendasBo(new VendaRepositorio());
        }
    }
}
