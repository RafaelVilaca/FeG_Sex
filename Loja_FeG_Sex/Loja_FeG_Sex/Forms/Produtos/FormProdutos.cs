using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;

namespace Loja_FeG_Sex.Forms.Produtos
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

        private void Lista(IEnumerable<ProdutosVo> produtos)
        {
            try
            {
                if (nud_busca.Value > 0)
                    produtos = produtos.Where(x => x.Qtde <= nud_busca.Value);
                if (txt_Busca.Text != "")
                    produtos = produtos.Where(x => x.Descricao.Contains(txt_Busca.Text));

                dtg_Produtos.DataSource = produtos.Select(x => new
                {
                    x.Descricao,
                    x.Qtde,
                    x.Dt_Cadastro,
                    x.compraFormatado,
                    x.vendaFormatado,
                    x.Situacao
                }).ToList();

                var linhas = dtg_Produtos.Rows.Cast<DataGridViewRow>();
                foreach (var r in linhas.Where(x => x.Cells[5].Value.ToString() == "Desativo"))
                {
                    //dtg_Clientes.Rows[r.Index].DefaultCellStyle.BackColor = Color.Red;
                    r.DefaultCellStyle.BackColor = Color.MistyRose;
                    r.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Problemas ao criar a Lista de Produtos");
            }

        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderBy(x => x.Descricao);
            Lista(produtos);
        }

        private void btn_desc_asc_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderBy(x => x.Descricao);
            Lista(produtos);
        }

        private void btn_desc_dec_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderByDescending(x => x.Descricao);
            Lista(produtos);
        }

        private void btn_qtde_asc_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderBy(x => x.Qtde);
            Lista(produtos);
        }

        private void btn_qtde_dec_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderByDescending(x => x.Qtde);
            Lista(produtos);
        }

        private void btn_dt_Cad_asc_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderBy(x => x.Dt_Cadastro);
            Lista(produtos);
        }

        private void btn_dt_cad_dec_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderByDescending(x => x.Dt_Cadastro);
            Lista(produtos);
        }

        private void btn_compra_dec_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderByDescending(x => x.Vl_Compra);
            Lista(produtos);
        }

        private void btn_Compra_asc_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderBy(x => x.Vl_Compra);
            Lista(produtos);
        }

        private void btn_Venda_asc_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderBy(x => x.Vl_Venda);
            Lista(produtos);
        }

        private void btn_venda_dec_Click(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos().OrderByDescending(x => x.Vl_Venda);
            Lista(produtos);
        }

        private void txt_Busca_TextChanged(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos();//.Where(x => x.Descricao.Contains(txt_Busca.Text));
            Lista(produtos);
        }

        private void nud_busca_ValueChanged(object sender, EventArgs e)
        {
            var produtos = ProdutosConstrutor.produtosBo().ListarTodos();//.Where(x => x.Qtde <= nud_busca.Value);
            Lista(produtos);

        }

        private void btn_Editar_Produto_Click(object sender, EventArgs e)
        {
            FormEditarProdutos editarProduto = new FormEditarProdutos();
            editarProduto.ShowDialog();
            FormProdutos_Load(sender, e);
        }
    }
}
