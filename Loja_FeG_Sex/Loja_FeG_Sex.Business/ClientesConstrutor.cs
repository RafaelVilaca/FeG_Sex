using Loja_FeG_Sex.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
