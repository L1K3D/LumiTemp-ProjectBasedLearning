using System;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LumiTempMVC.DAO;

namespace LumiTempMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FazLogin(string usuario, string senha)
        {
            try
            {
                // Consultar o banco de dados para verificar o login e a senha
                using (SqlConnection conexao = ConexaoDB.GetConexao())
                {
                    string query = "SELECT COUNT(*) FROM cadr_func WHERE LOGIN_FUNC = @Usuario AND SENHA_FUNC = @Senha";
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        // Adicionar parâmetros para evitar SQL Injection
                        comando.Parameters.AddWithValue("@Usuario", usuario);
                        comando.Parameters.AddWithValue("@Senha", senha);

                        // Executar a consulta e verificar se o usuário existe
                        int count = (int)comando.ExecuteScalar();
                        if (count > 0)
                        {
                            // Login bem-sucedido
                            HttpContext.Session.SetString("Logado", "true");
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            // Usuário ou senha inválidos
                            ViewBag.Erro = "Usuário ou senha inválidos!";
                            return View("Index");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Tratar erros de banco de dados
                ViewBag.Erro = "Ocorreu um erro ao processar a sua solicitação. Por favor, tente novamente.";
                Console.WriteLine(ex.Message); // Log do erro no console
                return View("Index");
            }
        }

        public IActionResult LogOff()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
