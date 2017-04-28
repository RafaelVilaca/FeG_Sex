using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Loja_FeG_Sex.Repositorio
{
    public class ClienteRepositorio : ICliente
    {
        private Contexto contexto;

        public IEnumerable<ClientesVo> ListarTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuery = "Select * From Clientes ";
                strQuery += " order by Nome ";
                var retorno = contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                return ReaderObjeto(retorno);
            }
        }

        public IEnumerable<ClientesVo> ListarTodos(string filtro)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter() { ParameterName = "@filtro", Value = filtro });
                       
            using (contexto = new Contexto())
            {
                var strQuery = "Select * From Clientes ";
                strQuery += " where Nome Like('%@filtro%') ";
                strQuery += " order by Nome ";
                var retorno = contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                return ReaderObjeto(retorno);
            }
        }

        public string Salvar(ClientesVo entidade)
        {
            var mensagem = "";

            if (entidade.Id_Cliente == 0)
            {
                var nomeProc = "sp_insert_cliente";

                using (contexto = new Contexto())
                {
                    List<SqlParameter> param = new List<SqlParameter>();

                    param.Add(new SqlParameter() { ParameterName = "@Nome", Value = entidade.Nome });
                    param.Add(new SqlParameter() { ParameterName = "@Email", Value = entidade.Email });
                    param.Add(new SqlParameter() { ParameterName = "@Sexo", Value = entidade.Sexo });
                    param.Add(new SqlParameter() { ParameterName = "@Dt_Nasc", Value = entidade.Dt_Nasc });
                    param.Add(new SqlParameter() { ParameterName = "@Dt_Cadastro", Value = entidade.Dt_Cadastro });
                    param.Add(new SqlParameter() { ParameterName = "@Rua", Value = entidade.Rua });
                    param.Add(new SqlParameter() { ParameterName = "@Numero", Value = entidade.Numero });
                    param.Add(new SqlParameter() { ParameterName = "@Bairro", Value = entidade.Bairro });
                    param.Add(new SqlParameter() { ParameterName = "@Complemento", Value = entidade.Complemento });
                    param.Add(new SqlParameter() { ParameterName = "@Celular", Value = entidade.Celular });
                    param.Add(new SqlParameter() { ParameterName = "@Telefone", Value = entidade.Telefone });

                    mensagem = "Cadastro inserido com Sucesso!!!";

                    contexto.ExecutaProc(nomeProc, param);
                }
            }
            else
            {
                var nomeProc = "sp_update_cliente";

                List<SqlParameter> param = new List<SqlParameter>();

                param.Add(new SqlParameter() { ParameterName = "@ID", Value = entidade.Id_Cliente });
                param.Add(new SqlParameter() { ParameterName = "@Nome", Value = entidade.Nome });
                param.Add(new SqlParameter() { ParameterName = "@Email", Value = entidade.Email });
                param.Add(new SqlParameter() { ParameterName = "@Sexo", Value = entidade.Sexo });
                param.Add(new SqlParameter() { ParameterName = "@Dt_Nasc", Value = entidade.Dt_Nasc });
                param.Add(new SqlParameter() { ParameterName = "@Dt_Cadastro", Value = entidade.Dt_Cadastro });
                param.Add(new SqlParameter() { ParameterName = "@Rua", Value = entidade.Rua });
                param.Add(new SqlParameter() { ParameterName = "@Numero", Value = entidade.Numero });
                param.Add(new SqlParameter() { ParameterName = "@Bairro", Value = entidade.Bairro });
                param.Add(new SqlParameter() { ParameterName = "@Complemento", Value = entidade.Complemento });
                param.Add(new SqlParameter() { ParameterName = "@Celular", Value = entidade.Celular });
                param.Add(new SqlParameter() { ParameterName = "@Telefone", Value = entidade.Telefone });

                contexto.ExecutaProc(nomeProc, param);

                mensagem = "Cadastro atualizado com Sucesso!!!";
            }

            return mensagem.ToString();
        }

        private List<ClientesVo> ReaderObjeto(SqlDataReader reader)
        {
            var cliente = new List<ClientesVo>();
            while (reader.Read())
            {
                var temObjeto = new ClientesVo()
                {
                    Id_Cliente = reader["Id_Cliente"] != DBNull.Value ? int.Parse(reader["Id_Cliente"].ToString()) : 0,
                    Nome = reader["Nome"] != DBNull.Value ? reader["Nome"].ToString() : null,
                    Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : null,
                    Sexo = reader["Sexo"] != DBNull.Value ? reader["Sexo"].ToString() : "",
                    Dt_Cadastro = DateTime.Parse(reader["Dt_Cadastro"].ToString()),
                    Dt_Nasc = DateTime.Parse(reader["Dt_Nasc"].ToString()),
                    Telefone = reader["Telefone"] != DBNull.Value ? long.Parse(reader["Telefone"].ToString()) : 0,
                    Celular = reader["Celular"] != DBNull.Value ? long.Parse(reader["Celular"].ToString()) : 0,
                    Rua = reader["Rua"] != DBNull.Value ? reader["Rua"].ToString() : null,
                    Numero = reader["Numero"] != DBNull.Value ? int.Parse(reader["Numero"].ToString()) : 0,
                    Bairro = reader["Bairro"] != DBNull.Value ? reader["Bairro"].ToString() : null,
                    Complemento = reader["Complemento"] != DBNull.Value ? reader["Complemento"].ToString() : null
                };
                cliente.Add(temObjeto);
            }
            reader.Close();
            return cliente;
        }
    }
}
