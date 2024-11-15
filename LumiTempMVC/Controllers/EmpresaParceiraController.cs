using LumiTempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using LumiTempMVC.DAO;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LumiTempMVC.Controllers
{
    // Controlador responsável por gerenciar as operações relacionadas às empresas parceiras
    public class EmpresaParceiraController : Controller
    {
        // Método para exibir a página inicial do controlador de Empresa Parceira
        // Recupera uma lista de todas as empresas parceiras cadastradas
        public IActionResult Index()
        {
            EmpresaParceiraDAO dao = new EmpresaParceiraDAO(); // Instancia o DAO para acessar os dados
            List<EmpresaParceiraViewModel> lista = dao.Listagem(); // Busca a lista de empresas parceiras
            return View(lista); // Retorna a View passando a lista de empresas
        }

        // Método para criar uma nova empresa parceira
        public IActionResult Create(int id)
        {
            ViewBag.Operacao = "I";
            try
            {
                EmpresaParceiraViewModel empresa = new EmpresaParceiraViewModel();
                EmpresaParceiraDAO dao = new EmpresaParceiraDAO();
                empresa.id = dao.ProximoId();
                PreparaListaFuncionariosParaCombo();
                return View("Form", empresa);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        // Método para editar os dados de uma empresa parceira existente
        public IActionResult Edit(int id)
        {
            try
            {
                EmpresaParceiraDAO dao = new EmpresaParceiraDAO();
                var empresa = dao.Consulta(id);
                ViewBag.Operacao = "A";
                PreparaListaFuncionariosParaCombo();
                if (empresa == null)
                {
                    return RedirectToAction("Index");
                }
                return View("Form", empresa);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel { Erro = erro.ToString() });
            }
        }


        public IActionResult Salvar(EmpresaParceiraViewModel f, string operacao)
        {
            try
            {
                EmpresaParceiraDAO dao = new EmpresaParceiraDAO();

                ModelState.Clear();
                ValidaDados(f, operacao);

                PreparaListaFuncionariosParaCombo();
                
                if (f.id <= 0)
                    ModelState.AddModelError("id", "Campo obrigatório!");
                if (string.IsNullOrEmpty(f.nm_empr))
                    ModelState.AddModelError("nm_empr", "Campo obrigatório!");
                if (string.IsNullOrEmpty(f.cep_empr))
                    ModelState.AddModelError("cep_empr", "Campo obrigatório!");
                if (string.IsNullOrEmpty(f.cnpj_empr))
                    ModelState.AddModelError("cnpj_empr", "Campo obrigatório!");
                if (string.IsNullOrEmpty(f.telf_cont_empr))
                    ModelState.AddModelError("telf_cont_empr", "Campo obrigatório!");
                if (f.id_func <= 0)
                    ModelState.AddModelError("id_func", "Campo obrigatório!");


                if (ModelState.IsValid)
                {
                    if (operacao == "I")
                        dao.Inserir(f);
                    else
                        dao.Alterar(f);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.operacao = operacao;
                    return View("form", f);
                }
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel { Erro = erro.ToString() });
            }

        }


        // Método para excluir uma empresa parceira pelo seu ID
        public IActionResult Delete(int id)
        {
            try
            {
                EmpresaParceiraDAO dao = new EmpresaParceiraDAO(); // Instancia o DAO para a exclusão
                dao.Excluir(id); // Exclui a empresa parceira do banco de dados
                return RedirectToAction("Index"); // Após a exclusão, redireciona para a lista de empresas
            }
            catch (Exception erro)
            {
                // Em caso de erro, retorna a View de erro com a mensagem detalhada
                return View("Error", new ErrorViewModel { Erro = erro.ToString() });
            }
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
        public void ValidaDados(EmpresaParceiraViewModel empresa, string operacao)
        {
            EmpresaParceiraDAO dao = new EmpresaParceiraDAO();

            // Validação do ID
            if (empresa.id <= 0)
            {
                ModelState.AddModelError("id", "Id inválido!");
            }
            else
            {
                try
                {
                    if (operacao == "I" && dao.Consulta(empresa.id) != null)
                        ModelState.AddModelError("id", "Código já está em uso.");
                    if (operacao == "A" && dao.Consulta(empresa.id) == null)
                        ModelState.AddModelError("id", "Empresa não existe.");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("id", $"Erro ao validar ID: {ex.Message}");
                }
            }

            // Validação do Nome
            if (string.IsNullOrEmpty(empresa.nm_empr))
                ModelState.AddModelError("nm_empr", "Preencha o nome.");

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


        private void PreparaListaFuncionariosParaCombo()
        {
            FuncionarioDAO funcionarioDao = new FuncionarioDAO();
            var funcionarios = funcionarioDao.ListaFuncionarios();
            List<SelectListItem> listaFuncionarios = new List<SelectListItem>();

            listaFuncionarios.Add(new SelectListItem("Selecione Login de um funcionário...", "0"));
            foreach (var funcionario in funcionarios)
            {
                SelectListItem item = new SelectListItem(funcionario.login_func, funcionario.id.ToString());
                listaFuncionarios.Add(item);
            }
            ViewBag.Funcionarios = listaFuncionarios;
        }
    }
}