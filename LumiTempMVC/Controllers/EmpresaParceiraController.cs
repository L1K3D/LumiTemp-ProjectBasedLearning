using LumiTempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using LumiTempMVC.DAO;
using System.Text;

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
        public IActionResult Create()
        {
            try
            {
                EmpresaParceiraDAO dao = new EmpresaParceiraDAO();
                EmpresaParceiraViewModel empresa = new EmpresaParceiraViewModel
                {

                    id = dao.ProximoId()

                };

                return View("Form", empresa);

            }
            catch (Exception erro)
            {
                // Em caso de erro, redireciona para a página de erro, passando a mensagem de erro
                return View("Error", new ErrorViewModel { Erro = erro.ToString() });
            }
        }

        [HttpPost]
        public IActionResult Salvar(EmpresaParceiraViewModel empresa)
        {
            if (!ModelState.IsValid)
            {
                // Se o modelo não for válido, retorna o formulário com os dados para correção
                return View("Form", empresa);
            }

            try
            {
                EmpresaParceiraDAO dao = new EmpresaParceiraDAO();
                if (empresa.id == 0 || dao.Consulta(empresa.id) == null)
                {
                    // Se for um novo funcionário, insere
                    dao.Inserir(empresa);
                }
                else
                {
                    // Se já existir, faz a atualização
                    dao.Alterar(empresa);
                }

                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                // Em caso de erro, retorna a View de erro
                return View("Error", new ErrorViewModel { Erro = erro.ToString() });
            }
        }

        // Método para editar os dados de uma empresa parceira existente
        public IActionResult Edit(int id)
        {
            try
            {
                EmpresaParceiraDAO dao = new EmpresaParceiraDAO();
                var empresa = dao.Consulta(id);
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

    }
}