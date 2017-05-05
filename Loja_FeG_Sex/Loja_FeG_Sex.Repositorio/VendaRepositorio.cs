using Loja_FeG_Sex.Entidades;
using Loja_FeG_Sex.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Loja_FeG_Sex.Repositorio
{
    public class VendaRepositorio : IVendas
    {
        private Contexto contexto;

        public IEnumerable<VendasVo> ListarTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuery = "Select v.*, c.Nome as Nome_Cliente, p.Descricao as Desc_Produto From Vendas v ";
                strQuery += " INNER JOIN Clientes c ";
                strQuery += " on c.Id_Cliente = v.Id_Cliente ";
                strQuery += " INNER JOIN Produtos p ";
                strQuery += " on p.Id_Prod = v.Id_Produto ";                
                strQuery += " order by v.Id_Vendas asc ";
                var retorno = contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
                return ReaderObjeto(retorno);
            }
        }        

        public string Salvar(VendasVo entidade)
        {
            var mensagem = "";

            //if (entidade.Id_Venda == 0)
            //{
            var nomeProc = "sp_insert_venda";

            using (contexto = new Contexto())
            {
                List<SqlParameter> param = new List<SqlParameter>();

                param.Add(new SqlParameter() { ParameterName = "@Id_Cliente", Value = entidade.Id_Cliente });
                param.Add(new SqlParameter() { ParameterName = "@Id_Prod", Value = entidade.Id_Prod });
                param.Add(new SqlParameter() { ParameterName = "@Quantidade", Value = entidade.Qtde });
                param.Add(new SqlParameter() { ParameterName = "@Dt_Transacao", Value = entidade.Dt_Transacao });
                param.Add(new SqlParameter() { ParameterName = "@Vl_Venda", Value = entidade.Vl_Venda });
                param.Add(new SqlParameter() { ParameterName = "@Dt_Pagamento", Value = entidade.Data_Recebimento });
                param.Add(new SqlParameter() { ParameterName = "@Tipo_Pagamento", Value = entidade.Tipo_Recebimento });

                mensagem = "Cadastro inserido com Sucesso!!!";

                contexto.ExecutaProc(nomeProc, param);
            }
            //}
            //else
            //{
            //    var nomeProc = "sp_update_venda";

            //    List<SqlParameter> param = new List<SqlParameter>();

            //param.Add(new SqlParameter() { ParameterName = "@Id_Venda", Value = entidade.Id_Venda });
            //param.Add(new SqlParameter() { ParameterName = "@Id_Cliente", Value = entidade.Id_Cliente });
            //param.Add(new SqlParameter() { ParameterName = "@Id_Prod", Value = entidade.Id_Prod });
            //param.Add(new SqlParameter() { ParameterName = "@Quantidade", Value = entidade.Qtde });
            //param.Add(new SqlParameter() { ParameterName = "@Dt_Transacao", Value = entidade.Dt_Transacao });
            //param.Add(new SqlParameter() { ParameterName = "@Vl_Venda", Value = entidade.Vl_Venda });
            //param.Add(new SqlParameter() { ParameterName = "@Dt_Pagamento", Value = entidade.Data_Recebimento });
            //param.Add(new SqlParameter() { ParameterName = "@Tipo_Pagamento", Value = entidade.Tipo_Recebimento });

            //    contexto.ExecutaProc(nomeProc, param);

            //    mensagem = "Cadastro atualizado com Sucesso!!!";
            //}

            return mensagem.ToString();
        }

        private List<VendasVo> ReaderObjeto(SqlDataReader reader)
        {
            var venda = new List<VendasVo>();
            while (reader.Read())
            {
                var cliente = new ClientesVo()
                {
                    Id_Cliente = int.Parse(reader["Id_Cliente"].ToString()),
                    Nome = reader["Nome_Cliente"].ToString()
                };
                var produto = new ProdutosVo()
                {
                    Id_Prod = int.Parse(reader["Id_Produto"].ToString()),
                    Descricao = reader["Desc_Produto"].ToString(),
                    Vl_Venda = decimal.Parse(reader["Vl_Venda"].ToString())
                };
                var temObjeto = new VendasVo()
                {
                    Produto = produto,
                    Cliente = cliente,
                    Qtde = reader["Quantidade"] != DBNull.Value ? int.Parse(reader["Quantidade"].ToString()) : 0,
                    Dt_Transacao = DateTime.Parse(reader["Dt_Transacao"].ToString()),
                    Vl_Venda = reader["Vl_Venda"] != DBNull.Value ? decimal.Parse(reader["Vl_Venda"].ToString()) : 0,
                    Data_Recebimento = DateTime.Parse(reader["Data_Pagamento"].ToString()),
                    Tipo_Recebimento = reader["Tipo_Pagamento"] != DBNull.Value ? reader["Tipo_Pagamento"].ToString() : ""
                };
                venda.Add(temObjeto);
            }
            reader.Close();
            return venda;
        }

        //public IEnumerable<VendasVo> ListarTodos(string filtroNome, string filtroProduto, DateTime? dataInicial, DateTime? dataFinal)
        //{
        //    List<SqlParameter> param = new List<SqlParameter>();
        //    param.Add(new SqlParameter() { ParameterName = "@filtroNome", Value = filtroNome });
        //    param.Add(new SqlParameter() { ParameterName = "@filtroProduto", Value = filtroProduto });
        //    param.Add(new SqlParameter() { ParameterName = "@dt_inicial", Value = dataInicial });
        //    param.Add(new SqlParameter() { ParameterName = "@dt_final", Value = dataFinal });

        //    if (filtroNome != "" && filtroProduto != "")
        //    {
        //        var strQuery = "Select v.*, c.Nome as Nome_Cliente, p.Descricao as Desc_Produto From Vendas v ";
        //        strQuery += " INNER JOIN Clientes c ";
        //        strQuery += " on c.Id_Cliente = v.Id_Cliente ";
        //        strQuery += " INNER JOIN Produtos p ";
        //        strQuery += " on p.Id_Prod = v.Id_Produto ";
        //        strQuery += " Where v.Dt_Transacao Between @dt_inicial AND @dt_final ";
        //        strQuery += " AND c.Nome LIKE ('%@filtroNome%') ";
        //        strQuery += " AND p.Descricao LIKE ('%@filtroProduto%') ";
        //        strQuery += " order by v.Id_Vendas asc ";
        //        var retorno = contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
        //        return ReaderObjeto(retorno);
        //    }
        //    else if (filtroNome != "" && filtroProduto == "")
        //    {
        //        var strQuery = "Select v.*, c.Nome as Nome_Cliente, p.Descricao as Desc_Produto From Vendas v ";
        //        strQuery += " INNER JOIN Clientes c ";
        //        strQuery += " on c.Id_Cliente = v.Id_Cliente ";
        //        strQuery += " INNER JOIN Produtos p ";
        //        strQuery += " on p.Id_Prod = v.Id_Produto ";
        //        strQuery += " Where v.Dt_Transacao Between @dt_inicial AND @dt_final ";
        //        strQuery += " AND c.Nome LIKE ('%@filtroNome%') ";
        //        strQuery += " order by v.Id_Vendas asc ";
        //        var retorno = contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
        //        return ReaderObjeto(retorno);
        //    }
        //    else if (filtroNome == "" && filtroProduto != "")
        //    {
        //        var strQuery = "Select v.*, c.Nome as Nome_Cliente, p.Descricao as Desc_Produto From Vendas v ";
        //        strQuery += " INNER JOIN Clientes c ";
        //        strQuery += " on c.Id_Cliente = v.Id_Cliente ";
        //        strQuery += " INNER JOIN Produtos p ";
        //        strQuery += " on p.Id_Prod = v.Id_Produto ";
        //        strQuery += " Where v.Dt_Transacao Between @dt_inicial AND @dt_final ";
        //        strQuery += " AND p.Descricao LIKE ('%@filtroProduto%') ";
        //        strQuery += " order by v.Id_Vendas asc ";
        //        var retorno = contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
        //        return ReaderObjeto(retorno);
        //    }
        //    else
        //    {
        //        var strQuery = "Select v.*, c.Nome as Nome_Cliente, p.Descricao as Desc_Produto From Vendas v ";
        //        strQuery += " INNER JOIN Clientes c ";
        //        strQuery += " on c.Id_Cliente = v.Id_Cliente ";
        //        strQuery += " INNER JOIN Produtos p ";
        //        strQuery += " on p.Id_Prod = v.Id_Produto ";
        //        strQuery += " Where v.Dt_Transacao Between @dt_inicial AND @dt_final ";
        //        strQuery += " order by v.Id_Vendas asc ";
        //        var retorno = contexto.ExecutaComRetorno(strQuery, new List<SqlParameter>());
        //        return ReaderObjeto(retorno);
        //    }
        //}
    }
}
