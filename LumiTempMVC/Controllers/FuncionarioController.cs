using LumiTempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using LumiTempMVC.DAO;

namespace LumiTempMVC.Controllers
{
    // Controlador responsável por gerenciar as operações relacionadas aos funcionários
    public class FuncionarioController : Controller
    {
        // Método para exibir a página inicial com a lista de funcionários cadastrados
        public IActionResult Index()
        {
            FuncionarioDAO dao = new FuncionarioDAO(); // Instancia o DAO para acessar os dados dos funcionários
            List<FuncionarioViewModel> lista = dao.Listagem(); // Busca a lista de funcionários cadastrados
            return View(lista); // Retorna a View com a lista de funcionários
        }

        // Método para criar um novo funcionário
        public IActionResult Create()
        {
            try
            {
                FuncionarioViewModel funcionario = new FuncionarioViewModel(); // Cria um novo objeto FuncionarioViewModel
                FuncionarioDAO dao = new FuncionarioDAO(); // Instancia o DAO para operações de banco de dados
                funcionario.cd_func = dao.ProximoId(); // Atribui o próximo ID disponível ao novo funcionário

                return View("Form", funcionario); // Retorna a View do formulário para preenchimento dos dados do funcionário
            }
            catch (Exception erro)
            {
                // Em caso de erro, redireciona para a página de erro, passando a mensagem de erro
                return RedirectToAction("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        // Método para salvar um novo funcionário ou atualizar um funcionário existente
        public IActionResult Salvar(FuncionarioViewModel funcionario)
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO(); // Instancia o DAO para operações de banco de dados
                if (dao.Consulta(funcionario.cd_func) == null) // Verifica se o funcionário já existe
                    dao.Inserir(funcionario); // Se não existir, insere o novo funcionário
                else
                    dao.Alterar(funcionario); // Se já existir, atualiza os dados do funcionário

                return RedirectToAction("Index"); // Redireciona para a página inicial com a lista de funcionários
            }
            catch (Exception erro)
            {
                // Em caso de erro, retorna a View de erro com a mensagem detalhada
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        // Método para editar os dados de um funcionário existente
        public IActionResult Edit(int cd_func)
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO(); // Instancia o DAO para consulta no banco de dados
                FuncionarioViewModel funcionario = dao.Consulta(cd_func); // Busca o funcionário pelo ID
                if (funcionario == null)
                    return RedirectToAction("Index"); // Se o funcionário não existir, redireciona para a lista
                else
                    return View("Form", funcionario); // Se existir, retorna a View do formulário com os dados preenchidos
            }
            catch (Exception erro)
            {
                // Em caso de erro, retorna a View de erro com a mensagem detalhada
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        // Método para excluir um funcionário pelo seu ID
        public IActionResult Delete(int id)
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO(); // Instancia o DAO para a exclusão
                dao.Excluir(id); // Exclui o funcionário do banco de dados
                return RedirectToAction("Index"); // Após a exclusão, redireciona para a lista de funcionários
            }
            catch (Exception erro)
            {
                // Em caso de erro, retorna a View de erro com a mensagem detalhada
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
    }
}