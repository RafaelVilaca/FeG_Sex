using System;
using System.Windows.Forms;
using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;

namespace Loja_FeG_Sex.Forms.ChaLingerie
{
    public partial class FormEditarLingeries : Form
    {
        private readonly LingeriesBo _lingeriesBo;
        public FormEditarLingeries()
        {
            InitializeComponent();
            _lingeriesBo = LingeriesConstrutor.lingerieBo();
        }

        private void FormEditarLingeries_Load(object sender, EventArgs e)
        {
            var lingerie = LingeriesConstrutor.lingerieBo().ListarTodos();

            cb_Cliente.DataSource = lingerie;
            cb_Cliente.ValueMember = "Id_ChaLingerie";
            cb_Cliente.DisplayMember = "NomeCliente";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cb_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Descricao.Text = (cb_Cliente.SelectedItem as LingeriesVo).Descricao;
                dtp_Evento.Value = (cb_Cliente.SelectedItem as LingeriesVo).Data_Evento;
                nud_Valor.Value = (cb_Cliente.SelectedItem as LingeriesVo).Vl_Receber;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Erro ao carregar dados do Cliente");
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            LingeriesVo entidades = new LingeriesVo();

            if (nud_Valor.Value == decimal.Parse("0,00"))
                MessageBox.Show("Valor Zerado\nCorrija por favor!");

            else if (txt_Descricao.Text.Trim() == "" || txt_Descricao.Text.Trim().Length <= 10)
                MessageBox.Show("Descrição inválida \nNão pode conter menos de 10 caracteres \nCorrija por favor!");

            else
            {
                try
                {
                    entidades.Id_ChaLingerie = int.Parse(cb_Cliente.SelectedValue.ToString());
                    entidades.Id_Cliente = (cb_Cliente.SelectedItem as LingeriesVo).Cliente.Id_Cliente;
                    entidades.Data_Cadastro = (cb_Cliente.SelectedItem as LingeriesVo).Data_Cadastro;
                    entidades.Data_Evento = dtp_Evento.Value;
                    entidades.Descricao = txt_Descricao.Text;
                    entidades.Vl_Receber = nud_Valor.Value;

                    string nome = (cb_Cliente.SelectedItem as LingeriesVo).Cliente.Nome;

                    if (MessageBox.Show(
                        "Nome Cliente: " + nome +
                        "\nData do Evento: " + entidades.Data_Evento +
                        "\nDados do Chá: " + entidades.Descricao +
                        "\nRecebimento: " + entidades.valorFormatado,
                        "Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string mensagem = _lingeriesBo.Salvar(entidades);
                        MessageBox.Show(mensagem);
                        FormEditarLingeries_Load(sender, e);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Problemas ao Salvar os dados do Chá");
                }
            }
        }
    }
}
