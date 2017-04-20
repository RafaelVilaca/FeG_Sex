using Loja_FeG_Sex.Forms.Produtos;
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormInsereProduto novajanela = new FormInsereProduto();
            novajanela.ShowDialog();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
