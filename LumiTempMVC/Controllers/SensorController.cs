using LumiTempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using LumiTempMVC.DAO;
using System.Text;

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
                SensorDAO dao = new SensorDAO();
                SensorViewModel sensor = new SensorViewModel
                {
                    id = dao.ProximoId(), // Gera o próximo ID disponível
                    dt_vend = DateTime.Now // Define a data de cadastro atual
                };
                return View("Form", sensor);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel { Erro = erro.ToString() });
            }
        }

        // Método para salvar o sensor (novo ou existente)
        [HttpPost]
        public IActionResult Salvar(SensorViewModel sensor)
        {
            if (!ModelState.IsValid)
            {
                // Se o modelo não for válido, retorna o formulário com os dados para correção
                return View("Form", sensor);
            }

            try
            {
                SensorDAO dao = new SensorDAO();
                if (sensor.id == 0 || dao.Consulta(sensor.id) == null)
                {
                    // Se for um novo funcionário, insere
                    dao.Inserir(sensor);
                }
                else
                {
                    // Se já existir, faz a atualização
                    dao.Alterar(sensor);
                }

                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                // Em caso de erro, retorna a View de erro
                return View("Error", new ErrorViewModel(erro.ToString()));  
            }
        }

        // Método para editar os dados de um sensor existente
        public IActionResult Edit(int id)
        {
            try
            {
                SensorDAO dao = new SensorDAO();
                var sensor = dao.Consulta(id);
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
                dao.Excluir(id); // Exclui o sensor do banco de dados
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

    }
}