using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Loja_FeG_Sex.Forms.ChaLingerie
{
    public partial class FormLingeries : Form
    {
        public FormLingeries()
        {
            InitializeComponent();
        }

        private void btn_insereCliente_Click(object sender, EventArgs e)
        {
            FormInsereLingeries insereCha = new FormInsereLingeries();
            insereCha.ShowDialog();
            FormLingeries_Load(sender, e);
        }

        private void btn_editaCliente_Click(object sender, EventArgs e)
        {
            FormEditarLingeries editarCha = new FormEditarLingeries();
            editarCha.ShowDialog();
            FormLingeries_Load(sender, e);
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Lista(IEnumerable<LingeriesVo> lingerie)
        {
            try
            {
                //if (txt_Nome.Text != "")
                //    lingerie = lingerie.Where(x => (x.Cliente.Nome.Contains(txt_Nome.Text)) &&
                //                                   (x.DataEvento >= dtp_inicial.Value &&
                //                                    x.DataEvento <= dtp_final.Value));

                dtg_ChaLingerie.DataSource = lingerie.Select(x => new
                {
                    x.Cliente.Nome,
                    Data_Cadastro = x.DataCadastro,
                    Data_Evento = x.DataEvento,
                    valorFormatado = x.ValorFormatado,
                    x.Descricao
                }).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Problemas ao carregar a Lista");
            }
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {
            var lingerie = LingeriesConstrutor.LingerieBo()
               .ListarTodos(txt_Nome.Text, dtp_inicial.Value, dtp_final.Value)//().Where(x => x.Cliente.Nome.Contains(txt_Nome.Text))
               .OrderBy(x => x.Cliente.Nome);
            Lista(lingerie);
        }

        private void btn_nome_asc_Click(object sender, EventArgs e)
        {
            var lingerie = LingeriesConstrutor.LingerieBo()
               .ListarTodos(txt_Nome.Text, dtp_inicial.Value, dtp_final.Value)
               .OrderBy(x => x.Cliente.Nome);
            Lista(lingerie);
        }

        private void btn_nome_dec_Click(object sender, EventArgs e)
        {
            var lingerie = LingeriesConstrutor.LingerieBo()
               .ListarTodos(txt_Nome.Text, dtp_inicial.Value, dtp_final.Value)
               .OrderByDescending(x => x.Cliente.Nome);
            Lista(lingerie);
        }

        private void btn_transa_asc_Click(object sender, EventArgs e)
        {
            var lingerie = LingeriesConstrutor.LingerieBo()
               .ListarTodos(txt_Nome.Text, dtp_inicial.Value, dtp_final.Value)
               .OrderBy(x => x.DataEvento);
            Lista(lingerie);
        }

        private void btn_transa_dec_Click(object sender, EventArgs e)
        {
            var lingerie = LingeriesConstrutor.LingerieBo()
               .ListarTodos(txt_Nome.Text, dtp_inicial.Value, dtp_final.Value)
               .OrderByDescending(x => x.DataEvento);
            Lista(lingerie);
        }

        private void FormLingeries_Load(object sender, EventArgs e)
        {
            try
            {
                var lingerie = LingeriesConstrutor.LingerieBo().ListarTodos();
                Lista(lingerie);

                dtp_final.Value = Convert.ToDateTime("01/01/2018");
                dtp_final.MinDate = Convert.ToDateTime("28/04/2000");
                dtp_final.MaxDate = Convert.ToDateTime("28/04/2030");
                dtp_inicial.Value = Convert.ToDateTime("28/04/2000");
                dtp_inicial.MaxDate = DateTime.Now;
                

                //this.dtg_ChaLingerie.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Problemas ao montar a lista de Chás");
            }
        }

        private void dtp_inicial_ValueChanged(object sender, EventArgs e)
        {
            btn_transa_asc_Click(sender, e);
        }

        private void dtp_final_ValueChanged(object sender, EventArgs e)
        {
            btn_transa_dec_Click(sender, e);
        }
    }
}
