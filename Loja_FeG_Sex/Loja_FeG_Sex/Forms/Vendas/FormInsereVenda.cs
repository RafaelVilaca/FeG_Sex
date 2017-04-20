using Loja_FeG_Sex.Forms.Calculadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms.Vendas
{
    public partial class FormInsereVenda : Form
    {
        public FormInsereVenda()
        {
            InitializeComponent();
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
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
