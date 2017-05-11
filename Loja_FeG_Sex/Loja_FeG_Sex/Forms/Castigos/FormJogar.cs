using System;
using System.Linq;
using System.Windows.Forms;
using Loja_FeG_Sex.Business;

namespace Loja_FeG_Sex.Forms.Castigos
{
    public partial class FormJogar : Form
    {
        private readonly string[] _tabelaNoivaCastigo = new string[16];
        private readonly string[] _tabelaConvidadasCastigo = new string[24];
        private int?[] _tabelaNoiva = new int?[16];
        private int?[] _tabelaConvidadas = new int?[24];
        private int _numeroNoiva;
        private int _numeroConvidada;
        private readonly Random _buscaRandomica = new Random();
        private int _numero;

        public FormJogar()
        {
            InitializeComponent();
        }

        private void FormJogar_Load(object sender, EventArgs e)
        {
            Randomico_Noiva();
            Randomico_Convidadas();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_zerar_noiva_Click(object sender, EventArgs e)
        {
            limparButtons(groupNoiva.Controls);
            _numeroNoiva = 0;
            _tabelaNoiva = new int?[16];
            Randomico_Noiva();
        }

        private void btn_zerar_convidadas_Click(object sender, EventArgs e)
        {
            limparButtons(groupConvidadas.Controls);
            _numeroConvidada = 0;
            _tabelaConvidadas = new int?[24];
            Randomico_Convidadas();
        }

        public void Randomico_Convidadas()
        {
            var castigosConvidadas = CastigoConstrutor.CastigosBo()
                .ListarTodos(true)
                .ToArray();

            for (int i = 0; i < 24; i++)
            {
                do
                {
                    _numero = _buscaRandomica.Next(0, 24);
                } while (_tabelaConvidadas.Contains(_numero));
                _tabelaConvidadas[i] = _numero;

                _tabelaConvidadasCastigo[i] = castigosConvidadas[_numero].Descricao;
            }
        }

        public void Randomico_Noiva()
        {
            var castigosNoiva = CastigoConstrutor.CastigosBo()
                .ListarTodos(false)
                .ToArray();

            for (int i = 0; i < 16; i++)
            {
                do
                {
                    _numero = _buscaRandomica.Next(0, 16);
                } while (_tabelaNoiva.Contains(_numero));
                _tabelaNoiva[i] = _numero;

                _tabelaNoivaCastigo[i] = castigosNoiva[_numero].Descricao;
            }
        }

        private void limparButtons(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (var ctrl in controles.OfType<Button>())
            {
                ctrl.Text = "";
            }
        }

        private void Noiva_Click(object sender, EventArgs e)
        {
            var btn = ((Button)sender);
            if (btn.Text == "")
            {
                btn.Text = _tabelaNoivaCastigo[_numeroNoiva]; //Randomico(false);
                _numeroNoiva = _numeroNoiva + 1;
            }
            else
                MessageBox.Show(@"Botão já preenchido, escolha outro!");
        }

        private void Convidada_Click(object sender, EventArgs e)
        {
            var btn = ((Button)sender);
            if (btn.Text == "")
            {
                btn.Text = _tabelaConvidadasCastigo[_numeroConvidada]; //Randomico(true);
                _numeroConvidada = _numeroConvidada + 1;
            }
            else
                MessageBox.Show(@"Botão já preenchido, escolha outro!");
        }
    }
}
//private string Randomico(bool pessoa)
//{
//    var textoRandomico = "";
//try
//{
//    Random buscaRandomica = new Random();

//    var castigos = CastigoConstrutor.CastigosBo().ListarTodos(pessoa);
//    do
//    {
//        var numero = buscaRandomica.Next(1, 41);
//        var descricao = castigos.Where(x => x.IdCastigo == numero && x.Pessoa == pessoa);

//        if (descricao.Count() != 0)
//            textoRandomico = descricao.FirstOrDefault().Descricao;
//    } while (textoRandomico == "");
//}
//catch (Exception)
//{
//    MessageBox.Show(@"Problemas ao buscar texto do castigo");
//}
//    return textoRandomico;
//}