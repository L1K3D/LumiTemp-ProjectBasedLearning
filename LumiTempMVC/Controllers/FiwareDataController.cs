using LumiTempMVC.DAO;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LumiTempMVC.Controllers
{
    public class FiwareDataController : Controller
    {

        private readonly SensorDAO _sensorDAO;

        public FiwareDataController()
        {
            _sensorDAO = new SensorDAO();
        }

        public IActionResult Index()
        {
            var sensores = _sensorDAO.Listagem();
            return View(sensores);
        }
    }
}
