using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Loja_FeG_Sex.Repositorio
{
    public class ProdutoRepositorio : IProdutos
    {

        private Contexto contexto;

        public IEnumerable<ProdutosVo> ListarTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuery = "Select * From Produtos ";
                strQuery += " order by Descricao asc ";
                var retorno = contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                return ReaderObjeto(retorno);
            }
        }

        public IEnumerable<ProdutosVo> ListarTodos(int id)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter() { ParameterName = "@id", Value = id });

            using (contexto = new Contexto())
            {
                var strQuery = "Select * From Produtos ";
                strQuery += " Where Id_Prod = @id ";
                strQuery += " order by Descricao asc ";
                var retorno = contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                return ReaderObjeto(retorno);
            }
        }

        public IEnumerable<ProdutosVo> ListarTodos(string filtro, decimal? qtde)
        {
            List<SqlParameter> param = new List<SqlParameter>();

            param.Add(new SqlParameter() { ParameterName = "@filtro", Value = filtro });
            param.Add(new SqlParameter() { ParameterName = "@qtde", Value = qtde });

            using (contexto = new Contexto())
            {
                if (filtro != "" && qtde == 0)
                {
                    var strQuery = "Select * From Produtos ";
                    strQuery += " Where Descricao LIKE('%@filtro%') ";
                    strQuery += " order by Descricao asc ";
                    var retorno = contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                    return ReaderObjeto(retorno);
                }
                else if(filtro != "" && qtde > 0)
                {
                    var strQuery = "Select * From Produtos ";
                    strQuery += " Where Descricao LIKE('%@filtro%') ";
                    strQuery += " AND Quantidade <= @qtde ";
                    strQuery += " order by Descricao asc ";
                    var retorno = contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                    return ReaderObjeto(retorno);
                }
                else
                {
                    var strQuery = "Select * From Produtos ";
                    strQuery += " Where Quantidade <= @qtde ";
                    strQuery += " order by Descricao asc ";
                    var retorno = contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                    return ReaderObjeto(retorno);
                }
            }
        }

        public string Salvar(ProdutosVo entidade)
        {
            var mensagem = "";

            if (entidade.Id_Prod == 0)
            {
                var nomeProc = "sp_insert_produto";

                using (contexto = new Contexto())
                {
                    List<SqlParameter> param = new List<SqlParameter>();

                    param.Add(new SqlParameter() { ParameterName = "@Descricao", Value = entidade.Descricao });
                    param.Add(new SqlParameter() { ParameterName = "@Dt_Cadastro", Value = entidade.Dt_Cadastro });
                    param.Add(new SqlParameter() { ParameterName = "@Quantidade", Value = entidade.Qtde });
                    param.Add(new SqlParameter() { ParameterName = "@Vl_Compra", Value = entidade.Vl_Compra });
                    param.Add(new SqlParameter() { ParameterName = "@Vl_Venda", Value = entidade.Vl_Venda });

                    mensagem = "Cadastro inserido com Sucesso!!!";

                    contexto.ExecutaProc(nomeProc, param);
                }
            }
            else
            {
                var nomeProc = "sp_update_produto";

                List<SqlParameter> param = new List<SqlParameter>();

                param.Add(new SqlParameter() { ParameterName = "@ID", Value = entidade.Id_Prod });
                param.Add(new SqlParameter() { ParameterName = "@Descricao", Value = entidade.Descricao });
                param.Add(new SqlParameter() { ParameterName = "@Dt_Cadastro", Value = entidade.Dt_Cadastro });
                param.Add(new SqlParameter() { ParameterName = "@Quantidade", Value = entidade.Qtde });
                param.Add(new SqlParameter() { ParameterName = "@Vl_Compra", Value = entidade.Vl_Compra });
                param.Add(new SqlParameter() { ParameterName = "@Vl_Venda", Value = entidade.Vl_Venda });

                contexto.ExecutaProc(nomeProc, param);

                mensagem = "Cadastro atualizado com Sucesso!!!";
            }

            return mensagem.ToString();
        }

        private List<ProdutosVo> ReaderObjeto(SqlDataReader reader)
        {
            var produto = new List<ProdutosVo>();
            while (reader.Read())
            {
                var temObjeto = new ProdutosVo()
                {
                    Id_Prod = reader["Id_Prod"] != DBNull.Value ? int.Parse(reader["Id_Prod"].ToString()) : 0,
                    Descricao = reader["Descricao"] != DBNull.Value ? reader["Descricao"].ToString() : null,
                    Qtde = reader["Quantidade"] != DBNull.Value ? int.Parse(reader["Quantidade"].ToString()) : 0,
                    Dt_Cadastro = DateTime.Parse(reader["Dt_Cadastro"].ToString()),
                    Vl_Compra = reader["Vl_Compra"] != DBNull.Value ? decimal.Parse(reader["Vl_Compra"].ToString()) : 0,
                    Vl_Venda = reader["Vl_Venda"] != DBNull.Value ? decimal.Parse(reader["Vl_Venda"].ToString()) : 0
                };
                produto.Add(temObjeto);
            }
            reader.Close();
            return produto;
        }
    }
}
