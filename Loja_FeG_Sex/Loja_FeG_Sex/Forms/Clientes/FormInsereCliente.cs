using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms.Cliente
{
    public partial class FormInsereCliente : Form
    {
        private readonly ClientesBo clienteBo;
        //private FormClientes frm;

        public FormInsereCliente(/*FormClientes frm*/)
        {
            InitializeComponent();
            clienteBo = ClientesConstrutor.clienteBo();
            //this.frm = frm;
        }

        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInsereCliente_Load(object sender, EventArgs e)
        {
            txt_Nome.Focus();
            txt_Data.Text = DateTime.Now.ToString();
            rd_Masc.Checked = true;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            int valida = 0;

            msk_Celular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            msk_Telefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            string email = txt_Email.Text;

            Regex emailValidado = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (txt_Nome.Text.Length <= 3)
            {
                MessageBox.Show("Nome incorreto\nNão pode conter menos de 3 caracteres\nCorrija por favor!");
                valida = 1;
            }
            else if (email.Length <= 10 || !emailValidado.IsMatch(email))
            {
                MessageBox.Show("Email inválido\nCorrija por favor!");
                valida = 1;
            }
            else if(msk_Celular.Text.Length <= 10)
            {
                MessageBox.Show("Celular incorreto\nCorrija por favor!");
                valida = 1;
            }
            else if (msk_Telefone.Text.Length <= 9)
            {
                MessageBox.Show("Telefone incorreto\nCorrija por favor!");
                valida = 1;
            }
            else if (txt_Endereco.Text == "" || txt_Endereco.Text.Length <= 3)
            {
                MessageBox.Show("Rua incorreta\nCorrija por favor!");
                valida = 1;
            }
            else if (txt_Numero.Text == "" || txt_Numero.Text == "0")
            {
                MessageBox.Show("Número residencial incorreto\nCorrija por favor!");
                valida = 1;
            }
            else if (txt_Bairro.Text == "" || txt_Bairro.Text.Length <= 3)
            {
                MessageBox.Show("Bairro incorreto\nCorrija por favor!");
                valida = 1;
            }            
            else
                valida = 0;

            if (valida == 0)
            {
                ClientesVo entidades = new ClientesVo();

                string sexo = "";
                if (rd_Fem.Checked == true)
                    sexo = "F";
                else
                    sexo = "M";

                entidades.Nome = txt_Nome.Text;
                entidades.Email = txt_Email.Text;
                entidades.Sexo = sexo;
                entidades.Celular = long.Parse(msk_Celular.Text);
                entidades.Telefone = long.Parse(msk_Telefone.Text);
                entidades.Rua = txt_Endereco.Text;
                entidades.Dt_Cadastro = DateTime.Parse(txt_Data.Text);
                entidades.Dt_Nasc = DateTime.Parse(dt_Nascimento.Text);
                entidades.Bairro = txt_Bairro.Text;
                entidades.Numero = int.Parse(txt_Numero.Text);
                entidades.Complemento = txt_Complemento.Text;


                string mensagem = clienteBo.Salvar(entidades);
                MessageBox.Show(mensagem);
                Limpa();
            }
        }

        private void Limpa()
        {
            txt_Nome.Clear();
            txt_Email.Text = "";
            msk_Celular.Text = "";
            rd_Masc.Checked = true;
            msk_Telefone.Text = "";
            txt_Endereco.Text = "";
            txt_Bairro.Text = "";
            txt_Numero.Text = "";
            txt_Complemento.Text = "";
        }

        private void FormInsereCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            //frm.FormClientes_Load(sender, e);
        }

        private void msk_Celular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
