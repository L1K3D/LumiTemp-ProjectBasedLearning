using System.Data; // Importa o namespace para trabalhar com DataTables e outras estruturas de dados
using System.Data.SqlClient; // Importa o namespace para trabalhar com SQL Server

namespace LumiTempMVC.DAO // Declaração do namespace para organizar o código
{
    public static class HelperDAO // Classe estática HelperDAO para métodos auxiliares de acesso a dados
    {
        // Método para executar comandos SQL que não retornam dados (como INSERT, UPDATE, DELETE)
        public static void ExecutaSQL(string sql, SqlParameter[] parametros)
        {
            // Cria uma conexão com o banco de dados usando um método estático da classe ConexaoDB
            using (SqlConnection conexao = ConexaoDB.GetConexao())
            {
                // Cria um comando SQL usando a conexão e a string SQL fornecida
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    // Se parâmetros forem fornecidos, adiciona-os ao comando
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);

                    // Executa o comando SQL (não retorna dados)
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Método para executar consultas SQL que retornam dados (como SELECT)
        public static DataTable ExecutaSelect(string sql, SqlParameter[] parametros)
        {
            // Cria uma conexão com o banco de dados
            using (SqlConnection conexao = ConexaoDB.GetConexao())
            {
                // Cria um SqlDataAdapter para executar a consulta e preencher um DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao))
                {
                    // Se parâmetros forem fornecidos, adiciona-os ao comando de seleção do adapter
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);

                    // Cria um DataTable para armazenar os resultados da consulta
                    DataTable tabelaTemp = new DataTable();
                    // Preenche o DataTable com os dados retornados pela consulta
                    adapter.Fill(tabelaTemp);

                    // Retorna o DataTable preenchido
                    return tabelaTemp;
                }
            }
        }
    }
}
