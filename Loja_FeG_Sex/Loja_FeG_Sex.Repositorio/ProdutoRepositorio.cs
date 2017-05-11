using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Loja_FeG_Sex.Repositorio
{
    public class ProdutoRepositorio : IProdutos
    {

        private Contexto _contexto;

        public IEnumerable<ProdutosVo> ListarTodos()
        {
            using (_contexto = new Contexto())
            {
                var strQuery = "Select * From Produtos ";
                strQuery += " order by Descricao asc ";
                var retorno = _contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                return ReaderObjeto(retorno);
            }
        }

        public IEnumerable<ProdutosVo> ListarTodos(string filtro)
        {
            using (_contexto = new Contexto())
            {
                var param = new List<SqlParameter>();
                param.Add(new SqlParameter() { ParameterName = "@filtro", Value = filtro });

                var strQuery = "Select * From Produtos " +
                               " Where Descricao LIKE '%'+@filtro+'%' " +
                               " order by Descricao asc ";
                var retorno = _contexto.ExecutaComRetorno(strQuery, param);
                return ReaderObjeto(retorno);
            }
        }

        public IEnumerable<ProdutosVo> ListarAtivos()
        {
            using (_contexto = new Contexto())
            {
                var strQuery = "Select p.* From Produtos p ";
                strQuery += " Where p.Ativo = 1 ";
                strQuery += " order by Descricao asc ";
                var retorno = _contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                return ReaderObjeto(retorno);
            }
        }

        public string Salvar(ProdutosVo entidade)
        {
            string mensagem;

            if (entidade.IdProd == null)
            {
                var nomeProc = "sp_insert_produto";

                using (_contexto = new Contexto())
                {
                    List<SqlParameter> param = new List<SqlParameter>();

                    param.Add(new SqlParameter() { ParameterName = "@Descricao", Value = entidade.Descricao });
                    param.Add(new SqlParameter() { ParameterName = "@Dt_Cadastro", Value = entidade.DtCadastro });
                    param.Add(new SqlParameter() { ParameterName = "@Quantidade", Value = entidade.Qtde });
                    param.Add(new SqlParameter() { ParameterName = "@Vl_Compra", Value = entidade.VlCompra });
                    param.Add(new SqlParameter() { ParameterName = "@Vl_Venda", Value = entidade.VlVenda });
                    param.Add(new SqlParameter() { ParameterName = "@Ativo", Value = entidade.Ativo });

                    mensagem = "Cadastro inserido com Sucesso!!!";

                    _contexto.ExecutaProc(nomeProc, param);
                }
            }
            else
            {
                var nomeProc = "sp_update_produto";

                using (_contexto = new Contexto())
                {
                    List<SqlParameter> param = new List<SqlParameter>();

                    param.Add(new SqlParameter() { ParameterName = "@ID", Value = entidade.IdProd });
                    param.Add(new SqlParameter() { ParameterName = "@Descricao", Value = entidade.Descricao });
                    param.Add(new SqlParameter() { ParameterName = "@Dt_Cadastro", Value = entidade.DtCadastro });
                    param.Add(new SqlParameter() { ParameterName = "@Quantidade", Value = entidade.Qtde });
                    param.Add(new SqlParameter() { ParameterName = "@Vl_Compra", Value = entidade.VlCompra });
                    param.Add(new SqlParameter() { ParameterName = "@Vl_Venda", Value = entidade.VlVenda });
                    param.Add(new SqlParameter() { ParameterName = "@Ativo", Value = entidade.Ativo });

                    mensagem = "Cadastro atualizado com Sucesso!!!";

                    _contexto.ExecutaProc(nomeProc, param);
                }
            }

            return mensagem;
        }

        private List<ProdutosVo> ReaderObjeto(SqlDataReader reader)
        {
            var produto = new List<ProdutosVo>();
            while (reader.Read())
            {
                var temObjeto = new ProdutosVo()
                {
                    IdProd = reader["Id_Prod"] != DBNull.Value ? int.Parse(reader["Id_Prod"].ToString()) : 0,
                    Descricao = reader["Descricao"] != DBNull.Value ? reader["Descricao"].ToString() : null,
                    Qtde = reader["Quantidade"] != DBNull.Value ? int.Parse(reader["Quantidade"].ToString()) : 0,
                    DtCadastro = DateTime.Parse(reader["Dt_Cadastro"].ToString()),
                    VlCompra = reader["Vl_Compra"] != DBNull.Value ? decimal.Parse(reader["Vl_Compra"].ToString()) : 0,
                    VlVenda = reader["Vl_Venda"] != DBNull.Value ? decimal.Parse(reader["Vl_Venda"].ToString()) : 0,
                    Ativo = reader["Ativo"] != DBNull.Value ? bool.Parse(reader["Ativo"].ToString()) : false
                };
                produto.Add(temObjeto);
            }
            reader.Close();
            return produto;
        }

        //public IEnumerable<ProdutosVo> ListarTodos(int id)
        //{
        //    List<SqlParameter> param = new List<SqlParameter>();
        //    param.Add(new SqlParameter() { ParameterName = "@id", Value = id });

        //    using (_contexto = new Contexto())
        //    {
        //        var strQuery = "Select * From Produtos ";
        //        strQuery += " Where IdProd = @id ";
        //        strQuery += " order by Descricao asc ";
        //        var retorno = _contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
        //        return ReaderObjeto(retorno);
        //    }
        //}

        //public IEnumerable<ProdutosVo> ListarTodos(string filtro, decimal? qtde)
        //{
        //    List<SqlParameter> param = new List<SqlParameter>();

        //    param.Add(new SqlParameter() { ParameterName = "@filtro", Value = filtro });
        //    param.Add(new SqlParameter() { ParameterName = "@qtde", Value = qtde });

        //    using (_contexto = new Contexto())
        //    {
        //        if (filtro != "" && qtde == 0)
        //        {
        //            var strQuery = "Select * From Produtos ";
        //            strQuery += " Where Descricao LIKE('%@filtro%') ";
        //            strQuery += " order by Descricao asc ";
        //            var retorno = _contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
        //            return ReaderObjeto(retorno);
        //        }
        //        else if(filtro != "" && qtde > 0)
        //        {
        //            var strQuery = "Select * From Produtos ";
        //            strQuery += " Where Descricao LIKE('%@filtro%') ";
        //            strQuery += " AND Quantidade <= @qtde ";
        //            strQuery += " order by Descricao asc ";
        //            var retorno = _contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
        //            return ReaderObjeto(retorno);
        //        }
        //        else
        //        {
        //            var strQuery = "Select * From Produtos ";
        //            strQuery += " Where Quantidade <= @qtde ";
        //            strQuery += " order by Descricao asc ";
        //            var retorno = _contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
        //            return ReaderObjeto(retorno);
        //        }
        //    }
        //}        
    }
}
