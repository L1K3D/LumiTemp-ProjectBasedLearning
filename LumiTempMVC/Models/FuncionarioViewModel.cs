using System; // Importa o namespace necessário para trabalhar com tipos básicos, como DateTime

namespace LumiTempMVC.Models // Declaração do namespace para organizar o código dos modelos
{
    // Classe FuncionarioViewModel que representa os dados de um funcionário
    public class FuncionarioViewModel
    {
        // Propriedade para armazenar o número do usuário (ID)
        public int id { get; set; }

        // Propriedade para armazenar o login do usuário
        public string login_func { get; set; }

        // Propriedade para armazenar a senha do usuário
        public string senha_func { get; set; }

        // Propriedade para armazenar a data de cadastro do usuário
        public DateTime dt_cadr { get; set; }
    }
}