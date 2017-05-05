using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;

namespace Loja_FeG_Sex.Forms.Vendas
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

        private void Lista(IEnumerable<VendasVo> vendas)
        {
            try
            {
                if (txt_Descricao.Text != "")
                    vendas = vendas.Where(x => (x.Produto.Descricao.Contains(txt_Descricao.Text)) &&
                    (x.Dt_Transacao >= dtp_inicial.Value && x.Dt_Transacao <= dtp_final.Value));

                if (txt_Nome.Text != "")
                    vendas = vendas.Where(x => (x.Cliente.Nome.Contains(txt_Nome.Text)) &&
                    (x.Dt_Transacao >= dtp_inicial.Value && x.Dt_Transacao <= dtp_final.Value));

                dtg_Vendas.DataSource = vendas.Select(x => new
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
                MessageBox.Show(@"Erro ao carregar a Lista de Vendas");
            }
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo().ListarTodos();
            Lista(vendas);
            dtp_final.Value = DateTime.Now;
            dtp_inicial.Value = Convert.ToDateTime("28/04/2000");
            dtp_inicial.MaxDate = DateTime.Now;
            dtp_final.MinDate = Convert.ToDateTime("28/04/2000");

        }

        private void btn_nome_asc_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
            .ListarTodos()
            .OrderBy(x => x.Cliente.Nome);

            Lista(vendas);
        }

        private void btn_transa_asc_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderBy(x => x.Dt_Transacao);

            Lista(vendas);
        }

        private void btn_prod_asc_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderBy(x => x.Produto.Descricao);

            Lista(vendas);
        }

        private void btn_venda_asc_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
                .ListarTodos()
               .OrderBy(x => x.Vl_Venda);

            Lista(vendas);
        }

        private void btn_nome_dec_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderByDescending(x => x.Cliente.Nome);

            Lista(vendas);
        }

        private void btn_transa_dec_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderByDescending(x => x.Dt_Transacao);

            Lista(vendas);
        }

        private void btn_prod_dec_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderByDescending(x => x.Produto.Descricao);

            Lista(vendas);
        }

        private void btn_venda_dec_Click(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderByDescending(x => x.Vl_Venda);

            Lista(vendas);
        }

        private void BuscaDataInicial(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderBy(x => x.Dt_Transacao);

            Lista(vendas);
            dtp_final.MinDate = dtp_inicial.Value;
        }

        private void BuscaDataFinal(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderByDescending(x => x.Dt_Transacao);

            Lista(vendas);
            dtp_inicial.MaxDate = dtp_final.Value;
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderBy(x => x.Cliente.Nome);
            Lista(vendas);
        }

        private void txt_Descricao_TextChanged(object sender, EventArgs e)
        {
            var vendas = VendasConstrutor.vendasBo()
               .ListarTodos()
               .OrderBy(x => x.Produto.Descricao);
            Lista(vendas);
        }
    }
}
