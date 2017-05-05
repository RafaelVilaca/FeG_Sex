using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;
using System;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms.Produtos
{
    public partial class FormInsereProduto : Form
    {
        private readonly ProdutosBo _produtosBo;

        public FormInsereProduto()
        {
            InitializeComponent();
            _produtosBo = ProdutosConstrutor.produtosBo();
        }

        private void Limpar()
        {
            txt_Descricao.Text = "";
            txt_Data.Text = (DateTime.Now).ToString();
            nud_Qtd.Value = 0;
            nup_compra.Value = (decimal)0.00;
            nup_venda.Value = (decimal)0.00;
            rd_Ativo.Checked = true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            bool situacao = false;
            if (rd_Ativo.Checked == true)
                situacao = true;
            else
                situacao = false;

            if (txt_Descricao.Text == "" || txt_Descricao.Text.Length <= 3)
                MessageBox.Show("Descricao Incorreta\nCorrija por favor!");

            else if (nud_Qtd.Value == 0)
                MessageBox.Show("Quantidade Incorreta\nCorrija por favor!");

            else if (nup_compra.Value == (decimal)0.00)
                MessageBox.Show("Valor de Compra Incorreto\nCorrija por favor!");

            else if (nup_venda.Value == (decimal)0.00)
                MessageBox.Show("Valor de Venda Incorreto\nCorrija por favor!");

            else if (nup_venda.Value < nup_compra.Value)
                MessageBox.Show("Valor de Venda não pode ser menor que de Compra\nCorrija por favor!");

            else
            {
                try
                {
                    ProdutosVo entidades = new ProdutosVo();

                    entidades.Descricao = txt_Descricao.Text;
                    entidades.Vl_Compra = nup_compra.Value;
                    entidades.Vl_Venda = nup_venda.Value;
                    entidades.Dt_Cadastro = DateTime.Parse(txt_Data.Text);
                    entidades.Qtde = int.Parse(nud_Qtd.Text);
                    entidades.Ativo = situacao;

                    if (MessageBox.Show(
                        "Descrição: " + entidades.Descricao +
                        "\nValor da Compra: " + entidades.Vl_Compra +
                        "\nValor da Venda: " + entidades.Vl_Venda +
                        "\nQuantidade: " + entidades.Qtde, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string mensagem = _produtosBo.Salvar(entidades);
                        MessageBox.Show(mensagem);
                        Limpar();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas ao inserir produto \nTente Novamente");
                }
            }
        }

        private void FormInsereProduto_Load(object sender, EventArgs e)
        {
            txt_Data.Text = Convert.ToString(DateTime.Now);
            txt_Descricao.Focus();
            rd_Ativo.Checked = true;
        }
    }
}
