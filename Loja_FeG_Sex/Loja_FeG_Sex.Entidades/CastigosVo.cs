namespace Loja_FeG_Sex.Entidades
{
    public class CastigosVo : BaseVo
    {
        public string Descricao { get; set; }

        public bool Pessoa { get; set; }

        public string Referente => Pessoa ? "Convidada" : "Noiva";
    }
}
