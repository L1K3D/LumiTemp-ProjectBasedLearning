using LumiTempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using LumiTempMVC.DAO;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace LumiTempMVC.Controllers
{
    public class FuncionarioController : PadraoController<FuncionarioViewModel>
    {


        // Exibe a lista de funcionários cadastrados
        public FuncionarioController()
        {
            DAO = new FuncionarioDAO();
            GeraProximoId = true;
            NomeViewForm = "Form";
            NomeViewIndex = "Index";
            NecessitaCaixaComboEmpresas = false;
            NecessitaCaixaComboFuncionarios = false;
            PossuiCampoData = true;
            ExigeAutenticacao = false;

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

        protected override void ValidaDados(FuncionarioViewModel funcionario, string operacao)
        {

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