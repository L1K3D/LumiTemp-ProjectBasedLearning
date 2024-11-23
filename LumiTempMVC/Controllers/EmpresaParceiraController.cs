using LumiTempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using LumiTempMVC.DAO;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace LumiTempMVC.Controllers
{
    // Controlador responsável por gerenciar as operações relacionadas às empresas parceiras
    public class EmpresaParceiraController : PadraoController<EmpresaParceiraViewModel>
    {
        // Método para exibir a página inicial do controlador de Empresa Parceira
        // Recupera uma lista de todas as empresas parceiras cadastradas
        public EmpresaParceiraController()
        {

            DAO = new EmpresaParceiraDAO();
            GeraProximoId = true;
            NomeViewForm = "Form";
            NomeViewIndex = "Index";
            NecessitaCaixaComboEmpresas = false;
            NecessitaCaixaComboFuncionarios = true;
            PossuiCampoData = false;
            ExigeAutenticacao = true;

        }

        public IActionResult ExtrairDados()
        {
            try
            {
                EmpresaParceiraDAO dao = new EmpresaParceiraDAO(); // Instancia o DAO para acessar os dados de funcionarios
                List<EmpresaParceiraViewModel> lista = dao.Listagem(); // Obtém a lista de funcionarios do banco de dados

                // Criação do conteúdo do arquivo
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Id, Nome"); // Cabeçalho do arquivo

                foreach (var empresa in lista)
                {
                    sb.AppendLine($"{empresa.id}, {empresa.nm_empr}, {empresa.cep_empr}, {empresa.cnpj_empr}, {empresa.telf_cont_empr}, {empresa.id_func}"); // Adiciona cada funcionario ao arquivo
                }

                // Definindo o nome do arquivo
                string fileName = "empresas.txt";

                // Retorna o arquivo para download
                return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/plain", fileName);
            }
            catch (Exception erro)
            {
                // Em caso de erro, redireciona para a página de erro com a mensagem de erro
                return RedirectToAction("Error", new ErrorViewModel(erro.ToString()));
            }
        }
        protected override void ValidaDados(EmpresaParceiraViewModel empresa, string operacao)
        {

            // Validação do Nome
            if (string.IsNullOrEmpty(empresa.nm_empr))
                ModelState.AddModelError("nm_empr", "Preencha o nome.");
            
            // Validação do Logradouro
            if (string.IsNullOrEmpty(empresa.log_empr))
                ModelState.AddModelError("log_empr", "Preencha o logradouro.");

            // Validação do Número
            if (string.IsNullOrEmpty(empresa.num_empr))
                ModelState.AddModelError("num_empr", "Preencha o número.");
            
            // Validação do Bairro
            if (string.IsNullOrEmpty(empresa.bairro_empr))
                ModelState.AddModelError("bairro_empr", "Preencha o bairro.");

            // Validação da Cidade
            if (string.IsNullOrEmpty(empresa.cidade_empr))
                ModelState.AddModelError("cidade_empr", "Preencha a cidade.");

            // Validação do Estado
            if (string.IsNullOrEmpty(empresa.estado_empr))
                ModelState.AddModelError("estado_empr", "Preencha o estado.");

            // Validação do CNPJ: 14 dígitos
            if (string.IsNullOrEmpty(empresa.cnpj_empr))
            {
                ModelState.AddModelError("cnpj_empr", "Preencha o CNPJ.");
            }
            else if (!IsValidCnpj(empresa.cnpj_empr))
            {
                ModelState.AddModelError("cnpj_empr", "CNPJ inválido.");
            }

            // Validação do CEP: 8 dígitos
            if (string.IsNullOrEmpty(empresa.cep_empr))
            {
                ModelState.AddModelError("cep_empr", "Preencha o CEP.");
            }
            else if (empresa.cep_empr.Length != 8 || !long.TryParse(empresa.cep_empr, out _))
            {
                ModelState.AddModelError("cep_empr", "CEP inválido.");
            }

            // Validação do Telefone: 10 ou 11 dígitos
            if (string.IsNullOrEmpty(empresa.telf_cont_empr))
            {
                ModelState.AddModelError("telf_cont_empr", "Preencha o telefone.");
            }
            else if (empresa.telf_cont_empr.Length < 10 || empresa.telf_cont_empr.Length > 11 || !long.TryParse(empresa.telf_cont_empr, out _))
            {
                ModelState.AddModelError("telf_cont_empr", "Telefone inválido.");
            }
        }

        // Método auxiliar para validar o CNPJ
        private bool IsValidCnpj(string cnpj)
        {
            if (cnpj.Length != 14 || !long.TryParse(cnpj, out _))
                return false;

            int[] multiplicador1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCnpj, digito;
            int soma, resto;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        protected override void PreencheDadosParaView(string Operacao, EmpresaParceiraViewModel model)
        {
            base.PreencheDadosParaView(Operacao, model);
        }
    }
}