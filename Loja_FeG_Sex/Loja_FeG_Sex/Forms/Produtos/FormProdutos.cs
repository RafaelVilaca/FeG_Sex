using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Forms.Produtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Insere_Produto_Click(object sender, EventArgs e)
        {
            FormInsereProduto novajanela = new FormInsereProduto();
            novajanela.ShowDialog();
            FormProdutos_Load(sender, e);
        }

        private object Lista(IEnumerable<ProdutosVo> produtos)
        {
            object Produtos;
            try
            {
                if (txt_Busca.Text != "" && nud_busca.Value > 0)
                    Produtos = produtos
                    .Where(x => x.Descricao.Contains(txt_Busca.Text) && x.Qtde <= nud_busca.Value)
                    .Select(x => new
                    {
                        x.Descricao,
                        x.Qtde,
                        x.Dt_Cadastro,
                        x.compraFormatado,
                        x.vendaFormatado
                    }).ToList();


                else if (txt_Busca.Text == "" && nud_busca.Value != 0)
                    Produtos = produtos
                    .Where(x => x.Qtde <= nud_busca.Value)
                    .Select(x => new
                    {
                        x.Descricao,
                        x.Qtde,
                        x.Dt_Cadastro,
                        x.compraFormatado,
                        x.vendaFormatado
                    }).ToList();

                else if (txt_Busca.Text != "" && nud_busca.Value == 0)
                    Produtos = produtos
                    .Where(x => x.Descricao.Contains(txt_Busca.Text))
                    .Select(x => new
                    {
                        x.Descricao,
                        x.Qtde,
                        x.Dt_Cadastro,
                        x.compraFormatado,
                        x.vendaFormatado
                    }).ToList();

                else
                    Produtos = produtos.Select(x => new
                    {
                        x.Descricao,
                        x.Qtde,
                        x.Dt_Cadastro,
                        x.compraFormatado,
                        x.vendaFormatado
                    }).ToList();
            }
            catch(Exception) {
                Produtos = produtos.Select(x => new
                {
                    x.Descricao,
                    x.Qtde,
                    x.Dt_Cadastro,
                    x.compraFormatado,
                    x.vendaFormatado
                }).ToList();
            }
            return Produtos;
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderBy(x => x.Descricao);
            dtg_Produtos.DataSource = Lista(produtos);
        }

        private void btn_desc_asc_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderBy(x => x.Descricao);
            dtg_Produtos.DataSource = Lista(produtos);
        }

        private void btn_desc_dec_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderByDescending(x => x.Descricao);
            dtg_Produtos.DataSource = Lista(produtos);
        }

        private void btn_qtde_asc_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderBy(x => x.Qtde);
            dtg_Produtos.DataSource = Lista(produtos);
        }

        private void btn_qtde_dec_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderByDescending(x => x.Qtde);
            dtg_Produtos.DataSource = Lista(produtos);
        }

        private void btn_dt_Cad_asc_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderBy(x => x.Dt_Cadastro);
            dtg_Produtos.DataSource = Lista(produtos);
        }

        private void btn_dt_cad_dec_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderByDescending(x => x.Dt_Cadastro);
            dtg_Produtos.DataSource = Lista(produtos);
        }

        private void btn_compra_dec_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderByDescending(x => x.Vl_Compra);
            dtg_Produtos.DataSource = Lista(produtos);
        }

        private void btn_Compra_asc_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderBy(x => x.Vl_Compra);
            dtg_Produtos.DataSource = Lista(produtos);
        }

        private void btn_Venda_asc_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderBy(x => x.Vl_Venda);
            dtg_Produtos.DataSource = Lista(produtos);
        }

        private void btn_venda_dec_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderByDescending(x => x.Vl_Venda);
            dtg_Produtos.DataSource = Lista(produtos);
        }

        private void txt_Busca_TextChanged(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos();//(txt_Busca.Text, nud_busca.Value);
            dtg_Produtos.DataSource = Lista(produtos);
        }

        private void nud_busca_ValueChanged(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos();// (txt_Busca.Text, nud_busca.Value);
            dtg_Produtos.DataSource = Lista(produtos);
        }
    }
}
