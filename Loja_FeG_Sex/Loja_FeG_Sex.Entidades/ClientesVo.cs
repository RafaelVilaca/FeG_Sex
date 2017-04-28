using System;

namespace Loja_FeG_Sex.Entidades
{
    public class ClientesVo : BaseVo
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public DateTime Dt_Nasc { get; set; }
        public DateTime Dt_Cadastro { get; set; }
        public long? Telefone { get; set; }
        public long? Celular { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }

        public string TelefoneFormatado =>
            Telefone.HasValue ? 
            $"({Telefone.ToString().Substring(0, 2)}) {Telefone.ToString().Substring(2, 4)} - {Telefone.ToString().Substring(6, 4)}" : "0";

        public string CelularFormatado => 
            Celular.HasValue ? 
            $"({Celular.ToString().Substring(0, 2)}) {Celular.ToString().Substring(2, 5)} - {Celular.ToString().Substring(7, 4)}" : "0";

        public string Endereco => $"{Rua}, {Numero}, {Bairro}, {Complemento}";
    }
}
