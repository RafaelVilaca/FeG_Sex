using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Forms.Cliente;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            FormInsereCliente novajanela = new FormInsereCliente(/*this*/);
            novajanela.ShowDialog();
            FormClientes_Load(sender, e);
        }

        private object Lista(IEnumerable<ClientesVo> clientes)
        {
            object Cliente;
            try
            {
                if (txt_Busca.Text == "")
                    Cliente = clientes.Select(x => new
                    {
                        x.Nome,
                        x.Email,
                        x.Dt_Nasc,
                        x.Dt_Cadastro,
                        x.Sexo,
                        x.TelefoneFormatado,
                        x.CelularFormatado,
                        x.Endereco
                    }).ToList();
                else
                    Cliente = clientes
                        .Where(x => x.Nome.Contains(txt_Busca.Text))
                        .Select(x => new
                        {
                            x.Nome,
                            x.Email,
                            x.Dt_Nasc,
                            x.Dt_Cadastro,
                            x.Sexo,
                            x.TelefoneFormatado,
                            x.CelularFormatado,
                            x.Endereco
                        }).ToList();
            }
            catch (Exception)
            {
                Cliente = clientes
                .Where(x => x.Nome.Contains(txt_Busca.Text))
                .Select(x => new
                {
                    x.Nome,
                    x.Email,
                    x.Dt_Nasc,
                    x.Dt_Cadastro,
                    x.Sexo,
                    x.TelefoneFormatado,
                    x.CelularFormatado,
                    x.Endereco
                }).ToList();
            }
            return Cliente;
        }

        public void FormClientes_Load(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos();
            dtg_Clientes.DataSource = Lista(clientes);
        }

        private void btn_nome_asc_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos();
            dtg_Clientes.DataSource = Lista(clientes);
        }

        private void btn_nome_dec_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos().OrderByDescending(x => x.Nome);
            dtg_Clientes.DataSource = Lista(clientes);
        }

        private void btn_dtCad_dec_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos().OrderByDescending(x => x.Dt_Cadastro);
            dtg_Clientes.DataSource = Lista(clientes);
        }

        private void btn_sexo_dec_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos().OrderByDescending(x => x.Sexo);
            dtg_Clientes.DataSource = Lista(clientes);
        }

        private void btn_sexo_asc_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos().OrderBy(x => x.Sexo);
            dtg_Clientes.DataSource = Lista(clientes);
        }

        private void btn_dtCad_asc_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos().OrderBy(x => x.Dt_Cadastro);
            dtg_Clientes.DataSource = Lista(clientes);
            dtg_Clientes.Refresh();
        }

        private void btn_Nasc_asc_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos().OrderBy(x => x.Dt_Nasc);
            dtg_Clientes.DataSource = Lista(clientes);
        }

        private void btn_dtNasc_dec_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos().OrderByDescending(x => x.Dt_Nasc);
            dtg_Clientes.DataSource = Lista(clientes);
        }

        private void txt_Busca_TextChanged(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos();
            dtg_Clientes.DataSource = Lista(clientes);
        }
    }
}