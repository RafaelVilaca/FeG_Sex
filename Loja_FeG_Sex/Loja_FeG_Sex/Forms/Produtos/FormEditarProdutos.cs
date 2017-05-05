using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms.Produtos
{
    public partial class FormEditarProdutos : Form
    {
        private readonly ProdutosBo _produtosBo;

        public FormEditarProdutos()
        {
            InitializeComponent();
            _produtosBo = ProdutosConstrutor.produtosBo();
        }

        private void FormEditarProdutos_Load(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<ProdutosVo> produtos;
                produtos = ProdutosConstrutor.produtosBo().ListarTodos();

                cb_Produto.DataSource = produtos;
                cb_Produto.ValueMember = "Id_Prod";
                cb_Produto.DisplayMember = "Descricao";

                if ((cb_Produto.SelectedItem as ProdutosVo).Ativo)
                    rd_Ativo.Checked = true;
                else
                    rd_Desativo.Checked = true;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Problemas ao montar a lista de Produtos");
            }
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

                    entidades.Id_Prod = (cb_Produto.SelectedItem as ProdutosVo).Id_Prod;
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
                        "\nQuantidade: " + entidades.Qtde, "Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string mensagem = _produtosBo.Salvar(entidades);
                        MessageBox.Show(mensagem);
                        FormEditarProdutos_Load(sender, e);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas ao editar o produto \nTente Novamente!");
                }
            }
        }

        private void cb_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Descricao.Text = (cb_Produto.SelectedItem as ProdutosVo).Descricao;
                txt_Data.Text = (cb_Produto.SelectedItem as ProdutosVo).Dt_Cadastro.ToString();
                nud_Qtd.Value = (cb_Produto.SelectedItem as ProdutosVo).Qtde;
                nup_venda.Value = (cb_Produto.SelectedItem as ProdutosVo).Vl_Venda;
                nup_compra.Value = (cb_Produto.SelectedItem as ProdutosVo).Vl_Compra;
                if ((cb_Produto.SelectedItem as ProdutosVo).Ativo)
                    rd_Ativo.Checked = true;
                else
                    rd_Desativo.Checked = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados do Produto");
            }
        }
    }
}
