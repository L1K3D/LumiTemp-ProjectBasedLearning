using LumiTempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using LumiTempMVC.DAO;

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
                SensorViewModel sensor = new SensorViewModel(); // Cria um novo objeto SensorViewModel
                SensorDAO dao = new SensorDAO(); // Instancia o DAO para operações de banco de dados
                sensor.cd_sens = dao.ProximoId(); // Atribui o próximo ID disponível ao novo sensor

                return View("Form", sensor); // Retorna a View do formulário para preenchimento dos dados do sensor
            }
            catch (Exception erro)
            {
                // Em caso de erro, redireciona para a página de erro, passando a mensagem de erro
                return RedirectToAction("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        // Método para salvar um sensor novo ou atualizar um sensor existente
        public IActionResult Salvar(SensorViewModel sensor)
        {
            try
            {
                SensorDAO dao = new SensorDAO(); // Instancia o DAO para operações de banco de dados
                if (dao.Consulta(sensor.cd_sens) == null) // Verifica se o sensor já existe
                    dao.Inserir(sensor); // Se não existir, insere o novo sensor
                else
                    dao.Alterar(sensor); // Se já existir, atualiza os dados do sensor

                return RedirectToAction("Index"); // Redireciona para a página inicial com a lista de sensores
            }
            catch (Exception erro)
            {
                // Em caso de erro, retorna a View de erro com a mensagem detalhada
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        // Método para editar os dados de um sensor existente
        public IActionResult Edit(int cd_sens)
        {
            try
            {
                SensorDAO dao = new SensorDAO(); // Instancia o DAO para consulta no banco de dados
                SensorViewModel sensor = dao.Consulta(cd_sens); // Busca o sensor pelo ID
                if (sensor == null)
                    return RedirectToAction("Index"); // Se o sensor não existir, redireciona para a lista
                else
                    return View("Form", sensor); // Se existir, retorna a View do formulário com os dados preenchidos
            }
            catch (Exception erro)
            {
                // Em caso de erro, retorna a View de erro com a mensagem detalhada
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        // Método para excluir um sensor pelo seu ID
        public IActionResult Delete(int cd_sens)
        {
            try
            {
                SensorDAO dao = new SensorDAO(); // Instancia o DAO para a exclusão
                dao.Excluir(cd_sens); // Exclui o sensor do banco de dados
                return RedirectToAction("Index"); // Após a exclusão, redireciona para a lista de sensores
            }
            catch (Exception erro)
            {
                // Em caso de erro, retorna a View de erro com a mensagem detalhada
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
    }
}