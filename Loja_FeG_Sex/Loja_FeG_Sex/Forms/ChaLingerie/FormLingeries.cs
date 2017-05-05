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
                if (txt_Nome.Text != "")
                    lingerie = lingerie.Where(x => (x.Cliente.Nome.Contains(txt_Nome.Text)) &&
                                                   (x.Data_Evento >= dtp_inicial.Value &&
                                                    x.Data_Evento <= dtp_final.Value));

                dtg_ChaLingerie.DataSource = lingerie.Select(x => new
                {
                    x.Cliente.Nome,
                    x.Data_Cadastro,
                    x.Data_Evento,
                    x.valorFormatado,
                    x.Descricao
                }).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas ao carregar a Lista");
            }
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {
            var lingerie = LingeriesConstrutor.lingerieBo()
               .ListarTodos().Where(x => x.Cliente.Nome.Contains(txt_Nome.Text))
               .OrderBy(x => x.Cliente.Nome);
            Lista(lingerie);
        }

        private void btn_nome_asc_Click(object sender, EventArgs e)
        {
            var lingerie = LingeriesConstrutor.lingerieBo()
               .ListarTodos()
               .OrderBy(x => x.Cliente.Nome);
            Lista(lingerie);
        }

        private void btn_nome_dec_Click(object sender, EventArgs e)
        {
            var lingerie = LingeriesConstrutor.lingerieBo()
               .ListarTodos()
               .OrderByDescending(x => x.Cliente.Nome);
            Lista(lingerie);
        }

        private void btn_transa_asc_Click(object sender, EventArgs e)
        {
            var lingerie = LingeriesConstrutor.lingerieBo()
               .ListarTodos()
               .OrderBy(x => x.Data_Evento);
            Lista(lingerie);
        }

        private void btn_transa_dec_Click(object sender, EventArgs e)
        {
            var lingerie = LingeriesConstrutor.lingerieBo()
               .ListarTodos()
               .OrderByDescending(x => x.Data_Evento);
            Lista(lingerie);
        }

        private void FormLingeries_Load(object sender, EventArgs e)
        {
            try
            {
                var lingerie = LingeriesConstrutor.lingerieBo().ListarTodos();
                Lista(lingerie);

                dtp_final.Value = DateTime.Now;
                dtp_inicial.Value = Convert.ToDateTime("28/04/2000");
                dtp_inicial.MaxDate = DateTime.Now;
                dtp_final.MinDate = Convert.ToDateTime("28/04/2000");

                //this.dtg_ChaLingerie.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Problemas ao montar a lista de Chás");
            }
        }
    }
}
