using LumiTempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using LumiTempMVC.DAO;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.SqlTypes;

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

        public IActionResult ExtrairDados()
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO(); // Instancia o DAO para acessar os dados de funcionarios
                List<FuncionarioViewModel> lista = dao.Listagem(); // Obtém a lista de funcionarios do banco de dados

                // Criação do conteúdo do arquivo
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Id, Login Funcionário, Data de cadastro funcionário"); // Cabeçalho do arquivo

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

            //Imagem será obrigatio apenas na inclusão.
            //Na alteração iremos considerar a que já estava salva.
            if (funcionario.Imagem == null && operacao == "I")
                ModelState.AddModelError("Imagem", "Escolha uma imagem.");
            if (funcionario.Imagem != null && funcionario.Imagem.Length / 1024 / 1024 >= 2)
                ModelState.AddModelError("Imagem", "Imagem limitada a 2 mb.");
            if (ModelState.IsValid)
            {
                //na alteração, se não foi informada a imagem, iremos manter a que já estava salva.
                if (operacao == "A" && funcionario.Imagem == null)
                {
                    FuncionarioViewModel cid = DAO.Consulta(funcionario.id);
                    funcionario.ImagemEmByte = cid.ImagemEmByte;
                }
                else
                {
                    funcionario.ImagemEmByte = ConvertImageToByte(funcionario.Imagem);
                }
            }
        }
        protected override void PreencheDadosParaView(string Operacao, FuncionarioViewModel model)
        {
            base.PreencheDadosParaView(Operacao, model);
            model.dt_cadr = DateTime.Now;
        }
        public IActionResult ExibeConsultaAvancada()
        {
            try
            {
                return View("ConsultaAvancada");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.Message));
            }
        }
        public IActionResult ObtemDadosConsultaAvancada(string descricao, DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO();
                if (string.IsNullOrEmpty(descricao))
                    descricao = "";
                if (dataInicial.Date == Convert.ToDateTime("01/01/0001"))
                    dataInicial = SqlDateTime.MinValue.Value;
                if (dataFinal.Date == Convert.ToDateTime("01/01/0001"))
                    dataFinal = SqlDateTime.MaxValue.Value;
                var lista = dao.ConsultaAvancadaFuncionarios(descricao, dataInicial, dataFinal);
                return PartialView("pvGridFuncionarios", lista);
            }
            catch (Exception erro)
            {
                return Json(new { erro = true, msg = erro.Message });
            }
        }
    }
}