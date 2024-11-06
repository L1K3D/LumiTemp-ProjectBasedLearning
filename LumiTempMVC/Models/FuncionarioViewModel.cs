using Microsoft.AspNetCore.Http;
using System; // Importa o namespace necessário para trabalhar com tipos básicos, como DateTime

namespace LumiTempMVC.Models // Declaração do namespace para organizar o código dos modelos
{
    // Classe FuncionarioViewModel que representa os dados de um funcionário
    public class FuncionarioViewModel
    {
        // Propriedade para armazenar o número do usuário (ID)
        public int id { get; set; }

        /// <summary>
        /// Imagem recebida do form pelo controller
        /// </summary>
        public IFormFile Imagem { get; set; }
        /// <summary>
        /// Imagem em bytes pronta para ser salva
        /// </summary>
        public byte[] ImagemEmByte { get; set; }
        /// <summary>
        /// Imagem usada para ser enviada ao form no formato para ser exibida
        /// </summary>
        public string ImagemEmBase64
        {
            get
            {
                if (ImagemEmByte != null)
                    return Convert.ToBase64String(ImagemEmByte);
                else
                    return string.Empty;
            }
        }

        // Propriedade para armazenar o login do usuário
        public string login_func { get; set; }

        // Propriedade para armazenar a senha do usuário
        public string senha_func { get; set; }

        // Propriedade para armazenar a data de cadastro do usuário
        public DateTime dt_cadr { get; set; }
    }
}