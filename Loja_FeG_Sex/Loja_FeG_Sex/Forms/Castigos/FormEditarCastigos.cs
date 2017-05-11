using System;
using System.Windows.Forms;
using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;

namespace Loja_FeG_Sex.Forms.Castigos
{
    public partial class FormEditarCastigos : Form
    {
        private readonly CastigoBo _castigosBo;
        public FormEditarCastigos()
        {
            InitializeComponent();
            _castigosBo = CastigoConstrutor.CastigosBo();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            var pessoa = rd_Convidadas.Checked;

            if (txt_Descricao.Text.Trim() == "" || txt_Descricao.Text.Trim().Length < 10)
            {
                MessageBox.Show("Descrição Inválida " +
                                "\nNão pode conter menos de 10 caracteres " +
                                "\nCorrija por favor!");
                txt_Descricao.Focus();
            }
            else
            {
                try
                {
                    CastigosVo entidades = new CastigosVo
                    {
                        IdCastigo = int.Parse(cb_Castigo.SelectedValue.ToString()),
                        Descricao = txt_Descricao.Text,
                        Pessoa = pessoa
                    };


                    if (MessageBox.Show(
                        $"Descrição: {entidades.Descricao}" +
                        $"\nPessoa do Castigo: {entidades.Referente}",
                        @"Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string mensagem = _castigosBo.Salvar(entidades);
                        MessageBox.Show(mensagem);
                        FormEditarCastigos_Load(sender, e);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao tentar editar " +
                                    "\nTente Novamente!");
                }
            }
        }

        private void FormEditarCastigos_Load(object sender, EventArgs e)
        {
            var castigo = CastigoConstrutor.CastigosBo()
                .ListarTodos();

            cb_Castigo.DataSource = castigo;
            cb_Castigo.ValueMember = "IdCastigo";
            cb_Castigo.DisplayMember = ("Descricao");
        }

        private void cb_Castigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Descricao.Text = (cb_Castigo.SelectedItem as CastigosVo).Descricao;
                if ((cb_Castigo.SelectedItem as CastigosVo).Pessoa == false)
                    rd_Noiva.Checked = true;
                else
                    rd_Convidadas.Checked = true;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Erro ao carregar dados do Castigo");
            }
        }
    }
}
