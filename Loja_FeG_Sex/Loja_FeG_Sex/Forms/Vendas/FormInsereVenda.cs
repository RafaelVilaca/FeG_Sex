using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Forms.Calculadora;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms.Vendas
{
    public partial class FormInsereVenda : Form
    {
        private readonly VendasBo vendasBo;

        public FormInsereVenda()
        {
            InitializeComponent();
            vendasBo = VendasConstrutor.vendasBo();
        }

        private void Limpar()
        {
            txt_Data.Text = Convert.ToString(DateTime.Now);
            nud_QTD.Value = 0;
            cb_Cliente.SelectedIndex = 0;
            cb_Produto.SelectedIndex = 0;
            txt_Total.Text = "";
            txt_troco.Text = "";
            txt_venda_banco.Text = "";
            nud_Desconto.Value = decimal.Parse("0,00");
            nud_recebido.Value = decimal.Parse("0,00");
            lblRecebimento.Visible = false;
            dtp_recebimento.Value = DateTime.Now;
            dtp_recebimento.Visible = false;
            rd_AVista.Checked = true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            FormCalculadora novajanela = new FormCalculadora();
            novajanela.ShowDialog();
        }

        private void FormInsereVenda_Load(object sender, EventArgs e)
        {
            IEnumerable<ClientesVo> clientes;
            IEnumerable<ProdutosVo> produtos;

            clientes = ClientesConstrutor.clienteBo().ListarTodos();
            produtos = ProdutosConstrutor.produtosBo().ListarTodos();

            cb_Cliente.DataSource = clientes;
            cb_Cliente.ValueMember = "Id_Cliente";
            cb_Cliente.DisplayMember = "Nome";
            //cb_Cliente.MaxDropDownItems = 10;

            cb_Produto.DataSource = produtos;
            cb_Produto.ValueMember = "Id_Prod";
            cb_Produto.DisplayMember = "Descricao";

            //cb_Produto.MaxDropDownItems = 10;            

            txt_Data.Text = DateTime.Now.ToString();
            lblRecebimento.Visible = false;
            dtp_recebimento.Value = DateTime.Now;
            dtp_recebimento.Visible = false;
            rd_AVista.Checked = true;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            VendasVo entidades = new VendasVo();

            int verificaEstoque = (cb_Produto.SelectedItem as ProdutosVo).Qtde;
            string nomeTipoPagamento = "";

            if (rd_AVista.Checked == true)
                nomeTipoPagamento = "À Vista";
            else if (rd_boleto.Checked == true)
                nomeTipoPagamento = "Boleto";
            else if (rd_cartao.Checked == true)
                nomeTipoPagamento = "Cartão";
            else
                nomeTipoPagamento = "À Prazo";

            if (nud_QTD.Value == decimal.Parse("0,00"))
            {
                MessageBox.Show("Quantidade Zerada\nCorrija por favor!");
            }
            else if (nud_QTD.Value > verificaEstoque)
            {
                MessageBox.Show("Quantidade Requerida Maior que Estoque\nCorrija por favor!");
            }
            else
            {
                entidades.Id_Cliente = int.Parse(cb_Cliente.SelectedValue.ToString());
                entidades.Id_Prod = int.Parse(cb_Produto.SelectedValue.ToString());
                entidades.Dt_Transacao = DateTime.Parse(txt_Data.Text);
                entidades.Qtde = int.Parse(nud_QTD.Value.ToString());
                entidades.Vl_Venda = decimal.Parse(txt_Total.Text);
                entidades.Data_Recebimento = dtp_recebimento.Value;
                entidades.Tipo_Recebimento = nomeTipoPagamento;

                string mensagem = vendasBo.Salvar(entidades);
                MessageBox.Show(mensagem);
                Limpar();
            }
        }

        private void nud_Venda_ValueChanged(object sender, EventArgs e)
        {
        }

        private void cb_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cb_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_venda_banco.Text = (cb_Produto.SelectedItem as ProdutosVo).Vl_Venda.ToString();
            }
            catch (Exception) { }
        }

        private void nud_QTD_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Total.Text = (decimal.Parse(txt_venda_banco.Text) * nud_QTD.Value).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Total.Text = ((decimal.Parse(txt_venda_banco.Text) * nud_QTD.Value) - nud_Desconto.Value).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void nud_recebido_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_troco.Text = (decimal.Parse(txt_Total.Text) - nud_recebido.Value).ToString();
            }
            catch (Exception)
            {
            }
        }

        private void grp_dados_Cliente_Enter(object sender, EventArgs e)
        {
        }

        private void rd_AVista_CheckedChanged(object sender, EventArgs e)
        {
            lblRecebimento.Visible = false;
            dtp_recebimento.Visible = false;
        }

        private void rd_boleto_CheckedChanged(object sender, EventArgs e)
        {
            lblRecebimento.Visible = true;
            dtp_recebimento.Visible = true;
        }

        private void rd_prazo_CheckedChanged(object sender, EventArgs e)
        {
            lblRecebimento.Visible = true;
            dtp_recebimento.Visible = true;
        }

        private void rd_cartao_CheckedChanged(object sender, EventArgs e)
        {
            lblRecebimento.Visible = false;
            dtp_recebimento.Visible = false;
        }
    }
}
