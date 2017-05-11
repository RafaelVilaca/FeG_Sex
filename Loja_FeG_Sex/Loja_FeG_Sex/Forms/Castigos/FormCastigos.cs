using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Loja_FeG_Sex.Business;
using Loja_FeG_Sex.Entidades;

namespace Loja_FeG_Sex.Forms.Castigos
{
    public partial class FormCastigos : Form
    {
        public FormCastigos()
        {
            InitializeComponent();
        }

        private void Lista(IEnumerable<CastigosVo> castigos)
        {
            try
            {
                //if (txt_Descricao.Text != "")
                //castigos = castigos.Where(x => (x.Descricao.Contains(txt_Descricao.Text)));

                dtg_Castigo.DataSource = castigos.Select(x => new
                {
                    x.Referente,
                    x.Descricao
                }).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Problemas ao carregar a Lista");
            }
        }

        private void FormCastigos_Load(object sender, EventArgs e)
        {
            try
            {
                var castigo = CastigoConstrutor.CastigosBo()
                    .ListarTodos(txt_Descricao.Text)
                    .OrderBy(x => x.Descricao);
                Lista(castigo);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Problemas ao montar a lista de Chás");
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_editarCha_Click(object sender, EventArgs e)
        {
            var janelaEditar = new FormEditarCastigos();
            janelaEditar.ShowDialog();
            FormCastigos_Load(sender, e);
        }

        private void btn_insereCha_Click(object sender, EventArgs e)
        {
            var janelaInserir = new FormInserirCastigos();
            janelaInserir.ShowDialog();
            FormCastigos_Load(sender, e);
        }

        private void btn_descricao_asc_Click(object sender, EventArgs e)
        {
            FormCastigos_Load(sender, e);
        }

        private void btn_descricao_dec_Click(object sender, EventArgs e)
        {
            var castigo = CastigoConstrutor.CastigosBo()
               .ListarTodos(txt_Descricao.Text)
               //.Where(x => x.Descricao.Contains(txt_Descricao.Text))
               .OrderByDescending(x => x.Descricao);
            Lista(castigo);
        }

        private void btn_pessoa_asc_Click(object sender, EventArgs e)
        {
            var castigo = CastigoConstrutor.CastigosBo()
               .ListarTodos(txt_Descricao.Text)
               .OrderBy(x => x.Referente);
            Lista(castigo);
        }

        private void btn_pessoa_desc_Click(object sender, EventArgs e)
        {
            var castigo = CastigoConstrutor.CastigosBo()
               .ListarTodos(txt_Descricao.Text)
               //.Where(x => x.Descricao.Contains(txt_Descricao.Text))
               .OrderByDescending(x => x.Referente);
            Lista(castigo);
        }

        private void txt_Descricao_TextChanged(object sender, EventArgs e)
        {
            var castigo = CastigoConstrutor.CastigosBo()
               .ListarTodos(txt_Descricao.Text)
               //.Where(x => x.Descricao.Contains(txt_Descricao.Text))
               .OrderBy(x => x.Descricao);
            Lista(castigo);
        }
    }
}
