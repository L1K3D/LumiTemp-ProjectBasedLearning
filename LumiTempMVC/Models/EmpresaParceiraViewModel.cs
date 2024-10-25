namespace LumiTempMVC.Models // Declaração do namespace para organizar o código dos modelos
{
    // Classe EmpresaParceiraViewModel que representa os dados de uma empresa parceira
    public class EmpresaParceiraViewModel
    {
        // Propriedade para armazenar o código da empresa (ID)
        public int id { get; set; }

        // Propriedade para armazenar o nome da empresa
        public string nm_empr { get; set; }

        // Propriedade para armazenar o CEP da empresa
        public string cep_empr { get; set; }

        // Propriedade para armazenar o CNPJ da empresa
        public string cnpj_empr { get; set; }

        // Propriedade para armazenar o telefone de contato da empresa
        public string telf_cont_empr { get; set; }

        // Propriedade para armazenar o número do usuário (ID) associado à empresa
        public int id_func { get; set; }
    }
}