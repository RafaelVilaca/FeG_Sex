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
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            VendasVo entidades = new VendasVo();

            if (nud_QTD.Value == decimal.Parse("0,00"))
            {
                MessageBox.Show("Quantidade Zerada\nCorrija por favor!");
            }
            else
            {
                entidades.Id_Cliente = int.Parse(cb_Cliente.SelectedValue.ToString());
                entidades.Id_Prod = int.Parse(cb_Produto.SelectedValue.ToString());
                entidades.Dt_Transacao = DateTime.Parse(txt_Data.Text);
                entidades.Qtde = int.Parse(nud_QTD.Value.ToString());
                entidades.Vl_Venda = decimal.Parse(txt_venda_banco.Text);

                string mensagem = vendasBo.Salvar(entidades);
                MessageBox.Show(mensagem);
                Limpar();
            }
        }

        private void nud_Venda_ValueChanged(object sender, EventArgs e)
        {
            //txt_Total.Text = nud_Venda.Value.ToString();
        }

        private void cb_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cb_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //var teste = cb_Produto.SelectedIndex;//ValueMember = "Id_Prod";
                //int id = 0;// int.Parse(teste.ValueMember);
                //var produtoValor = VendasConstrutor.vendasBo().ListarValor(id);
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

                throw;
            }
        }
    }
}
