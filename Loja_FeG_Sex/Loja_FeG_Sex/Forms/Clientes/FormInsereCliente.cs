using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;
using System;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms.Cliente
{
    public partial class FormInsereCliente : Form
    {
        private readonly ClientesBo clienteBo;
        
        public FormInsereCliente()
        {
            InitializeComponent();
            clienteBo = ClientesConstrutor.clienteBo();
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
            DateTime dt = DateTime.Now;
            txt_Data.Text = dt.ToString();//String.Format("{0:dd/MM/yyyy", dt);
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
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
            entidades.Celular = msk_Celular.Text;
            entidades.Telefone = msk_Telefone.Text;
            entidades.Rua = txt_Endereco.Text;
            entidades.Dt_Cadastro = DateTime.Parse(txt_Data.Text);
            entidades.Dt_Nasc = DateTime.Parse(dt_Nascimento.Text);
            entidades.Bairro = txt_Bairro.Text;
            entidades.Numero = int.Parse(txt_Numero.Text);
            entidades.Complemento = txt_Complemento.Text;

            string mensagem = clienteBo.Salvar(entidades);
            MessageBox.Show(mensagem);
        }
    }
}
