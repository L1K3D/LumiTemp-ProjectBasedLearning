using LumiTempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using LumiTempMVC.DAO;

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
                EmpresaParceiraViewModel empresa = new EmpresaParceiraViewModel(); // Cria um novo objeto EmpresaParceiraViewModel
                EmpresaParceiraDAO dao = new EmpresaParceiraDAO(); // Instancia o DAO para operações de banco de dados
                empresa.cd_empr = dao.ProximoId(); // Atribui o próximo ID disponível para a nova empresa

                return View("Form", empresa); // Retorna a View do formulário para preenchimento dos dados
            }
            catch (Exception erro)
            {
                // Em caso de erro, redireciona para a página de erro, passando a mensagem de erro
                return RedirectToAction("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        // Método para salvar uma nova empresa ou atualizar uma existente
        public IActionResult Salvar(EmpresaParceiraViewModel empresa)
        {
            try
            {
                EmpresaParceiraDAO dao = new EmpresaParceiraDAO(); // Instancia o DAO para operações no banco
                if (dao.Consulta(empresa.cd_empr) == null) // Verifica se a empresa já existe
                    dao.Inserir(empresa); // Se não existir, insere a nova empresa
                else
                    dao.Alterar(empresa); // Se já existir, atualiza os dados da empresa

                return RedirectToAction("Index"); // Redireciona para a lista de empresas
            }
            catch (Exception erro)
            {
                // Em caso de erro, retorna a View de erro com a mensagem detalhada
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        // Método para editar os dados de uma empresa parceira existente
        public IActionResult Edit(int cd_empr)
        {
            try
            {
                EmpresaParceiraDAO dao = new EmpresaParceiraDAO(); // Instancia o DAO para consulta no banco de dados
                EmpresaParceiraViewModel empresa = dao.Consulta(cd_empr); // Busca a empresa pelo ID
                if (empresa == null)
                    return RedirectToAction("Index"); // Se a empresa não existir, redireciona para a lista
                else
                    return View("Form", empresa); // Se existir, retorna a View de formulário com os dados preenchidos
            }
            catch (Exception erro)
            {
                // Em caso de erro, retorna a View de erro com a mensagem detalhada
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        // Método para excluir uma empresa parceira pelo seu ID
        public IActionResult Delete(int cd_empr)
        {
            try
            {
                EmpresaParceiraDAO dao = new EmpresaParceiraDAO(); // Instancia o DAO para a exclusão
                dao.Excluir(cd_empr); // Exclui a empresa parceira do banco de dados
                return RedirectToAction("Index"); // Após a exclusão, redireciona para a lista de empresas
            }
            catch (Exception erro)
            {
                // Em caso de erro, retorna a View de erro com a mensagem detalhada
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
    }
}