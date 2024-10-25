using LumiTempMVC.Models; // Importa o namespace que contém os modelos
using System; // Importa o namespace para tipos básicos
using System.Collections.Generic; // Importa o namespace para trabalhar com listas genéricas
using System.Data; // Importa o namespace para trabalhar com DataTables
using System.Data.SqlClient; // Importa o namespace para trabalhar com SQL Server

namespace LumiTempMVC.DAO // Declaração do namespace para organizar o código de acesso a dados
{
    public class FuncionarioDAO // Classe responsável por operações de acesso a dados para funcionários
    {
        // Método privado que cria um array de parâmetros para comandos SQL
        private SqlParameter[] CriaParametros(FuncionarioViewModel funcionario)
        {
            // Inicializa o array de parâmetros
            SqlParameter[] parametros = new SqlParameter[4]; // Corrigido para 4 parâmetros
            // Adiciona cada parâmetro ao array
            parametros[0] = new SqlParameter("ID", funcionario.id);
            parametros[1] = new SqlParameter("LOGIN_FUNC", funcionario.login_func);
            parametros[2] = new SqlParameter("SENHA_FUNC", funcionario.senha_func);
            parametros[3] = new SqlParameter("DT_CADR", funcionario.dt_cadr); // Corrigido para usar a data de cadastro
            return parametros; // Retorna o array de parâmetros
        }

        // Método para inserir um novo funcionário no banco de dados
        public void Inserir(FuncionarioViewModel funcionario)
        {
            // Define a string SQL para a inserção
            string sql = "INSERT INTO cadr_func (ID, LOGIN_FUNC, SENHA_FUNC, DT_CADR) " +
                         "VALUES (@ID, @LOGIN_FUNC, @SENHA_FUNC, @DT_CADR)";
            // Executa o comando SQL usando a classe HelperDAO
            HelperDAO.ExecutaSQL(sql, CriaParametros(funcionario));
        }

        // Método para alterar as informações de um funcionário existente
        public void Alterar(FuncionarioViewModel funcionario)
        {
            // Define a string SQL para a atualização
            string sql =
                "UPDATE cadr_func SET " +
                "LOGIN_FUNC=@LOGIN_FUNC, " +
                "SENHA_FUNC=@SENHA_FUNC, " +
                "DT_CADR=@DT_CADR " +
                "WHERE ID=@ID";
            // Executa o comando SQL
            HelperDAO.ExecutaSQL(sql, CriaParametros(funcionario));
        }

        // Método para excluir um funcionário com base no ID
        public void Excluir(int id)
        {
            // Define a string SQL para a exclusão
            string sql = "DELETE cadr_func WHERE ID =" + id;
            // Executa o comando SQL (não precisa de parâmetros)
            HelperDAO.ExecutaSQL(sql, null);
        }

        // Método estático que monta um objeto FuncionarioViewModel a partir de um DataRow
        public static FuncionarioViewModel MontaModelFuncionario(DataRow registro)
        {
            FuncionarioViewModel funcionario = new FuncionarioViewModel();
            // Preenche as propriedades do modelo com os dados do DataRow
            funcionario.id = Convert.ToInt32(registro["ID"]);
            funcionario.login_func = Convert.ToString(registro["LOGIN_FUNC"]);
            funcionario.senha_func = Convert.ToString(registro["SENHA_FUNC"]); // Corrigido para "SENHA_FUNC"
            funcionario.dt_cadr = Convert.ToDateTime(registro["DT_CADR"]);
            return funcionario; // Retorna o modelo preenchido
        }

        // Método para consultar um funcionário com base no ID
        public FuncionarioViewModel Consulta(int id)
        {
            // Define a string SQL para a consulta
            string sql = "SELECT * FROM cadr_func WHERE ID =" + id;
            // Executa a consulta e armazena o resultado em um DataTable
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            // Verifica se algum registro foi encontrado
            if (tabela.Rows.Count == 0)
                return null; // Retorna nulo se não encontrar registros
            else
                return MontaModelFuncionario(tabela.Rows[0]); // Monta e retorna o funcionário encontrado
        }

        // Método para consultar todos os funcionários
        public List<FuncionarioViewModel> ConsultaTodos()
        {
            List<FuncionarioViewModel> funcionarios = new List<FuncionarioViewModel>(); // Cria uma lista para armazenar os funcionários

            using (SqlConnection cx = ConexaoDB.GetConexao()) // Usa a conexão com o banco de dados
            {
                // Define a string SQL para buscar todos os funcionários
                string sql = "SELECT * FROM cadr_func";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, cx)) // Cria um SqlDataAdapter
                {
                    DataTable tabela = new DataTable(); // Cria um DataTable para armazenar os dados
                    adapter.Fill(tabela); // Preenche o DataTable com os dados retornados

                    // Percorre cada registro da tabela e monta os modelos
                    foreach (DataRow registro in tabela.Rows)
                    {
                        funcionarios.Add(MontaModelFuncionario(registro)); // Adiciona o funcionário à lista
                    }
                }
            }

            return funcionarios; // Retorna a lista de funcionários
        }

        // Método para listar todos os funcionários em ordem
        public List<FuncionarioViewModel> Listagem()
        {
            List<FuncionarioViewModel> lista = new List<FuncionarioViewModel>(); // Cria uma lista para armazenar os funcionários
            // Define a string SQL para buscar todos os funcionários ordenados
            string sql = "SELECT * FROM cadr_func ORDER BY ID";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null); // Executa a consulta

            // Percorre cada registro da tabela e monta os modelos
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaModelFuncionario(registro)); // Adiciona o funcionário à lista

            return lista; // Retorna a lista de funcionários
        }

        // Método para obter o próximo ID disponível para um novo funcionário
        public int ProximoId()
        {
            // Define a string SQL para buscar o próximo ID
            string sql = "SELECT ISNULL(MAX(ID) + 1, 1) AS 'MAIOR' FROM cadr_func";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null); // Executa a consulta
            // Retorna o próximo ID (ou 1 se não houver registros)
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]);
        }
    }
}