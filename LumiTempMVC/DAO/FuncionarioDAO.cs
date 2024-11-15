using LumiTempMVC.Models; // Importa o namespace com os modelos.
using System.Data.SqlClient; // Biblioteca para manipulação de SQL Server.
using System.Data; // Biblioteca para trabalhar com tabelas e dados estruturados.
using System; // Biblioteca para funcionalidades básicas.

namespace LumiTempMVC.DAO
{
    // Classe específica para manipular os dados da tabela de funcionários.
    // Herda de PadraoDAO, uma classe genérica que fornece funcionalidades padrão para DAO.
    public class FuncionarioDAO : PadraoDAO<FuncionarioViewModel>
    {
        // Implementa o método abstrato para criar os parâmetros necessários para a execução de stored procedures.
        protected override SqlParameter[] CriaParametros(FuncionarioViewModel model)
        {
            // Define um array de parâmetros para armazenar os dados do modelo.
            SqlParameter[] parametros = new SqlParameter[4]; // Corrigido para refletir 4 parâmetros.

            // Preenche cada posição do array com um novo parâmetro SQL, mapeando os campos do modelo.
            parametros[0] = new SqlParameter("ID", model.id); // ID do funcionário.
            parametros[1] = new SqlParameter("LOGIN_FUNC", model.login_func); // Login do funcionário.
            parametros[2] = new SqlParameter("SENHA_FUNC", model.senha_func); // Senha do funcionário.
            parametros[3] = new SqlParameter("DT_CADR", model.dt_cadr); // Data de cadastro do funcionário.

            return parametros; // Retorna o array de parâmetros preenchido.
        }

        // Implementa o método abstrato para criar um modelo a partir de uma linha de dados (DataRow).
        protected override FuncionarioViewModel MontaModel(DataRow registro)
        {
            // Cria uma nova instância do modelo FuncionarioViewModel.
            FuncionarioViewModel funcionario = new FuncionarioViewModel();

            // Preenche as propriedades do modelo com os valores correspondentes do DataRow.
            funcionario.id = Convert.ToInt32(registro["ID"]); // Converte e atribui o ID.
            funcionario.login_func = Convert.ToString(registro["LOGIN_FUNC"]); // Converte e atribui o login.
            funcionario.senha_func = Convert.ToString(registro["SENHA_FUNC"]); // Converte e atribui a senha.
            funcionario.dt_cadr = Convert.ToDateTime(registro["DT_CADR"]); // Converte e atribui a data de cadastro.

            return funcionario; // Retorna o modelo preenchido.
        }

        // Implementa o método abstrato para definir o nome da tabela que será usada nas operações do DAO.
        protected override void SetTabela()
        {
            Tabela = "cadr_func"; // Define o nome da tabela como "funcionarios".
        }
    }
}