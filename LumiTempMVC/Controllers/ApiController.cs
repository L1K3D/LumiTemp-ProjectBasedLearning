using LumiTempMVC.DAO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LumiTempMVC.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {

        private readonly FiwareDataDAO _fiwareDataDAO;

        public ApiController()
        {

            _fiwareDataDAO = new FiwareDataDAO();

        }

        [HttpGet("temperature")]
        public async Task<IActionResult> GetTemperatureData(int lastN)
        {
            var data = await _fiwareDataDAO.GetTemperatureDataAsync(lastN);
            if (data.Count == 0)
            {
                return NotFound("Sem dados de temperatura");
            }
            return Ok(data);
        }

    }
}