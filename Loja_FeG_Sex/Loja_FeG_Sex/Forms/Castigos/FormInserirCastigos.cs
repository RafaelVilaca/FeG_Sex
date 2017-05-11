using System;
using System.Windows.Forms;
using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;

namespace Loja_FeG_Sex.Forms.Castigos
{
    public partial class FormInserirCastigos : Form
    {
        private readonly CastigoBo _castigosBo;
        public FormInserirCastigos()
        {
            InitializeComponent();
            _castigosBo = CastigoConstrutor.CastigosBo();
        }

        private void FormInserirCastigos_Load(object sender, EventArgs e)
        {
            rd_Noiva.Checked = true;
            txt_Descricao.Text = "";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            var pessoa = !rd_Noiva.Checked;
            if (txt_Descricao.Text.Trim() == "" || txt_Descricao.Text.Trim().Length < 10)
                MessageBox.Show("Descrição Inválida " +
                                "\nNão pode conter menos de 10 caracteres " +
                                "\nCorrija por favor!");
            else
            {
                try
                {
                    //CastigosVo entidades = new CastigosVo();

                    //entidades.Descricao = txt_Descricao.Text;
                    //entidades.Pessoa = pessoa;
                    var entidades = new CastigosVo
                    {
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
                        FormInserirCastigos_Load(sender, e);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao tentar inserir " +
                                    "\nTente Novamente!");
                }
            }
        }
    }
}
