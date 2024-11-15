using LumiTempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using LumiTempMVC.DAO;
using System.Collections.Generic;
using System.Text;

namespace LumiTempMVC.Controllers
{
    public class FuncionarioController : Controller
    {
        // Exibe a lista de funcionários cadastrados
        public IActionResult Index()
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            List<FuncionarioViewModel> lista = dao.Listagem();
            return View(lista);
        }

        // Exibe o formulário de criação de um novo funcionário
        public IActionResult Create()
        {
            ViewBag.Operacao = "I";
            try
            {
                FuncionarioViewModel funcionario = new FuncionarioViewModel();
                FuncionarioDAO dao = new FuncionarioDAO();
                funcionario.id = dao.ProximoId();
                funcionario.dt_cadr = DateTime.Now;
                return View("Form", funcionario);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        // Método para salvar o funcionário (novo ou existente)
        public IActionResult Salvar(FuncionarioViewModel funcionario, string operacao)
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO();

                ModelState.Clear();
                ValidaDados(funcionario, operacao);

                if (funcionario.id <= 0)
                    ModelState.AddModelError("id", "Campo obrigatório!");
                if (string.IsNullOrEmpty(funcionario.login_func))
                    ModelState.AddModelError("login_func", "Campo obrigatório!");
                if (string.IsNullOrEmpty(funcionario.senha_func))
                    ModelState.AddModelError("senha_func", "Campo obrigatório!");
                if (funcionario.dt_cadr == DateTime.MinValue)
                    ModelState.AddModelError("dt_cadr", "Campo obrigatório!");


                if (ModelState.IsValid)
                {
                    if (operacao == "I")
                        dao.Inserir(funcionario);
                    else
                        dao.Alterar(funcionario);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.operacao = operacao;
                    return View("form", funcionario);
                }
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel { Erro = erro.ToString() });
            }

        }

        // Método para editar um funcionário existente
        public IActionResult Edit(int id)
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO();
                var funcionario = dao.Consulta(id);
                if (funcionario == null)
                {
                    return RedirectToAction("Index");
                }
                return View("Form", funcionario);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel { Erro = erro.ToString() });
            }
        }

        // Método para excluir um funcionário
        public IActionResult Delete(int id)
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO();
                dao.Excluir(id);
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel { Erro = erro.ToString() });
            }
        }

        public IActionResult ExtrairDados()
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO(); // Instancia o DAO para acessar os dados de funcionarios
                List<FuncionarioViewModel> lista = dao.Listagem(); // Obtém a lista de funcionarios do banco de dados

                // Criação do conteúdo do arquivo
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Id, Nome"); // Cabeçalho do arquivo

                foreach (var funcionario in lista)
                {
                    sb.AppendLine($"{funcionario.id}, {funcionario.login_func}, {funcionario.dt_cadr}"); // Adiciona cada funcionario ao arquivo
                }

                // Definindo o nome do arquivo
                string fileName = "funcionarios.txt";

                // Retorna o arquivo para download
                return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/plain", fileName);
            }
            catch (Exception erro)
            {
                // Em caso de erro, redireciona para a página de erro com a mensagem de erro
                return RedirectToAction("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        public void ValidaDados(FuncionarioViewModel funcionario, string operacao)
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            // Validação do ID
            if (funcionario.id <= 0)
            {
                ModelState.AddModelError("id", "Id inválido!");
            }
            else
            {
                try
                {
                    if (operacao == "I" && dao.Consulta(funcionario.id) != null)
                        ModelState.AddModelError("id", "Código já está em uso.");
                    if (operacao == "A" && dao.Consulta(funcionario.id) == null)
                        ModelState.AddModelError("id", "Empresa não existe.");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("id", $"Erro ao validar ID: {ex.Message}");
                }
            }

            // Validação do Nome
            if (string.IsNullOrEmpty(funcionario.login_func))
                ModelState.AddModelError("login_func", "Preencha o login");

            // Validação do CNPJ: 14 dígitos
            if (string.IsNullOrEmpty(funcionario.senha_func))
                ModelState.AddModelError("senha_func", "Preencha a senha.");

            if (funcionario.dt_cadr == DateTime.MinValue)
                ModelState.AddModelError("dt_cadr", "Preencha uma data");

        }

    }
}