using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;

namespace Loja_FeG_Sex.Repositorio
{
    public class CastigosRepositorio : ICastigos
    {
        private Contexto _contexto;

        public IEnumerable<CastigosVo> ListarTodos(bool pessoa)
        {
            using (_contexto = new Contexto())
            {
                var param = new List<SqlParameter>
                {
                    new SqlParameter() {ParameterName = "@Pessoa", Value = pessoa}
                };
                //var teste = pessoa ? 1 : 0;

                var strQuery = "Select * From Castigos " +
                               " Where Pessoa = @Pessoa " +
                               " order by Descricao ";
                var retorno = _contexto.ExecutaComRetorno(strQuery, param);
                return ReaderObjeto(retorno);
            }
        }

        public IEnumerable<CastigosVo> ListarTodos(string descricao)
        {
            using (_contexto = new Contexto())
            {
                var param = new List<SqlParameter>
                {
                    new SqlParameter() {ParameterName = "@Descricao", Value = descricao}
                };
                //var teste = pessoa ? 1 : 0;
                //param.Add(new SqlParameter() { ParameterName = "@Pessoa", Value = pessoa });

                var strQuery = "Select * From Castigos " +
                               " Where Descricao LIKE '%'+@Descricao+'%' " +
                               " order by Descricao ";
                var retorno = _contexto.ExecutaComRetorno(strQuery, param);
                return ReaderObjeto(retorno);
            }
        }

        public IEnumerable<CastigosVo> ListarTodos()
        {
            using (_contexto = new Contexto())
            {
                var strQuery = "Select * From Castigos " +
                               " order by Descricao ";
                var retorno = _contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                return ReaderObjeto(retorno);
            }
        }


        public string Salvar(CastigosVo entidade)
        {
            string mensagem;

            if (entidade.IdCastigo == null)
            {
                var nomeProc = "sp_insert_castigo";

                using (_contexto = new Contexto())
                {
                    List<SqlParameter> param = new List<SqlParameter>();

                    param.Add(new SqlParameter() { ParameterName = "@Descricao", Value = entidade.Descricao });
                    param.Add(new SqlParameter() { ParameterName = "@Pessoa", Value = entidade.Pessoa });

                    mensagem = "Cadastro inserido com Sucesso!!!";

                    _contexto.ExecutaProc(nomeProc, param);
                }
            }
            else
            {
                var nomeProc = "sp_update_castigo";

                using (_contexto = new Contexto())
                {
                    List<SqlParameter> param = new List<SqlParameter>();

                    param.Add(new SqlParameter() { ParameterName = "@Id_Castigo", Value = entidade.IdCastigo });
                    param.Add(new SqlParameter() { ParameterName = "@Descricao", Value = entidade.Descricao });
                    param.Add(new SqlParameter() { ParameterName = "@Pessoa", Value = entidade.Pessoa });

                    _contexto.ExecutaProc(nomeProc, param);

                    mensagem = "Cadastro atualizado com Sucesso!!!";
                }
            }

            return mensagem;
        }

        private List<CastigosVo> ReaderObjeto(SqlDataReader reader)
        {
            var castigo = new List<CastigosVo>();
            while (reader.Read())
            {
                var temObjeto = new CastigosVo()
                {
                    IdCastigo = reader["Id_Castigo"] != DBNull.Value ? int.Parse(reader["Id_Castigo"].ToString()) : 0,
                    Descricao = reader["Descricao"] != DBNull.Value ? reader["Descricao"].ToString() : null,
                    Pessoa = reader["Pessoa"] != DBNull.Value ? bool.Parse(reader["Pessoa"].ToString()) : false
                };
                castigo.Add(temObjeto);
            }
            reader.Close();
            return castigo;
        }
    }
}

