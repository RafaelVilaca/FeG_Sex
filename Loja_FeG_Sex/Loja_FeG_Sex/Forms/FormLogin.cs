using System;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms
{
    public partial class FormLogin : Form
    {
        private readonly string _log = "F&G";
        private readonly string _sen = "sex2017";

        public FormLogin()
        {
            InitializeComponent();
        }
               
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string login = txt_Login.Text;
            string senha = txt_Senha.Text.ToLower();
            if (login == _log)
            {
                if (senha == _sen)
                {
                    Hide();
                    FormPrincipal novaform = new FormPrincipal();
                    txt_Login.Text = "";
                    txt_Senha.Text = "";
                    novaform.Show();
                }
                else
                {
                    lbl_Verificacao.Text = @"Senha Incorreta!!!";
                }
            }
            else
            {
                lbl_Verificacao.Text = @"Login Incorreto!!!";
            }
        }
        
        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
