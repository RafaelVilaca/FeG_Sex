using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Forms.Calculadora;
using System;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms.Vendas
{
    public partial class FormInsereVenda : Form
    {
        private readonly VendasBo _vendasBo;

        public FormInsereVenda()
        {
            InitializeComponent();
            _vendasBo = VendasConstrutor.VendasBo();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            FormCalculadora novajanela = new FormCalculadora();
            novajanela.ShowDialog();
        }

        private void FormInsereVenda_Load(object sender, EventArgs e)
        {
            try
            {
                var clientes = ClientesConstrutor.ClienteBo()
                    .ListarAtivos();
                var produtos = ProdutosConstrutor.ProdutosBo()
                    .ListarAtivos();

                cb_Cliente.DataSource = clientes;
                cb_Cliente.ValueMember = "IdCliente";
                cb_Cliente.DisplayMember = "Nome";

                cb_Produto.DataSource = produtos;
                cb_Produto.ValueMember = "IdProd";
                cb_Produto.DisplayMember = "Descricao";            

                txt_Data.Text = DateTime.Now.ToString();
                lblRecebimento.Visible = false;
                dtp_recebimento.MinDate = DateTime.Now;
                dtp_recebimento.MaxDate = DateTime.Parse("01/01/2030");
                dtp_recebimento.Visible = false;
                rd_AVista.Checked = true;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Erro ao carregar as Listas de produtos e clientes");
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            VendasVo entidades = new VendasVo();

            int verificaEstoque = (cb_Produto.SelectedItem as ProdutosVo).Qtde;
            string nomeTipoPagamento = "";

            if (rd_AVista.Checked)
                nomeTipoPagamento = "À Vista";
            else if (rd_boleto.Checked)
                nomeTipoPagamento = "Boleto";
            else if (rd_cartao.Checked)
                nomeTipoPagamento = "Cartão";
            else
                nomeTipoPagamento = "À Prazo";

            if (nud_QTD.Value == decimal.Parse("0,00"))
                MessageBox.Show("Quantidade Zerada \nCorrija por favor!");

            else if (nud_QTD.Value > verificaEstoque)
                MessageBox.Show("Quantidade Requerida Maior que Estoque \nCorrija por favor!");

            else if (nud_Desconto.Value >= decimal.Parse(txt_Total.Text))
                MessageBox.Show("Desconto alto demais \nCorrija por favor!");

            else if (nud_recebido.Value < decimal.Parse(txt_Total.Text))
                MessageBox.Show("Valor recebido menor que o Total \nCorrija por favor!");

            else if (decimal.Parse(txt_troco.Text) < 0)
                MessageBox.Show("Troco Negativo \nCorrija por favor!");

            else
            {
                try
                {
                    entidades.IdCliente = int.Parse(cb_Cliente.SelectedValue.ToString());
                    entidades.IdProd = int.Parse(cb_Produto.SelectedValue.ToString());
                    entidades.DtTransacao = DateTime.Parse(txt_Data.Text);
                    entidades.Qtde = int.Parse(nud_QTD.Value.ToString());
                    entidades.VlVenda = decimal.Parse(txt_Total.Text);
                    entidades.DataRecebimento = dtp_recebimento.Value;
                    entidades.TipoRecebimento = nomeTipoPagamento;

                    string nome = (cb_Cliente.SelectedItem as ClientesVo).Nome;
                    string produto = (cb_Produto.SelectedItem as ProdutosVo).Descricao;

                    if (MessageBox.Show($"Nome Cliente: {nome}" +
                                        $"\nDescrição Produto: {produto}" +
                                        $"\nQuantidade: {entidades.Qtde}" +
                                        $"\nVenda: {entidades.VendaFormatado}" +
                                        $"\nRecebimento: {entidades.PagamentoFormatado}", 
                        "Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string mensagem = _vendasBo.Salvar(entidades);
                        MessageBox.Show(mensagem);
                        Limpar();
                        FormInsereVenda_Load(sender, e);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao efetuar venda \nTente Novamente!");
                }
            }
        }

        private void cb_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_venda_banco.Text = (cb_Produto.SelectedItem as ProdutosVo).VlVenda.ToString();
                lbl_qtde_disponivel.Text = ((cb_Produto.SelectedItem as ProdutosVo).Qtde - nud_QTD.Value).ToString();
                nud_QTD.Maximum = (cb_Produto.SelectedItem as ProdutosVo).Qtde;
                nud_Desconto.Maximum = (nud_QTD.Value * decimal.Parse(txt_venda_banco.Text));
            }
            catch (Exception)
            {
                MessageBox.Show(@"Erro ao carregar a valores dos produtos");
            }
        }

        private void nud_Desconto_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Total.Text = ((decimal.Parse(txt_venda_banco.Text) * nud_QTD.Value) - nud_Desconto.Value).ToString();
                //nud_recebido.Minimum = decimal.Parse(txt_Total.Text);
                nud_recebido.Maximum = decimal.Parse(txt_Total.Text) + 100;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Erro no cálculo do Total");
            }
        }

        private void nud_recebido_ValueChanged(object sender, EventArgs e)
        {
            //if (nud_Desconto.Value > 0)
            //{
            if (nud_recebido.Value > 0)
            {
                try
                {
                    txt_troco.Text = (nud_recebido.Value - decimal.Parse(txt_Total.Text)).ToString();
                    if (decimal.Parse(txt_troco.Text) <= 0)
                        txt_troco.Text = "0";
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Erro no cálculo do troco");
                }
            }
            else
            {
                txt_troco.Text = "0";
            }
            //}
        }

        private void rd_AVista_CheckedChanged(object sender, EventArgs e)
        {
            lblRecebimento.Visible = false;
            dtp_recebimento.Visible = false;
            dtp_recebimento.Value = DateTime.Now;
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
            dtp_recebimento.Value = DateTime.Now;
        }

        private void txt_venda_banco_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Total.Text = ((decimal.Parse(txt_venda_banco.Text) * nud_QTD.Value) - nud_Desconto.Value).ToString();
                lbl_qtde_disponivel.Text = ((cb_Produto.SelectedItem as ProdutosVo).Qtde - nud_QTD.Value).ToString();
                nud_recebido_ValueChanged(sender, e);
                nud_Desconto.Maximum = (nud_QTD.Value * decimal.Parse(txt_venda_banco.Text));
            }
            catch (Exception)
            {
                MessageBox.Show(@"Erro ao carregar a valores de produtos");
            }
        }
        private void nud_QTD_ValueChanged(object sender, EventArgs e)
        {
            txt_Total.Text = ((decimal.Parse(txt_venda_banco.Text) * nud_QTD.Value) - nud_Desconto.Value).ToString();
            nud_Desconto.Maximum = (nud_QTD.Value * decimal.Parse(txt_venda_banco.Text));
            if (nud_recebido.Value > 0)
            {
                txt_venda_banco_TextChanged(sender, e);
            }
            else
            {
                txt_troco.Text = "0";
            }
            lbl_qtde_disponivel.Text = ((cb_Produto.SelectedItem as ProdutosVo).Qtde - nud_QTD.Value).ToString();
        }

        private void txt_Total_TextChanged(object sender, EventArgs e)
        {
            //nud_recebido.Minimum = decimal.Parse(txt_Total.Text);
            nud_recebido.Maximum = Convert.ToDecimal(txt_Total.Text) + 50;
        }

        private void Limpar()
        {
            txt_Data.Text = Convert.ToString(DateTime.Now);
            nud_QTD.Value = 0;
            cb_Cliente.SelectedIndex = 0;
            cb_Produto.SelectedIndex = 0;
            txt_Total.Text = "0";
            txt_troco.Text = "0";
            nud_Desconto.Value = decimal.Parse("0,00");
            nud_recebido.Value = decimal.Parse("0,00");
            lblRecebimento.Visible = false;
            dtp_recebimento.Value = DateTime.Now;
            dtp_recebimento.Visible = false;
            rd_AVista.Checked = true;
        }
    }
}