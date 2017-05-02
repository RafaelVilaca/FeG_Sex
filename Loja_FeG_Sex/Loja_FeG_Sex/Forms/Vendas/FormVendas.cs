using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Forms.Vendas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms
{
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Venda_Click(object sender, EventArgs e)
        {
            FormInsereVenda novaJanela = new FormInsereVenda();
            novaJanela.ShowDialog();
            FormVendas_Load(sender, e);
        }

        private object Lista(IEnumerable<VendasVo> vendas)
        {
            object Vendas;
            try
            {
                if (txt_Nome.Text != "" && txt_Descricao.Text != "")
                    Vendas = vendas
                        .Where(x => (x.Cliente.Nome.Contains(txt_Nome.Text) &&
                        x.Produto.Descricao.Contains(txt_Descricao.Text)) &&
                        (x.Dt_Transacao >= dtp_inicial.Value && x.Dt_Transacao <= dtp_final.Value))
                        .Select(x => new
                        {
                            x.Cliente.Nome,
                            x.Produto.Descricao,
                            x.Qtde,
                            x.vendaFormatado,
                            x.Dt_Transacao,
                            x.pagamentoFormatado
                        }).ToList();

                else if (txt_Descricao.Text != "")
                    Vendas = vendas
                        .Where(x => (x.Produto.Descricao.Contains(txt_Descricao.Text)) &&
                        (x.Dt_Transacao >= dtp_inicial.Value && x.Dt_Transacao <= dtp_final.Value))
                        .Select(x => new
                        {
                            x.Cliente.Nome,
                            x.Produto.Descricao,
                            x.Qtde,
                            x.vendaFormatado,
                            x.Dt_Transacao,
                            x.pagamentoFormatado
                        }).ToList();

                else if (txt_Nome.Text != "")
                    Vendas = vendas
                        .Where(x => (x.Cliente.Nome.Contains(txt_Nome.Text)) &&
                        (x.Dt_Transacao >= dtp_inicial.Value && x.Dt_Transacao <= dtp_final.Value))
                        .Select(x => new
                        {
                            x.Cliente.Nome,
                            x.Produto.Descricao,
                            x.Qtde,
                            x.vendaFormatado,
                            x.Dt_Transacao,
                            x.pagamentoFormatado
                        }).ToList();

                else
                    Vendas = vendas
                        .Where(x => x.Dt_Transacao >= dtp_inicial.Value && x.Dt_Transacao <= dtp_final.Value)
                        .Select(x => new
                        {
                            x.Cliente.Nome,
                            x.Produto.Descricao,
                            x.Qtde,
                            x.vendaFormatado,
                            x.Dt_Transacao,
                            x.pagamentoFormatado
                        }).ToList();
            }
            catch (Exception)
            {
                Vendas = vendas
                    .Where(x => x.Dt_Transacao >= dtp_inicial.Value && x.Dt_Transacao <= dtp_final.Value)
                    .Select(x => new
                {
                    x.Cliente.Nome,
                    x.Produto.Descricao,
                    x.Qtde,
                    x.vendaFormatado,
                    x.Dt_Transacao,
                    x.pagamentoFormatado
                }).ToList();
            }
            return Vendas;
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            try
            {
                var vendas = VendasConstrutor.vendasBo().ListarTodos();
                dtg_Vendas.DataSource = Lista(vendas);
                dtp_final.Value = DateTime.Now;
                dtp_inicial.Value = Convert.ToDateTime("28/04/2000");
                dtp_inicial.MaxDate = DateTime.Now;
                dtp_final.MinDate = Convert.ToDateTime("28/04/2000");
            }
            catch (Exception) { }
        }

        private void btn_nome_asc_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
            .ListarTodos()
            .OrderBy(x => x.Cliente.Nome);

            dtg_Vendas.DataSource = Lista(vendas);
        }

        private void btn_transa_asc_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderBy(x => x.Dt_Transacao);

            dtg_Vendas.DataSource = Lista(vendas);
        }

        private void btn_prod_asc_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderBy(x => x.Produto.Descricao);

            dtg_Vendas.DataSource = Lista(vendas);
        }

        private void btn_venda_asc_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
                .ListarTodos()
               .OrderBy(x => x.Vl_Venda);

            dtg_Vendas.DataSource = Lista(vendas);
        }

        private void btn_nome_dec_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderByDescending(x => x.Cliente.Nome);

            dtg_Vendas.DataSource = Lista(vendas);
        }

        private void btn_transa_dec_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderByDescending(x => x.Dt_Transacao);

            dtg_Vendas.DataSource = Lista(vendas);
        }

        private void btn_prod_dec_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderByDescending(x => x.Produto.Descricao);

            dtg_Vendas.DataSource = Lista(vendas);
        }

        private void btn_venda_dec_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderByDescending(x => x.Vl_Venda);

            dtg_Vendas.DataSource = Lista(vendas);
        }

        private void buscaNome(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderBy(x => x.Cliente.Nome);

            dtg_Vendas.DataSource = Lista(vendas);
        }

        private void buscaProduto(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderBy(x => x.Produto.Descricao);

            dtg_Vendas.DataSource = Lista(vendas);
        }

        private void buscaDataInicial(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderBy(x => x.Dt_Transacao);

            dtg_Vendas.DataSource = Lista(vendas);
            dtp_final.MinDate = dtp_inicial.Value;

            btn_Atualiza_Click(sender, e);
        }

        private void buscaDataFinal(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderByDescending(x => x.Dt_Transacao);

            dtg_Vendas.DataSource = Lista(vendas);
            dtp_inicial.MaxDate = dtp_final.Value;

            btn_Atualiza_Click(sender, e);
        }

        private void btn_Atualiza_Click(object sender, EventArgs e)
        {
            IEnumerable<VendasVo> vendas;

            vendas = VendasConstrutor.vendasBo().ListarTodos();

            dtg_Vendas.DataSource = vendas
                .Where(x => x.Dt_Transacao >= dtp_inicial.Value && x.Dt_Transacao <= dtp_final.Value)
                .Select(x => new
            {
                x.Cliente.Nome,
                x.Produto.Descricao,
                x.Qtde,
                x.Vl_Venda,
                x.Dt_Transacao,
                x.pagamentoFormatado
            }).ToList();

            dtg_Vendas.Refresh();
        }
    }
}
