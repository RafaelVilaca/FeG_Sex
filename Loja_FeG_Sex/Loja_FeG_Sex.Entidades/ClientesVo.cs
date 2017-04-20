using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_FeG_Sex.Entidades
{
    public class ClientesVo : BaseVo
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public DateTime Dt_Nasc { get; set; }
        public DateTime Dt_Cadastro { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
    }
}
