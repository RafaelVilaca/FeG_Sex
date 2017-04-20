using Loja_FeG_Sex.Forms.Cliente;
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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            FormInsereCliente novajanela = new FormInsereCliente();
            novajanela.ShowDialog();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            
        }
    }
}
