using LumiTempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using LumiTempMVC.DAO;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace LumiTempMVC.Controllers
{
    public class FuncionarioController : Controller
    {
        // Exibe a lista de funcionários cadastrados
        public IActionResult Index()
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            var lista = dao.Listagem();
            return View(lista);
        }

        // Exibe o formulário de criação de um novo funcionário
        public IActionResult Create()
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO();
                FuncionarioViewModel funcionario = new FuncionarioViewModel
                {
                    id = dao.ProximoId(), // Gera o próximo ID disponível
                    dt_cadr = DateTime.Now // Define a data de cadastro atual
                };
                return View("Form", funcionario);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel { Erro = erro.ToString() });
            }
        }

        // Método para salvar o funcionário (novo ou existente)
        [HttpPost]
        public IActionResult Salvar(FuncionarioViewModel funcionario)
        {
            if (!ModelState.IsValid)
            {
                // Se o modelo não for válido, retorna o formulário com os dados para correção
                return View("Form", funcionario);
            }

            try
            {
                FuncionarioDAO dao = new FuncionarioDAO();
                if (funcionario.id == 0 || dao.Consulta(funcionario.id) == null)
                {
                    // Se for um novo funcionário, insere
                    dao.Inserir(funcionario);
                }
                else
                {
                    // Se já existir, faz a atualização
                    dao.Alterar(funcionario);
                }

                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                // Em caso de erro, retorna a View de erro
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

        /// <summary>
        /// Converte a imagem recebida no form em um vetor de bytes
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public byte[] ConvertImageToByte(IFormFile file)
        {
            if (file != null)
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    return ms.ToArray();
                }
            else
                return null;
        }


    }
}