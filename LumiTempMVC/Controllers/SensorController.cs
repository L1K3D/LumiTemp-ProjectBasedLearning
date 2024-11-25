using LumiTempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using LumiTempMVC.DAO;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.Data.SqlTypes;

namespace LumiTempMVC.Controllers
{
    // Controlador responsável por gerenciar as operações relacionadas aos sensores
    public class SensorController : PadraoController<SensorViewModel>
    {
        
        public SensorController()
        {

            DAO = new SensorDAO();
            GeraProximoId = true;
            NomeViewForm = "Form";
            NomeViewIndex = "Index";
            NecessitaCaixaComboEmpresas = true;
            NecessitaCaixaComboFuncionarios = true;
            PossuiCampoData = true;
            ExigeAutenticacao = true;

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

        protected override void ValidaDados(SensorViewModel sensor, string operacao)
        {
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
        protected override void PreencheDadosParaView(string Operacao, SensorViewModel model)
        {
            base.PreencheDadosParaView(Operacao, model);
            model.dt_vend = DateTime.Now;
            PreparaListaFuncionariosParaCombo();
            PreparaListaEmpresasParceirasParaCombo();

            List<SelectListItem> listaTipos = new List<SelectListItem>();
            listaTipos.Add(new SelectListItem("Selecione um tipo...", "0"));
            listaTipos.Add(new SelectListItem("LUMINOSIDADE", "LUMINOSIDADE"));
            listaTipos.Add(new SelectListItem("UMIDADE", "UMIDADE"));
            listaTipos.Add(new SelectListItem("TEMPERATURA", "TEMPERATURA"));
            ViewBag.Tipos = listaTipos;
        }
        public IActionResult ExibeConsultaAvancada()
        {
            try
            {
                PreparaComboEmpresas();
                ViewBag.empresas.Insert(0, new SelectListItem("TODAS", "0"));
                return View("ConsultaAvancada");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.Message));
            }
        }
        public IActionResult ObtemDadosConsultaAvancada2(string descricao, int empresa, DateTime dataInicial,
            DateTime dataFinal)
        {
            try
            {
                SensorDAO dao = new SensorDAO();
                if (string.IsNullOrEmpty(descricao))
                    descricao = "";
                if (dataInicial.Date == Convert.ToDateTime("01/01/0001"))
                    dataInicial = SqlDateTime.MinValue.Value;
                if (dataFinal.Date == Convert.ToDateTime("01/01/0001"))
                    dataFinal = SqlDateTime.MaxValue.Value;
                var lista = dao.ConsultaAvancadaSensores(descricao, empresa, dataInicial, dataFinal);
                return PartialView("pvGridSensores", lista);
            }
            catch (Exception erro)
            {
                return Json(new { erro = true, msg = erro.Message });
            }
        }
        private void PreparaComboEmpresas()
        {
            EmpresaParceiraDAO dao = new EmpresaParceiraDAO();
            var lista = dao.Listagem();
            List<SelectListItem> listaRetorno = new List<SelectListItem>();
            foreach (var categ in lista)
                listaRetorno.Add(new SelectListItem(categ.nm_empr, categ.id.ToString()));

            ViewBag.Empresas = listaRetorno;
        }

    }

}