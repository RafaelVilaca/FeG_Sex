using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Loja_FeG_Sex.Repositorio
{
    public class ClienteRepositorio : ICliente
    {
        private Contexto _contexto;

        public IEnumerable<ClientesVo> ListarTodos()
        {
            using (_contexto = new Contexto())
            {
                var strQuery = "Select * From Clientes " +
                               " order by Nome ";
                var retorno = _contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                return ReaderObjeto(retorno);
            }
        }

        public IEnumerable<ClientesVo> ListarAtivos()
        {
            using (_contexto = new Contexto())
            {
                var strQuery = "Select c.* From Clientes c " +
                               " Where c.Ativo = 1 " +
                               " order by Nome ";
                var retorno = _contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                return ReaderObjeto(retorno);
            }
        }

        public IEnumerable<ClientesVo> ListarTodos(string filtro)
        {
            using (_contexto = new Contexto())
            {
                // ReSharper disable once ObjectCreationAsStatement
                var param = new List<SqlParameter>
                {
                    new SqlParameter() {ParameterName = "@filtro", Value = filtro}
                };
                var strQuery = "Select * From Clientes " +
                               " where Nome Like('%'+@filtro+'%') " +
                               " order by Nome ";
                var retorno = _contexto.ExecutaComRetorno(strQuery, param);
                return ReaderObjeto(retorno);
            }
        }

        public string Salvar(ClientesVo entidade)
        {
            string mensagem;

            if (entidade.IdCliente == null)
            {
                var nomeProc = "sp_insert_cliente";

                using (_contexto = new Contexto())
                {
                    var param = new List<SqlParameter>
                    {
                        new SqlParameter() {ParameterName = "@Nome", Value = entidade.Nome},
                        new SqlParameter() {ParameterName = "@Email", Value = entidade.Email},
                        new SqlParameter() {ParameterName = "@Sexo", Value = entidade.Sexo},
                        new SqlParameter() {ParameterName = "@Dt_Nasc", Value = entidade.DtNasc},
                        new SqlParameter() {ParameterName = "@Dt_Cadastro", Value = entidade.DtCadastro},
                        new SqlParameter() {ParameterName = "@Rua", Value = entidade.Rua},
                        new SqlParameter() {ParameterName = "@Numero", Value = entidade.Numero},
                        new SqlParameter() {ParameterName = "@Bairro", Value = entidade.Bairro},
                        new SqlParameter() {ParameterName = "@Complemento", Value = entidade.Complemento},
                        new SqlParameter() {ParameterName = "@Celular", Value = entidade.Celular},
                        new SqlParameter() {ParameterName = "@Telefone", Value = entidade.Telefone},
                        new SqlParameter() {ParameterName = "@Ativo", Value = entidade.Ativo}
                    };


                    mensagem = "Cadastro inserido com Sucesso!!!";

                    _contexto.ExecutaProc(nomeProc, param);
                }
            }
            else
            {
                var nomeProc = "sp_update_cliente";

                using (_contexto = new Contexto())
                {
                    var param = new List<SqlParameter>
                    {
                        new SqlParameter() {ParameterName = "@ID", Value = entidade.IdCliente},
                        new SqlParameter() {ParameterName = "@Nome", Value = entidade.Nome},
                        new SqlParameter() {ParameterName = "@Email", Value = entidade.Email},
                        new SqlParameter() {ParameterName = "@Sexo", Value = entidade.Sexo},
                        new SqlParameter() {ParameterName = "@Dt_Nasc", Value = entidade.DtNasc},
                        new SqlParameter() {ParameterName = "@Dt_Cadastro", Value = entidade.DtCadastro},
                        new SqlParameter() {ParameterName = "@Rua", Value = entidade.Rua},
                        new SqlParameter() {ParameterName = "@Numero", Value = entidade.Numero},
                        new SqlParameter() {ParameterName = "@Bairro", Value = entidade.Bairro},
                        new SqlParameter() {ParameterName = "@Complemento", Value = entidade.Complemento},
                        new SqlParameter() {ParameterName = "@Celular", Value = entidade.Celular},
                        new SqlParameter() {ParameterName = "@Telefone", Value = entidade.Telefone},
                        new SqlParameter() {ParameterName = "@Ativo", Value = entidade.Ativo}
                    };


                    _contexto.ExecutaProc(nomeProc, param);

                    mensagem = "Cadastro atualizado com Sucesso!!!";
                }
            }

            return mensagem;
        }

        private List<ClientesVo> ReaderObjeto(SqlDataReader reader)
        {
            var cliente = new List<ClientesVo>();
            while (reader.Read())
            {
                var temObjeto = new ClientesVo()
                {
                    IdCliente = reader["Id_Cliente"] != DBNull.Value ? int.Parse(reader["Id_Cliente"].ToString()) : 0,
                    Nome = reader["Nome"] != DBNull.Value ? reader["Nome"].ToString() : null,
                    Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : null,
                    Sexo = reader["Sexo"] != DBNull.Value ? reader["Sexo"].ToString() : "",
                    DtCadastro = DateTime.Parse(reader["Dt_Cadastro"].ToString()),
                    DtNasc = DateTime.Parse(reader["Dt_Nasc"].ToString()),
                    Telefone = reader["Telefone"] != DBNull.Value ? long.Parse(reader["Telefone"].ToString()) : 0,
                    Celular = reader["Celular"] != DBNull.Value ? long.Parse(reader["Celular"].ToString()) : 0,
                    Rua = reader["Rua"] != DBNull.Value ? reader["Rua"].ToString() : null,
                    Numero = reader["Numero"] != DBNull.Value ? int.Parse(reader["Numero"].ToString()) : 0,
                    Bairro = reader["Bairro"] != DBNull.Value ? reader["Bairro"].ToString() : null,
                    Complemento = reader["Complemento"] != DBNull.Value ? reader["Complemento"].ToString() : null,
                    Ativo = reader["Ativo"] != DBNull.Value ? bool.Parse(reader["Ativo"].ToString()) : false
                };
                cliente.Add(temObjeto);
            }
            reader.Close();
            return cliente;
        }
    }
}
