using Loja_FeG_Sex.Forms.Vendas;
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
        }
    }
}
