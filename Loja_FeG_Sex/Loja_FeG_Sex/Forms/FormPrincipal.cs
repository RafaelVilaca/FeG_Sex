using Loja_FeG_Sex.Forms.ChaLingerie;
using System;
using System.Windows.Forms;
using Loja_FeG_Sex.Forms.Castigos;
using Loja_FeG_Sex.Forms.Clientes;
using Loja_FeG_Sex.Forms.Produtos;
using Loja_FeG_Sex.Forms.Vendas;

namespace Loja_FeG_Sex.Forms
{
    public partial class FormPrincipal : Form
    {        
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
            //Application.Restart();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            FormClientes janelaCliente = new FormClientes();
            janelaCliente.ShowDialog();
        }

        private void btn_Vendas_Click(object sender, EventArgs e)
        {
            FormVendas janelaVendas = new FormVendas();
            janelaVendas.ShowDialog();
        }

        private void btn_Produtos_Click(object sender, EventArgs e)
        {
            FormProdutos janelaProdutos = new FormProdutos();
            janelaProdutos.ShowDialog();
        }

        private void btn_ChaLingerie_Click(object sender, EventArgs e)
        {
            FormLingeries janelaCha = new FormLingeries();
            janelaCha.ShowDialog();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //btn_Sair_Click(sender, e);
            Application.Restart();
        }

        private void btn_Castigos_Click(object sender, EventArgs e)
        {
            FormEscolha janelaCastigos = new FormEscolha();
            this.Visible = false;
            janelaCastigos.ShowDialog();
            Visible = true;
        }
    }
}
