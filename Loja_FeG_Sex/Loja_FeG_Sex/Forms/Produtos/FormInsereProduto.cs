using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;
using System;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms.Produtos
{
    public partial class FormInsereProduto : Form
    {
        private readonly ProdutosBo produtosBo;

        public FormInsereProduto()
        {
            InitializeComponent();
            produtosBo = ProdutosConstrutor.produtosBo();
        }

        private void Limpar()
        {
            txt_Descricao.Text = "";
            txt_Data.Text = Convert.ToString(DateTime.Now);
            nud_Qtd.Value = 0;
            nup_compra.Value = (decimal)0.00;
            nup_venda.Value  = (decimal)0.00;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //msk_Venda.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            //msk_Unidade.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            //string unidadeFormatado =
            //    $"{msk_Unidade.Text.Substring(msk_Unidade.TextLength - 7,1)},{msk_Unidade.Text.Substring(msk_Unidade.TextLength - 6, 2)}";

            //string vendaFormatada =
            //    $"{msk_Venda.Text.Substring(msk_Venda.TextLength - 7,1)},{msk_Venda.Text.Substring(msk_Venda.TextLength - 6, 2)}";

            if (txt_Descricao.Text == "" || txt_Descricao.Text.Length <= 3)
            {
                MessageBox.Show("Descricao Incorreta\nCorrija por favor!");
            }
            else if (nud_Qtd.Value == 0)
            {
                MessageBox.Show("Quantidade Incorreta\nCorrija por favor!");
            }
            else if (nup_compra.Value == (decimal)0.00)
            {
                MessageBox.Show("Valor de Compra Incorreto\nCorrija por favor!");
            }
            else if (nup_venda.Value == (decimal)0.00)
            {
                MessageBox.Show("Valor de Venda Incorreto\nCorrija por favor!");
            }
            else if (nup_venda.Value < nup_compra.Value)
            {
                MessageBox.Show("Valor de Venda não pode ser menor que de Compra\nCorrija por favor!");
            }
            else
            {
                ProdutosVo entidades = new ProdutosVo();

                entidades.Descricao = txt_Descricao.Text;
                entidades.Vl_Compra = nup_compra.Value;
                entidades.Vl_Venda = nup_venda.Value;
                entidades.Dt_Cadastro = DateTime.Parse(txt_Data.Text);
                entidades.Qtde = int.Parse(nud_Qtd.Text);

                string mensagem = produtosBo.Salvar(entidades);
                MessageBox.Show(mensagem);
                Limpar();
            }
        }

        private void FormInsereProduto_Load(object sender, EventArgs e)
        {
            txt_Data.Text = Convert.ToString(DateTime.Now);
        }
    }
}
