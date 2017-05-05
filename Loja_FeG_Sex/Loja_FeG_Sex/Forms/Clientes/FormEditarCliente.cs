using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms.Clientes
{
    public partial class FormEditarCliente : Form
    {
        private readonly ClientesBo _clienteBo;

        public FormEditarCliente()
        {
            InitializeComponent();
            _clienteBo = ClientesConstrutor.clienteBo();
        }

        private void FormEditarCliente_Load(object sender, EventArgs e)
        {
            IEnumerable<ClientesVo> clientes;
            clientes = ClientesConstrutor.clienteBo().ListarTodos();

            cb_Cliente.DataSource = clientes;
            cb_Cliente.ValueMember = "Id_Cliente";
            cb_Cliente.DisplayMember = "Nome";

            if ((cb_Cliente.SelectedItem as ClientesVo).Sexo == "M")
                rd_Masc.Checked = true;
            else
                rd_Fem.Checked = true;

            if ((cb_Cliente.SelectedItem as ClientesVo).Ativo)
                rd_Ativo.Checked = true;
            else
                rd_Desativo.Checked = true;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            msk_Celular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            msk_Telefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            string email = txt_Email.Text;

            Regex emailValidado = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (txt_Nome.Text.Length <= 3)
                MessageBox.Show("Nome incorreto\nNão pode conter menos de 3 caracteres\nCorrija por favor!");

            else if (email.Length <= 10 || !emailValidado.IsMatch(email))
                MessageBox.Show("Email inválido\nCorrija por favor!");

            else if (msk_Celular.Text.Length <= 10)
                MessageBox.Show("Celular incorreto\nCorrija por favor!");

            else if (msk_Telefone.Text.Length <= 9)
                MessageBox.Show("Telefone incorreto\nCorrija por favor!");

            else if (txt_Endereco.Text == "" || txt_Endereco.Text.Length <= 3)
                MessageBox.Show("Rua incorreta\nCorrija por favor!");

            else if (txt_Numero.Text == "" || txt_Numero.Text == "0")
                MessageBox.Show("Número residencial incorreto\nCorrija por favor!");

            else if (txt_Bairro.Text == "" || txt_Bairro.Text.Length <= 3)
                MessageBox.Show("Bairro incorreto\nCorrija por favor!");

            else
            {
                try
                {
                    ClientesVo entidades = new ClientesVo();
                    string sexo = "";
                    if (rd_Fem.Checked == true)
                        sexo = "F";
                    else
                        sexo = "M";

                    bool situacao = false;
                    if (rd_Ativo.Checked == true)
                        situacao = true;
                    else
                        situacao = false;

                    entidades.Id_Cliente = (cb_Cliente.SelectedItem as ClientesVo).Id_Cliente;
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
                    entidades.Ativo = situacao;

                    string sex = sexo == "M" ? "Masculino" : "Feminino";
                    if (MessageBox.Show(
                        "Nome: " + entidades.Nome +
                        "\nEmail: " + entidades.Email +
                        "\nSexo: " + sex +
                        "\nCelular: " + entidades.CelularFormatado +
                        "\nTelefone: " + entidades.TelefoneFormatado +
                        "\nData Nascimento: " + entidades.Dt_Nasc +
                        "\nEndereço: " + entidades.Endereco, "Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string mensagem = _clienteBo.Salvar(entidades);
                        MessageBox.Show(mensagem);
                        FormEditarCliente_Load(sender, e);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas ao editar Clientes \nTente Novamente!");
                }
            }
        }

        private void cb_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Bairro.Text = (cb_Cliente.SelectedItem as ClientesVo).Bairro.ToString();
                txt_Complemento.Text = (cb_Cliente.SelectedItem as ClientesVo).Complemento.ToString();
                txt_Data.Text = (cb_Cliente.SelectedItem as ClientesVo).Dt_Cadastro.ToString();
                txt_Email.Text = (cb_Cliente.SelectedItem as ClientesVo).Email.ToString();
                txt_Endereco.Text = (cb_Cliente.SelectedItem as ClientesVo).Rua.ToString();
                txt_Nome.Text = (cb_Cliente.SelectedItem as ClientesVo).Nome.ToString();
                txt_Numero.Text = (cb_Cliente.SelectedItem as ClientesVo).Numero.ToString();
                if (Convert.ToChar((cb_Cliente.SelectedItem as ClientesVo).Sexo.ToString()) == 'M')
                    rd_Masc.Checked = true;
                else
                    rd_Fem.Checked = true;
                if ((cb_Cliente.SelectedItem as ClientesVo).Ativo)
                    rd_Ativo.Checked = true;
                else
                    rd_Desativo.Checked = true;
                dt_Nascimento.Value = (cb_Cliente.SelectedItem as ClientesVo).Dt_Nasc;
                msk_Celular.Text = (cb_Cliente.SelectedItem as ClientesVo).Celular.ToString();
                msk_Telefone.Text = (cb_Cliente.SelectedItem as ClientesVo).Telefone.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar dados do Cliente");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
