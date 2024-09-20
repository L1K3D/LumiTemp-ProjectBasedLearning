using System;

namespace LumiTempMVC.Models
{
    // Classe que representa um modelo para exibir informações sobre erros no sistema
    public class ErrorViewModel
    {
        // Construtor que recebe uma mensagem de erro como parâmetro
        public ErrorViewModel(string erro)
        {
            this.Erro = erro;  // Atribui a mensagem de erro ao campo Erro
        }

        // Construtor vazio para permitir a criação de um objeto sem inicializar valores
        public ErrorViewModel() { }

        // Propriedade para armazenar a mensagem de erro
        public string Erro { get; set; }

        // Propriedade para armazenar o ID da requisição, útil para rastrear o erro em logs
        public string RequestId { get; set; }

        // Propriedade booleana que verifica se o RequestId foi preenchido
        // Retorna verdadeiro se RequestId não estiver vazio ou nulo, o que pode indicar um erro rastreável
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}