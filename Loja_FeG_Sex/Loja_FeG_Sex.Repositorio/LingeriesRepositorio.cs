using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Loja_FeG_Sex.Repositorio
{
    public class LingeriesRepositorio : ILingeries
    {
        private Contexto contexto;

        public IEnumerable<LingeriesVo> ListarTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuery = "Select cl.*, c.Nome as Nome From ChaLingerie cl ";
                strQuery += " INNER JOIN Clientes c ";
                strQuery += " on cl.Id_Cliente = c.Id_Cliente ";
                strQuery += " order by c.Nome ";
                var retorno = contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                return ReaderObjeto(retorno);
            }
        }

        public string Salvar(LingeriesVo entidade)
        {
            var mensagem = "";

            if (entidade.Id_ChaLingerie == null)
            {
                var nomeProc = "sp_insert_cha";

                using (contexto = new Contexto())
                {
                    List<SqlParameter> param = new List<SqlParameter>();

                    param.Add(new SqlParameter() { ParameterName = "@Descricao", Value = entidade.Descricao });
                    param.Add(new SqlParameter() { ParameterName = "@Data_Cadastro", Value = entidade.Data_Cadastro });
                    param.Add(new SqlParameter() { ParameterName = "@Id_Cliente", Value = entidade.Id_Cliente });
                    param.Add(new SqlParameter() { ParameterName = "@Vl_Receber", Value = entidade.Vl_Receber });
                    param.Add(new SqlParameter() { ParameterName = "@Data_Evento", Value = entidade.Data_Evento });

                    mensagem = "Cadastro inserido com Sucesso!!!";

                    contexto.ExecutaProc(nomeProc, param);
                }
            }
            else
            {
                var nomeProc = "sp_update_cha";

                using (contexto = new Contexto())
                {
                    List<SqlParameter> param = new List<SqlParameter>();

                    param.Add(new SqlParameter() { ParameterName = "@Id_ChaLingerie", Value = entidade.Id_ChaLingerie });
                    param.Add(new SqlParameter() { ParameterName = "@Descricao", Value = entidade.Descricao });
                    param.Add(new SqlParameter() { ParameterName = "@Data_Cadastro", Value = entidade.Data_Cadastro });
                    param.Add(new SqlParameter() { ParameterName = "@Id_Cliente", Value = entidade.Id_Cliente });
                    param.Add(new SqlParameter() { ParameterName = "@Vl_Receber", Value = entidade.Vl_Receber });
                    param.Add(new SqlParameter() { ParameterName = "@Data_Evento", Value = entidade.Data_Evento });

                    contexto.ExecutaProc(nomeProc, param);

                    mensagem = "Cadastro atualizado com Sucesso!!!";
                }
            }

            return mensagem.ToString();
        }

        private List<LingeriesVo> ReaderObjeto(SqlDataReader reader)
        {
            var chaLingerie = new List<LingeriesVo>();
            while (reader.Read())
            {
                var clientes = new ClientesVo
                {
                    Id_Cliente = int.Parse(reader["Id_Cliente"].ToString()),
                    Nome = reader["Nome"].ToString()
                };

                var temObjeto = new LingeriesVo()
                {
                    Id_ChaLingerie = reader["Id_ChaLingerie"] != DBNull.Value ? int.Parse(reader["Id_ChaLingerie"].ToString()) : 0,
                    Descricao = reader["Descricao"] != DBNull.Value ? reader["Descricao"].ToString() : null,
                    Data_Cadastro = DateTime.Parse(reader["Data_Cadastro"].ToString()),
                    Data_Evento = DateTime.Parse(reader["Data_Evento"].ToString()),
                    Vl_Receber = reader["Vl_Receber"] != DBNull.Value ? decimal.Parse(reader["Vl_Receber"].ToString()) : 0,
                    Cliente = clientes
                };
                chaLingerie.Add(temObjeto);
            }
            reader.Close();
            return chaLingerie;
        }
    }
}
