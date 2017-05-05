﻿using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms.ChaLingerie
{
    public partial class FormInsereLingeries : Form
    {
        private readonly LingeriesBo _lingerieBo;
        public FormInsereLingeries()
        {
            InitializeComponent();
            _lingerieBo = LingeriesConstrutor.lingerieBo();
        }

        private void FormInsereLingeries_Load(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<ClientesVo> clientes;

                clientes = ClientesConstrutor.clienteBo().ListarAtivos();

                cb_Cliente.DataSource = clientes;
                cb_Cliente.ValueMember = "Id_Cliente";
                cb_Cliente.DisplayMember = "Nome";

                dtp_Evento.MinDate = DateTime.Now;
                dtp_Evento.MaxDate = DateTime.Parse("01/01/2030");

                nud_Valor.Value = 0;
                txt_Descricao.Text = "";

                txt_dtCadastro.Text = DateTime.Now.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas ao montar o combo na lista de Clientes \nTente Novamente!");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            LingeriesVo entidades = new LingeriesVo();

            if (nud_Valor.Value == decimal.Parse("0,00"))
                MessageBox.Show("Valor Zerado \nCorrija por favor!");
            
            else if (txt_Descricao.Text.Trim() == "" || txt_Descricao.Text.Trim().Length <= 10)
                MessageBox.Show("Descrição inválida \nNão pode conter menos de 10 caracteres \nCorrija por favor!");
            
            else
            {
                try
                {
                    entidades.Id_Cliente = int.Parse(cb_Cliente.SelectedValue.ToString());
                    entidades.Data_Cadastro = DateTime.Parse(txt_dtCadastro.Text);
                    entidades.Data_Evento = dtp_Evento.Value;
                    entidades.Descricao = txt_Descricao.Text;
                    entidades.Vl_Receber = nud_Valor.Value;

                    string nome = (cb_Cliente.SelectedItem as ClientesVo).Nome;

                    if (MessageBox.Show(
                        "Nome Cliente: " + nome +
                        "\nData do Evento: " + entidades.Data_Evento +
                        "\nDados do Chá: " + entidades.Descricao +
                        "\nRecebimento: " + entidades.valorFormatado,
                        "Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string mensagem = _lingerieBo.Salvar(entidades);
                        MessageBox.Show(mensagem);
                        FormInsereLingeries_Load(sender, e);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Problemas ao inserir os dados do Chá");
                }
            }
        }
    }
}
