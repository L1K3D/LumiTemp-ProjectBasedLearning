using System.Data.SqlClient;

namespace LumiTempMVC.DAO
{
    public class ConexaoDB
    {
        // Método estático para obter uma conexão com o banco de dados
        public static SqlConnection GetConexao()
        {
            // String de conexão com o banco de dados
            // - Data Source: endereço do servidor (neste caso, LOCALHOST)
            // - Initial Catalog: nome do banco de dados
            // - user id: usuário para autenticação
            // - password: senha do usuário
            string strCon = "Data Source=DESKTOP-47NVA44\\MSSQLSERVER2; Initial Catalog=b_lumitemp_main_db; user id=sa; password=123456";

            // Cria uma nova instância de SqlConnection usando a string de conexão
            SqlConnection conexao = new SqlConnection(strCon);

            // Abre a conexão com o banco de dados
            conexao.Open();

            // Retorna a conexão aberta
            return conexao;
        }
    }
}
