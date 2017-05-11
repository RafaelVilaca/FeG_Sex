using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;
using System;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms.Produtos
{
    public partial class FormEditarProdutos : Form
    {
        private readonly ProdutosBo _produtosBo;

        public FormEditarProdutos()
        {
            InitializeComponent();
            _produtosBo = ProdutosConstrutor.ProdutosBo();
        }

        private void FormEditarProdutos_Load(object sender, EventArgs e)
        {
            try
            {
                var produtos = ProdutosConstrutor.ProdutosBo()
                    .ListarTodos();

                cb_Produto.DataSource = produtos;
                cb_Produto.ValueMember = "IdProd";
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
            bool situacao;
            if (rd_Ativo.Checked)
                situacao = true;
            else
                situacao = false;

            if (txt_Descricao.Text == "" || txt_Descricao.Text.Length <= 3)
                MessageBox.Show("Descricao Incorreta" +
                                "\nCorrija por favor!");

            else if (nud_Qtd.Value == 0)
                MessageBox.Show("Quantidade Incorreta" +
                                "\nCorrija por favor!");

            else if (nup_compra.Value == (decimal)0.00)
                MessageBox.Show("Valor de Compra Incorreto" +
                                "\nCorrija por favor!");

            else if (nup_venda.Value == (decimal)0.00)
                MessageBox.Show("Valor de Venda Incorreto" +
                                "\nCorrija por favor!");

            else if (nup_venda.Value < nup_compra.Value)
                MessageBox.Show("Valor de Venda não pode ser menor que de Compra" +
                                "\nCorrija por favor!");
            else
            {
                try
                {
                    var entidades = new ProdutosVo
                    {
                        IdProd = (cb_Produto.SelectedItem as ProdutosVo).IdProd,
                        Descricao = txt_Descricao.Text,
                        VlCompra = nup_compra.Value,
                        VlVenda = nup_venda.Value,
                        DtCadastro = DateTime.Parse(txt_Data.Text),
                        Qtde = int.Parse(nud_Qtd.Text),
                        Ativo = situacao
                    };


                    if (MessageBox.Show(
                        $"Descrição: {entidades.Descricao}" +
                        $"\nValor da Compra: {entidades.VlCompra}" +
                        $"\nValor da Venda: {entidades.VlVenda}" +
                        $"\nQuantidade: {entidades.Qtde}", 
                        @"Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string mensagem = _produtosBo.Salvar(entidades);
                        MessageBox.Show(mensagem);
                        FormEditarProdutos_Load(sender, e);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas ao editar o produto " +
                                    "\nTente Novamente!");
                }
            }
        }

        private void cb_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Descricao.Text = (cb_Produto.SelectedItem as ProdutosVo).Descricao;
                txt_Data.Text = (cb_Produto.SelectedItem as ProdutosVo).DtCadastro.ToString();
                nud_Qtd.Value = (cb_Produto.SelectedItem as ProdutosVo).Qtde;
                nup_venda.Value = (cb_Produto.SelectedItem as ProdutosVo).VlVenda;
                nup_compra.Value = (cb_Produto.SelectedItem as ProdutosVo).VlCompra;

                if ((cb_Produto.SelectedItem as ProdutosVo).Ativo)
                    rd_Ativo.Checked = true;
                else
                    rd_Desativo.Checked = true;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Erro ao carregar dados do Produto");
            }
        }
    }
}
