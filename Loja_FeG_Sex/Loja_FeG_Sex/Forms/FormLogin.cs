using Loja_FeG_Sex.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_FeG_Sex
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {       
                InitializeComponent();
        }
        //bool verifica = false;        
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string login = txt_Login.Text.ToLower();
            string senha = txt_Senha.Text.ToLower();            
            if (login == "0")
            {
                if (senha == "1")
                {
                    Hide();
                    FormPrincipal novaform = new FormPrincipal();
                    txt_Login.Text = "";
                    txt_Senha.Text = "";
                    novaform.Show();
                }
                else
                {
                    lbl_Verificacao.Text = "Senha Incorreta";
                }
            }
            else
            {
                lbl_Verificacao.Text = "Login Incorreto";
            }
        }

        //public void Fechar()
        //{            
        //    //if(Application.OpenForms.OfType<FormPrincipal>().Count() > 0)
        //     //   this.Close();
        //}

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
