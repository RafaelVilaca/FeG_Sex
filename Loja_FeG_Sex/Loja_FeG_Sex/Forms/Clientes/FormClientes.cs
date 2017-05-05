using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;

namespace Loja_FeG_Sex.Forms.Clientes
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
            FormInsereCliente insereCliente = new FormInsereCliente(/*this*/);
            insereCliente.ShowDialog();
            FormClientes_Load(sender, e);
        }

        private void Lista(IEnumerable<ClientesVo> clientes)
        {
            try
            {
                dtg_Clientes.DataSource = clientes.Where(x => x.Nome.Contains(txt_Busca.Text))
                    .Select(x => new
                    {
                        x.Nome,
                        x.Email,
                        x.Dt_Nasc,
                        x.Dt_Cadastro,
                        x.Sexo,
                        x.TelefoneFormatado,
                        x.CelularFormatado,
                        x.Endereco,
                        x.Situacao
                    }).ToList();

                var linhas = dtg_Clientes.Rows.Cast<DataGridViewRow>();
                foreach (var r in linhas.Where(x => x.Cells[8].Value.ToString() == "Desativo"))
                {
                    //dtg_Clientes.Rows[r.Index].DefaultCellStyle.BackColor = Color.Red;
                    r.DefaultCellStyle.BackColor = Color.MistyRose;
                    r.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Problemas ao montar a lista de Clientes");
            }
        }

        public void FormClientes_Load(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos();
            Lista(clientes);
        }

        private void btn_nome_asc_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos();
            Lista(clientes);
        }

        private void btn_nome_dec_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos().OrderByDescending(x => x.Nome);
            Lista(clientes);
        }

        private void btn_dtCad_dec_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos().OrderByDescending(x => x.Dt_Cadastro);
            Lista(clientes);
        }

        private void btn_sexo_dec_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos().OrderByDescending(x => x.Sexo);
            Lista(clientes);
        }

        private void btn_sexo_asc_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos().OrderBy(x => x.Sexo);
            Lista(clientes);
        }

        private void btn_dtCad_asc_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos().OrderBy(x => x.Dt_Cadastro);
            Lista(clientes);
        }

        private void btn_Nasc_asc_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos().OrderBy(x => x.Dt_Nasc);
            Lista(clientes);
        }

        private void btn_dtNasc_dec_Click(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos().OrderByDescending(x => x.Dt_Nasc);
            Lista(clientes);
        }

        private void txt_Busca_TextChanged(object sender, EventArgs e)
        {
            var clientes = ClientesConstrutor.clienteBo().ListarTodos();
            Lista(clientes);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            FormEditarCliente editarCliente = new FormEditarCliente(/*this*/);
            editarCliente.ShowDialog();
            FormClientes_Load(sender, e);
        }
    }
}