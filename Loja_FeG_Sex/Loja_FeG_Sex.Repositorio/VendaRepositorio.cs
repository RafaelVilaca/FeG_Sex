using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Loja_FeG_Sex.Repositorio
{
    public class VendaRepositorio : IVendas
    {
        private Contexto _contexto;

        public IEnumerable<VendasVo> ListarTodos()
        {
            using (_contexto = new Contexto())
            {
                var strQuery = "Select v.*, c.Nome as Nome_Cliente, p.Descricao as Desc_Produto From Vendas v " +
                                " INNER JOIN Clientes c " +
                                " on c.Id_Cliente = v.Id_Cliente " +
                                " INNER JOIN Produtos p " +
                                " on p.Id_Prod = v.Id_Produto " +
                                " order by v.Id_Vendas asc ";
                var retorno = _contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                return ReaderObjeto(retorno);
            }
        }

        public IEnumerable<VendasVo> ListarTodos(string filtroNome, string filtroProduto, DateTime? dataInicial, DateTime? dataFinal)
        {
            using (_contexto = new Contexto())
            {
                var param = new List<SqlParameter>
                {
                    new SqlParameter() {ParameterName = "@filtroNome", Value = filtroNome},
                    new SqlParameter() {ParameterName = "@filtroProduto", Value = filtroProduto},
                    new SqlParameter() {ParameterName = "@dt_inicial", Value = dataInicial},
                    new SqlParameter() {ParameterName = "@dt_final", Value = dataFinal}
                };
                var strQuery = "Select v.*, c.Nome as Nome_Cliente, p.Descricao as Desc_Produto From Vendas v " +
                               " INNER JOIN Clientes c " +
                               " on c.Id_Cliente = v.Id_Cliente " +
                               " INNER JOIN Produtos p " +
                               " on p.Id_Prod = v.Id_Produto " +
                               " Where v.Dt_Transacao Between @dt_inicial AND @dt_final " +
                               " AND c.Nome LIKE ('%'+@filtroNome+'%') " +
                               " AND p.Descricao LIKE ('%'+@filtroProduto+'%') " +
                               " order by v.Id_Vendas asc ";
                var retorno = _contexto.ExecutaComRetorno(strQuery, param);
                return ReaderObjeto(retorno);
            }
        }

        public string Salvar(VendasVo entidade)
        {
            string mensagem;

            //if (entidade.IdVenda == 0)
            //{
            var nomeProc = "sp_insert_venda";

            using (_contexto = new Contexto())
            {
                List<SqlParameter> param = new List<SqlParameter>
                {
                    new SqlParameter() {ParameterName = "@Id_Cliente", Value = entidade.IdCliente},
                    new SqlParameter() {ParameterName = "@Id_Prod", Value = entidade.IdProd},
                    new SqlParameter() {ParameterName = "@Quantidade", Value = entidade.Qtde},
                    new SqlParameter() {ParameterName = "@Dt_Transacao", Value = entidade.DtTransacao},
                    new SqlParameter() {ParameterName = "@Vl_Venda", Value = entidade.VlVenda},
                    new SqlParameter() {ParameterName = "@Dt_Pagamento", Value = entidade.DataRecebimento},
                    new SqlParameter() {ParameterName = "@Tipo_Pagamento", Value = entidade.TipoRecebimento}
                };


                mensagem = "Cadastro inserido com Sucesso!!!";

                _contexto.ExecutaProc(nomeProc, param);
            }
            //}
            //else
            //{
            //    var nomeProc = "sp_update_venda";

            //    List<SqlParameter> param = new List<SqlParameter>();

            //param.Add(new SqlParameter() { ParameterName = "@IdVenda", Value = entidade.IdVenda });
            //param.Add(new SqlParameter() { ParameterName = "@IdCliente", Value = entidade.IdCliente });
            //param.Add(new SqlParameter() { ParameterName = "@IdProd", Value = entidade.IdProd });
            //param.Add(new SqlParameter() { ParameterName = "@Quantidade", Value = entidade.Qtde });
            //param.Add(new SqlParameter() { ParameterName = "@DtTransacao", Value = entidade.DtTransacao });
            //param.Add(new SqlParameter() { ParameterName = "@VlVenda", Value = entidade.VlVenda });
            //param.Add(new SqlParameter() { ParameterName = "@Dt_Pagamento", Value = entidade.DataRecebimento });
            //param.Add(new SqlParameter() { ParameterName = "@Tipo_Pagamento", Value = entidade.TipoRecebimento });

            //    _contexto.ExecutaProc(nomeProc, param);

            //    mensagem = "Cadastro atualizado com Sucesso!!!";
            //}

            return mensagem;
        }

        private List<VendasVo> ReaderObjeto(SqlDataReader reader)
        {
            var venda = new List<VendasVo>();
            while (reader.Read())
            {
                var cliente = new ClientesVo()
                {
                    IdCliente = int.Parse(reader["Id_Cliente"].ToString()),
                    Nome = reader["Nome_Cliente"].ToString()
                };
                var produto = new ProdutosVo()
                {
                    IdProd = int.Parse(reader["Id_Produto"].ToString()),
                    Descricao = reader["Desc_Produto"].ToString(),
                    VlVenda = decimal.Parse(reader["Vl_Venda"].ToString())
                };
                var temObjeto = new VendasVo()
                {
                    Produto = produto,
                    Cliente = cliente,
                    Qtde = reader["Quantidade"] != DBNull.Value ? int.Parse(reader["Quantidade"].ToString()) : 0,
                    DtTransacao = DateTime.Parse(reader["Dt_Transacao"].ToString()),
                    VlVenda = reader["Vl_Venda"] != DBNull.Value ? decimal.Parse(reader["Vl_Venda"].ToString()) : 0,
                    DataRecebimento = DateTime.Parse(reader["Data_Pagamento"].ToString()),
                    TipoRecebimento = reader["Tipo_Pagamento"] != DBNull.Value ? reader["Tipo_Pagamento"].ToString() : ""
                };
                venda.Add(temObjeto);
            }
            reader.Close();
            return venda;
        }
    }
}
