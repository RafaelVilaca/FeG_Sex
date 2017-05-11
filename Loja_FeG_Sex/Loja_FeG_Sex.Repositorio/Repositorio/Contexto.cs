using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Loja_FeG_Sex.Repositorio.Repositorio
{
    public class Contexto : IDisposable
    {
        private readonly SqlConnection _conexao;

        public Contexto()
        {
            _conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString);
            _conexao.Open();
        }

        //public void ExecutaComando(string strQuery, List<SqlParameter> param)
        //{
        //    var cmd = new SqlCommand
        //    {
        //        CommandText = strQuery,
        //        CommandType = CommandType.Text,
        //        Connection = _conexao
        //    };
        //    foreach (var parametro in param)
        //    {
        //        cmd.Parameters.Add(parametro);
        //    }
        //    cmd.ExecuteNonQuery();
        //}

        public void ExecutaProc(string nomeProc, List<SqlParameter> param)
        {
            var cmd = new SqlCommand
            {
                CommandText = nomeProc,
                CommandType = CommandType.StoredProcedure,
                Connection = _conexao
            };
            foreach (var parametro in param)
            {
                cmd.Parameters.Add(parametro);
            }
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader ExecutaComRetorno(string strQuery, List<SqlParameter> param)
        {
            var cmd = new SqlCommand(strQuery, _conexao);
            foreach (var parametro in param)
            {
                cmd.Parameters.Add(parametro);
            }
            return cmd.ExecuteReader();
        }

        public void Dispose()
        {
            if (_conexao.State == ConnectionState.Open)
                _conexao.Close();
        }
    }
}
