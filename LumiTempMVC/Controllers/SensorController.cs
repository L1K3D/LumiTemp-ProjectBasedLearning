using LumiTempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using LumiTempMVC.DAO;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LumiTempMVC.Controllers
{
    // Controlador responsável por gerenciar as operações relacionadas aos sensores
    public class SensorController : Controller
    {
        // Método para exibir a página inicial com a lista de sensores cadastrados
        public IActionResult Index()
        {
            SensorDAO dao = new SensorDAO(); // Instancia o DAO para acessar os dados dos sensores
            List<SensorViewModel> lista = dao.Listagem(); // Busca a lista de sensores cadastrados
            return View(lista); // Retorna a View com a lista de sensores
        }

        // Método para criar um novo sensor
        public IActionResult Create()
        {
            try
            {
                SensorViewModel sensor = new SensorViewModel();
                SensorDAO dao = new SensorDAO();
                sensor.id = dao.ProximoId();
                sensor.dt_vend = DateTime.Now;
                PreparaListaEmpresasParceirasParaCombo();
                PreparaListaFuncionariosParaCombo();
                return View("Form", sensor);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel { Erro = erro.ToString() });
            }
        }

        public IActionResult Salvar(SensorViewModel sensor, string operacao)
        {
            try
            {
                SensorDAO dao = new SensorDAO();

                PreparaListaEmpresasParceirasParaCombo();
                PreparaListaFuncionariosParaCombo();

                ModelState.Clear();
                ValidaDados(sensor, operacao);

                if (sensor.id <= 0)
                    ModelState.AddModelError("id", "Campo obrigatório!");
                if (string.IsNullOrEmpty(sensor.ds_tipo_sens))
                    ModelState.AddModelError("ds_tipo_sens", "Campo obrigatório!");
                if (sensor.dt_vend == DateTime.MinValue)
                    ModelState.AddModelError("dt_vend", "Campo obrigatório!");
                if (sensor.vl_temp_alvo <= 0.00)
                    ModelState.AddModelError("vl_temp_alvo", "Campo obrigatório!");
                if (sensor.cd_motor <= 0)
                    ModelState.AddModelError("cd_motor", "Campo obrigatório!");
                if (sensor.id_func <= 0)
                    ModelState.AddModelError("id_func", "Campo obrigatório!");
                if (sensor.id_empr <= 0)
                    ModelState.AddModelError("id_empr", "Campo obrigatório!");


                if (ModelState.IsValid)
                {
                    if (operacao != "I")
                        dao.Insert(sensor);
                    else
                        dao.Update(sensor);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.operacao = operacao;
                    return View("form", sensor);
                }
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel { Erro = erro.ToString() });
            }

        }

        // Método para editar os dados de um sensor existente
        public IActionResult Edit(int id)
        {
            try
            {
                SensorDAO dao = new SensorDAO();
                var sensor = dao.Consulta(id);
                PreparaListaEmpresasParceirasParaCombo();
                PreparaListaFuncionariosParaCombo();
                if (sensor == null)
                {
                    return RedirectToAction("Index");
                }
                return View("Form", sensor);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel { Erro = erro.ToString() });
            }
        }

        // Método para excluir um sensor pelo seu ID
        public IActionResult Delete(int id)
        {
            try
            {
                SensorDAO dao = new SensorDAO(); // Instancia o DAO para a exclusão
                dao.Delete(id); // Exclui o sensor do banco de dados
                return RedirectToAction("Index"); // Após a exclusão, redireciona para a lista de sensores
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
                SensorDAO dao = new SensorDAO(); // Instancia o DAO para acessar os dados de funcionarios
                List<SensorViewModel> lista = dao.Listagem(); // Obtém a lista de funcionarios do banco de dados

                // Criação do conteúdo do arquivo
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Id, Descrição do tipo de sensor, Data da venda do sensor, valor da temperatura alvo configurada, código do motor atrelado ao sensor, id do funcionário atrelado ao sensor, id da empresa atrelada ao sensor"); // Cabeçalho do arquivo

                foreach (var sensor in lista)
                {
                    sb.AppendLine($"{sensor.id}, {sensor.ds_tipo_sens}, {sensor.dt_vend}, {sensor.vl_temp_alvo}, {sensor.cd_motor}, {sensor.id_func}, {sensor.id_empr}"); // Adiciona cada funcionario ao arquivo
                }

                // Definindo o nome do arquivo
                string fileName = "sensores.txt";

                // Retorna o arquivo para download
                return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/plain", fileName);
            }
            catch (Exception erro)
            {
                // Em caso de erro, redireciona para a página de erro com a mensagem de erro
                return RedirectToAction("Error", new ErrorViewModel(erro.ToString()));
            }
        }
        private void PreparaListaFuncionariosParaCombo()
        {
            FuncionarioDAO funcionarioDao = new FuncionarioDAO();
            var funcionarios = funcionarioDao.Listagem();
            List<SelectListItem> listaFuncionarios = new List<SelectListItem>();

            listaFuncionarios.Add(new SelectListItem("Selecione Login de um funcionário...", "0"));
            foreach (var funcionario in funcionarios)
            {
                SelectListItem item = new SelectListItem(funcionario.login_func, funcionario.id.ToString());
                listaFuncionarios.Add(item);
            }
            ViewBag.Funcionarios = listaFuncionarios;
        }
        private void PreparaListaEmpresasParceirasParaCombo()
        {
            EmpresaParceiraDAO empresaDao = new EmpresaParceiraDAO();
            var empresas = empresaDao.Listagem();
            List<SelectListItem> listaEmpresas = new List<SelectListItem>();

            listaEmpresas.Add(new SelectListItem("Selecione uma empresa...", "0"));
            foreach (var empresa in empresas)
            {
                SelectListItem item = new SelectListItem(empresa.nm_empr, empresa.id.ToString());
                listaEmpresas.Add(item);
            }
            ViewBag.Empresas = listaEmpresas;
        }

        public void ValidaDados(SensorViewModel sensor, string operacao)
        {
            SensorDAO dao = new SensorDAO();

            // Validação do ID
            if (sensor.id <= 0)
            {
                ModelState.AddModelError("id", "Id inválido!");
            }
            else
            {
                try
                {
                    if (operacao == "I" && dao.Consulta(sensor.id) != null)
                        ModelState.AddModelError("id", "Código já está em uso.");
                    if (operacao == "A" && dao.Consulta(sensor.id) == null)
                        ModelState.AddModelError("id", "Empresa não existe.");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("id", $"Erro ao validar ID: {ex.Message}");
                }
            }

            // Validação do Nome
            if (string.IsNullOrEmpty(sensor.ds_tipo_sens))
                ModelState.AddModelError("ds_tipo_sens", "Preencha a descrição do sensor");

            if (sensor.dt_vend == DateTime.MinValue)
                ModelState.AddModelError("dt_vend", "Preencha uma data correta");

            if (sensor.vl_temp_alvo <= 0.00)
                ModelState.AddModelError("vl_temp_alvo", "Preencha o valor alvo");

            if (sensor.cd_motor <= 0)
                ModelState.AddModelError("cd_motor", "Preencha o código de um motor");

        }

    }

}