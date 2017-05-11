using System;
using System.Windows.Forms;
using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;

namespace Loja_FeG_Sex.Forms.Clientes
{
    public partial class FormInsereCliente : Form
    {
        private readonly ClientesBo _clienteBo;
        //private FormClientes frm;

        public FormInsereCliente(/*FormClientes frm*/)
        {
            InitializeComponent();
            _clienteBo = ClientesConstrutor.ClienteBo();
            //this.frm = frm;
        }

        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormInsereCliente_Load(object sender, EventArgs e)
        {
            txt_Nome.Focus();
            txt_Data.Text = DateTime.Now.ToString();
            rd_Masc.Checked = true;
            rd_Ativo.Checked = true;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            msk_Celular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            msk_Telefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            string email = txt_Email.Text;

            //Regex emailValidado = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (txt_Nome.Text.Trim().Length <= 3)
                MessageBox.Show("Nome incorreto" +
                                "\nNão pode conter menos de 3 caracteres" +
                                "\nCorrija por favor!");

            //else if (email.Length <= 10 || !emailValidado.IsMatch(email))
            //    MessageBox.Show("Email inválido\nCorrija por favor!");

            else if (msk_Celular.Text.Length <= 10)
                MessageBox.Show("Celular incorreto" +
                                "\nCorrija por favor!");

            //else if (msk_Telefone.Text.Length <= 9)
            //    MessageBox.Show("Telefone incorreto\nCorrija por favor!");

            //else if (txt_Endereco.Text == "" || txt_Endereco.Text.Length <= 3)
            //    MessageBox.Show("Rua incorreta\nCorrija por favor!");

            //else if (txt_Numero.Text == "" || txt_Numero.Text == "0")
            //    MessageBox.Show("Número residencial incorreto\nCorrija por favor!");

            //else if (txt_Bairro.Text == "" || txt_Bairro.Text.Length <= 3)
            //    MessageBox.Show("Bairro incorreto\nCorrija por favor!");

            else
            {
                try
                {
                    ClientesVo entidades = new ClientesVo();

                    if (msk_Telefone.Text.Length < 5)
                        msk_Telefone.Text = "1600000000";

                    string sexo;
                    if (rd_Fem.Checked)
                        sexo = "F";
                    else
                        sexo = "M";

                    bool situacao;
                    if (rd_Ativo.Checked)
                        situacao = true;
                    else
                        situacao = false;

                    entidades.Nome = txt_Nome.Text;
                    entidades.Email = txt_Email.Text;
                    entidades.Sexo = sexo;
                    entidades.Celular = long.Parse(msk_Celular.Text);
                    entidades.Telefone = long.Parse(msk_Telefone.Text);//msk_Telefone.Text.Length > 0 ? long.Parse(msk_Telefone.Text) : 1111111;
                    entidades.Rua = txt_Endereco.Text;
                    entidades.DtCadastro = DateTime.Parse(txt_Data.Text);
                    entidades.DtNasc = DateTime.Parse(dt_Nascimento.Text);
                    entidades.Bairro = txt_Bairro.Text;
                    entidades.Numero = txt_Numero.Text.Length > 0 ? int.Parse(txt_Numero.Text) : 0;
                    entidades.Complemento = txt_Complemento.Text;
                    entidades.Ativo = situacao;

                    string sex = sexo == "M" ? "Masculino" : "Feminino";

                    if (MessageBox.Show(
                        $"Nome: {entidades.Nome}" +
                        $"\nEmail: {entidades.Email}" +
                        $"\nSexo: {sex}" +
                        $"\nCelular: {entidades.CelularFormatado}" +
                        $"\nTelefone: {entidades.TelefoneFormatado}" +
                        $"\nData Nascimento: {entidades.DtNasc}" +
                        $"\nEndereço: {entidades.Endereco}", 
                        @"Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string mensagem = _clienteBo.Salvar(entidades);
                        MessageBox.Show(mensagem);
                        Limpa();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas ao inserir Cliente " +
                                    "\nTente Novamente!");
                }
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
        
        private void msk_Celular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
