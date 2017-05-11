using System;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms.Castigos
{
    public partial class FormEscolha : Form
    {
        public FormEscolha()
        {
            InitializeComponent();
        }

        private void btn_Manu_Castigos_Click(object sender, EventArgs e)
        {
            var janelaCastigos = new FormCastigos();
            janelaCastigos.ShowDialog();
        }

        private void btn_Castigos_Click(object sender, EventArgs e)
        {
            var janelaJogar = new FormJogar();
            janelaJogar.ShowDialog();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
