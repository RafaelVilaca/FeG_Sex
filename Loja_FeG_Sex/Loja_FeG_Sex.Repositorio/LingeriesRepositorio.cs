using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Loja_FeG_Sex.Repositorio
{
    public class LingeriesRepositorio : ILingeries
    {
        private Contexto _contexto;

        public IEnumerable<LingeriesVo> ListarTodos()
        {
            using (_contexto = new Contexto())
            {
                var strQuery = "Select cl.*, c.Nome as Nome From ChaLingerie cl " +
                               " INNER JOIN Clientes c " +
                               " on cl.Id_Cliente = c.Id_Cliente " +
                               " order by c.Nome ";
                var retorno = _contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                return ReaderObjeto(retorno);
            }
        }

        public IEnumerable<LingeriesVo> ListarTodos(string filtroNome, DateTime? dataInicial, DateTime? dataFinal)
        {
            using (_contexto = new Contexto())
            {
                var param = new List<SqlParameter>
                {
                    new SqlParameter() {ParameterName = "@filtroNome", Value = filtroNome},
                    new SqlParameter() {ParameterName = "@dt_inicial", Value = dataInicial},
                    new SqlParameter() {ParameterName = "@dt_final", Value = dataFinal}
                };
                var strQuery = "Select cl.*, c.Nome as Nome From ChaLingerie cl " +
                                " INNER JOIN Clientes c " +
                                " on cl.Id_Cliente = c.Id_Cliente " +
                                " Where cl.Data_Evento Between @dt_inicial AND @dt_final " +
                                " AND c.Nome LIKE ('%'+@filtroNome+'%') " +
                                " order by c.Nome ";
                var retorno = _contexto.ExecutaComRetorno(strQuery, param);
                return ReaderObjeto(retorno);
            }
        }

        public string Salvar(LingeriesVo entidade)
        {
            string mensagem;

            if (entidade.IdChaLingerie == null)
            {
                var nomeProc = "sp_insert_cha";

                using (_contexto = new Contexto())
                {
                    List<SqlParameter> param = new List<SqlParameter>();

                    param.Add(new SqlParameter() { ParameterName = "@Descricao", Value = entidade.Descricao });
                    param.Add(new SqlParameter() { ParameterName = "@Data_Cadastro", Value = entidade.DataCadastro });
                    param.Add(new SqlParameter() { ParameterName = "@Id_Cliente", Value = entidade.IdCliente });
                    param.Add(new SqlParameter() { ParameterName = "@Vl_Receber", Value = entidade.VlReceber });
                    param.Add(new SqlParameter() { ParameterName = "@Data_Evento", Value = entidade.DataEvento });

                    mensagem = "Cadastro inserido com Sucesso!!!";

                    _contexto.ExecutaProc(nomeProc, param);
                }
            }
            else
            {
                var nomeProc = "sp_update_cha";

                using (_contexto = new Contexto())
                {
                    List<SqlParameter> param = new List<SqlParameter>();

                    param.Add(new SqlParameter() { ParameterName = "@Id_ChaLingerie", Value = entidade.IdChaLingerie });
                    param.Add(new SqlParameter() { ParameterName = "@Descricao", Value = entidade.Descricao });
                    param.Add(new SqlParameter() { ParameterName = "@Data_Cadastro", Value = entidade.DataCadastro });
                    param.Add(new SqlParameter() { ParameterName = "@Id_Cliente", Value = entidade.IdCliente });
                    param.Add(new SqlParameter() { ParameterName = "@Vl_Receber", Value = entidade.VlReceber });
                    param.Add(new SqlParameter() { ParameterName = "@Data_Evento", Value = entidade.DataEvento });

                    _contexto.ExecutaProc(nomeProc, param);

                    mensagem = "Cadastro atualizado com Sucesso!!!";
                }
            }

            return mensagem;
        }

        private List<LingeriesVo> ReaderObjeto(SqlDataReader reader)
        {
            var chaLingerie = new List<LingeriesVo>();
            while (reader.Read())
            {
                var clientes = new ClientesVo
                {
                    IdCliente = int.Parse(reader["Id_Cliente"].ToString()),
                    Nome = reader["Nome"].ToString()
                };

                var temObjeto = new LingeriesVo()
                {
                    IdChaLingerie = reader["Id_ChaLingerie"] != DBNull.Value ? int.Parse(reader["Id_ChaLingerie"].ToString()) : 0,
                    Descricao = reader["Descricao"] != DBNull.Value ? reader["Descricao"].ToString() : null,
                    DataCadastro = DateTime.Parse(reader["Data_Cadastro"].ToString()),
                    DataEvento = DateTime.Parse(reader["Data_Evento"].ToString()),
                    VlReceber = reader["Vl_Receber"] != DBNull.Value ? decimal.Parse(reader["Vl_Receber"].ToString()) : 0,
                    Cliente = clientes
                };
                chaLingerie.Add(temObjeto);
            }
            reader.Close();
            return chaLingerie;
        }
    }
}
