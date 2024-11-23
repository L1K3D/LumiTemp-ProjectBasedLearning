using Microsoft.AspNetCore.Http;
using System;

namespace LumiTempMVC.Models // Declaração do namespace para organizar o código dos modelos
{
    // Classe EmpresaParceiraViewModel que representa os dados de uma empresa parceira
    public class EmpresaParceiraViewModel : PadraoViewModel
    {
        // Propriedade para armazenar o código da empresa (ID)
        //public int id { get; set; }

        // Propriedade para armazenar o nome da empresa
        public string nm_empr { get; set; }

        // Propriedade para armazenar o CEP da empresa
        public string cep_empr { get; set; }

        // Propriedade para armazenar o Logradouro da empresa
        public string log_empr { get; set; }

        // Propriedade para armazenar o Numero da empresa
        public string num_empr { get; set; }

        // Propriedade para armazenar o Complemento da empresa
        public string compl_empr { get; set; }

        // Propriedade para armazenar o Bairro da empresa
        public string bairro_empr { get; set; }

        // Propriedade para armazenar a Cidade da empresa
        public string cidade_empr { get; set; }

        // Propriedade para armazenar o Estado da empresa
        public string estado_empr { get; set; }

        // Propriedade para armazenar o CNPJ da empresa
        public string cnpj_empr { get; set; }

        // Propriedade para armazenar o telefone de contato da empresa
        public string telf_cont_empr { get; set; }

        // Propriedade para armazenar o número do usuário (ID) associado à empresa
        public int id_func { get; set; }
    }
}