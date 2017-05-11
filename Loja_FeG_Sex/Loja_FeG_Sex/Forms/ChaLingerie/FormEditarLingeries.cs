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
            _lingeriesBo = LingeriesConstrutor.LingerieBo();
        }

        private void FormEditarLingeries_Load(object sender, EventArgs e)
        {
            var lingerie = LingeriesConstrutor.LingerieBo().ListarTodos();

            cb_Cliente.DataSource = lingerie;
            cb_Cliente.ValueMember = "IdChaLingerie";
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
                dtp_Evento.Value = (cb_Cliente.SelectedItem as LingeriesVo).DataEvento;
                nud_Valor.Value = (cb_Cliente.SelectedItem as LingeriesVo).VlReceber;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Erro ao carregar dados do Cliente");
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (nud_Valor.Value == decimal.Parse("0,00"))
                MessageBox.Show("Valor Zerado" +
                                "\nCorrija por favor!");

            else if (txt_Descricao.Text.Trim() == "" || txt_Descricao.Text.Trim().Length < 10)
                MessageBox.Show("Descrição inválida " +
                                "\nNão pode conter menos de 10 caracteres " +
                                "\nCorrija por favor!");

            else
            {
                try
                {
                    //LingeriesVo entidades = new LingeriesVo();
                    //entidades.IdChaLingerie = int.Parse(cb_Cliente.SelectedValue.ToString());
                    //entidades.IdCliente = (cb_Cliente.SelectedItem as LingeriesVo).Cliente.IdCliente;
                    //entidades.DataCadastro = (cb_Cliente.SelectedItem as LingeriesVo).DataCadastro;
                    //entidades.DataEvento = dtp_Evento.Value;
                    //entidades.Descricao = txt_Descricao.Text;
                    //entidades.VlReceber = nud_Valor.Value;
                    LingeriesVo entidades = new LingeriesVo
                    {
                        IdChaLingerie = int.Parse(cb_Cliente.SelectedValue.ToString()),
                        IdCliente = (cb_Cliente.SelectedItem as LingeriesVo).Cliente.IdCliente,
                        DataCadastro = (cb_Cliente.SelectedItem as LingeriesVo).DataCadastro,
                        DataEvento = dtp_Evento.Value,
                        Descricao = txt_Descricao.Text,
                        VlReceber = nud_Valor.Value
                    };

                    string nome = (cb_Cliente.SelectedItem as LingeriesVo).Cliente.Nome;

                    if (MessageBox.Show(
                        $"Nome Cliente: {nome}" +
                        $"\nData do Evento: {entidades.DataEvento}" +
                        $"\nDados do Chá: {entidades.Descricao}" +
                        $"\nRecebimento: {entidades.ValorFormatado}",
                        @"Confirmação", MessageBoxButtons.YesNo,
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
