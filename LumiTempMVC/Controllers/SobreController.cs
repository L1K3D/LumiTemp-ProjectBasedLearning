using LumiTempMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace LumiTempMVC.Controllers
{
    // Controller responsável pelas ações da página "Sobre" da aplicação.
    public class SobreController : Controller
    {
        // Injeção de dependência do serviço de logging para registrar informações e erros.
        private readonly ILogger<SobreController> _logger;

        // Construtor que recebe o serviço de logger como parâmetro e o inicializa.
        public SobreController(ILogger<SobreController> logger)
        {
            _logger = logger;
        }

        // Método que retorna a view da página principal "Sobre".
        public IActionResult Index()
        {
            return View();
        }

        // Método que retorna a view da página de política de privacidade.
        public IActionResult Privacy()
        {
            return View();
        }

        // Método que retorna a view de erro, com informações detalhadas do erro.
        // ResponseCache é desabilitado para que os erros não sejam armazenados em cache.
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Cria um novo modelo de erro com o ID da requisição atual ou do TraceIdentifier do HttpContext.
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}