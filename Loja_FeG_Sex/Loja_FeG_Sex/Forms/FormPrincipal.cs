using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Restart();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            FormClientes novajanela = new FormClientes();
            novajanela.ShowDialog();
        }

        private void btn_Vendas_Click(object sender, EventArgs e)
        {
            FormVendas novajanela = new FormVendas();
            novajanela.ShowDialog();
        }

        private void btn_Produtos_Click(object sender, EventArgs e)
        {
            FormProdutos novajanela = new FormProdutos();
            novajanela.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
