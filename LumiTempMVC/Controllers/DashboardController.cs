using Microsoft.AspNetCore.Mvc;
using LumiTempMVC.DAO;
using LumiTempMVC.Models;
using System.Collections.Generic;

namespace LumiTempMVC.Controllers
{
    public class DashboardController : Controller
    {
        private readonly SensorDAO _sensorDao;
        private readonly FuncionarioDAO _funcionarioDao;
        private readonly EmpresaParceiraDAO _empresaParceiraDao;

        public DashboardController()
        {
            _sensorDao = new SensorDAO();
            _funcionarioDao = new FuncionarioDAO();
            _empresaParceiraDao = new EmpresaParceiraDAO();
        }

        public IActionResult Index()
        {
            var sensores = _sensorDao.Listagem();
            var funcionarios = _funcionarioDao.Listagem();
            var empresas = _empresaParceiraDao.Listagem();

            var model = new DashboardViewModel
            {
                Sensores = sensores,
                Funcionarios = funcionarios,
                Empresas = empresas
            };

            return View(model);
        }
    }
}