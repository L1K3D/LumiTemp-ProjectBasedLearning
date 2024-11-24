using LumiTempMVC.DAO; // Namespace para acesso às classes DAO (Data Access Object)
using LumiTempMVC.Models; // Namespace para acesso aos modelos
using Microsoft.AspNetCore.Mvc; // Namespace para criação de Controllers no ASP.NET Core MVC
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic; // Namespace padrão do .NET, usado aqui para tratar exceções
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LumiTempMVC.Controllers
{
    // Controller genérico que gerencia operações para qualquer ViewModel derivado de PadraoViewModel
    public class PadraoController<T> : Controller where T : PadraoViewModel
    {
        // DAO genérico para manipulação de dados do tipo T
        protected PadraoDAO<T> DAO { get; set; }

        // Indica se a aplicação deve gerar automaticamente o próximo ID para novos registros
        protected bool GeraProximoId { get; set; }

        // Nome da View que será usada para exibir a lista de registros
        protected string NomeViewIndex { get; set; }

        // Nome da View que será usada para exibir o formulário de criação/edição de registros
        protected string NomeViewForm { get; set; }

        protected bool NecessitaCaixaComboFuncionarios { get; set; }

        protected bool NecessitaCaixaComboEmpresas { get; set; }

        protected bool PossuiCampoData { get; set; }

        protected bool ExigeAutenticacao { get; set; } = true;

        // Método para exibir a lista de registros
        public virtual IActionResult Index()
        {
            try
            {
                var lista = DAO.Listagem(); // Obtém a lista de registros do DAO
                return View(NomeViewIndex, lista); // Retorna a View correspondente com a lista
            }
            catch (Exception erro)
            {
                // Retorna uma View de erro caso ocorra uma exceção
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        // Método para exibir o formulário de criação de um novo registro
        public virtual IActionResult Create()
        {
            try
            {
                if (NecessitaCaixaComboFuncionarios == true && PossuiCampoData == false)
                {

                    ViewBag.Operacao = "I"; // Define a operação como "Inserção"
                    T model = Activator.CreateInstance<T>(); // Cria uma nova instância do modelo genérico T
                    PreparaListaFuncionariosParaCombo();
                    PreencheDadosParaView("I", model); // Preenche informações adicionais para a View
                    return View(NomeViewForm, model); // Retorna a View do formulário com o modelo

                }
                else if (NecessitaCaixaComboFuncionarios == true && NecessitaCaixaComboEmpresas == true && PossuiCampoData == false)
                {
                    ViewBag.Operacao = "I"; // Define a operação como "Inserção"
                    T model = Activator.CreateInstance<T>(); // Cria uma nova instância do modelo genérico T
                    PreparaListaFuncionariosParaCombo();
                    PreparaListaEmpresasParceirasParaCombo();
                    PreencheDadosParaView("I", model); // Preenche informações adicionais para a View
                    return View(NomeViewForm, model); // Retorna a View do formulário com o modelo

                }
                else if (NecessitaCaixaComboFuncionarios == true && NecessitaCaixaComboEmpresas == true && PossuiCampoData == true)
                {

                    ViewBag.Operacao = "I"; // Define a operação como "Inserção"
                    T model = Activator.CreateInstance<T>(); // Cria uma nova instância do modelo genérico T
                    PreparaListaFuncionariosParaCombo();
                    PreparaListaEmpresasParceirasParaCombo();
                    PreencheDadosParaView("I", model); // Preenche informações adicionais para a View
                    return View(NomeViewForm, model); // Retorna a View do formulário com o modelo

                }
                else
                {

                    ViewBag.Operacao = "I"; // Define a operação como "Inserção"
                    T model = Activator.CreateInstance<T>(); // Cria uma nova instância do modelo genérico T
                    PreencheDadosParaView("I", model); // Preenche informações adicionais para a View
                    return View(NomeViewForm, model); // Retorna a View do formulário com o modelo

                }
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        // Método para preencher dados adicionais antes de exibir a View
        protected virtual void PreencheDadosParaView(string Operacao, T model)
        {
            // Se a operação for de inserção e for necessário gerar o próximo ID
            if (GeraProximoId && Operacao == "I")
                model.id = DAO.ProximoId(); // Define o próximo ID no modelo
        }

        // Método para salvar os dados do formulário
        public virtual IActionResult Save(T model, string Operacao)
        {
            try
            {
                ValidaDados(model, Operacao); // Valida os dados do modelo
                if (ModelState.IsValid == false) // Verifica se existem erros de validação
                {
                    ViewBag.Operacao = Operacao; // Define a operação atual na ViewBag
                    PreencheDadosParaView(Operacao, model); // Preenche dados adicionais para a View
                    return View(NomeViewForm, model); // Retorna o formulário com erros
                }
                else
                {
                    if (Operacao == "I") // Se for uma operação de inserção
                        DAO.Insert(model); // Insere o modelo no banco de dados
                    else // Se for uma operação de atualização
                        DAO.Update(model); // Atualiza o modelo no banco de dados

                    return RedirectToAction(NomeViewIndex); // Redireciona para a lista de registros
                }
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        // Método para validar os dados do modelo antes de salvar
        protected virtual void ValidaDados(T model, string operacao)
        {
            ModelState.Clear(); // Limpa os erros existentes
            if (operacao == "I" && DAO.Consulta(model.id) != null)
                ModelState.AddModelError("id", "Código já está em uso!"); // Erro se ID já existe em inserção
            if (operacao == "A" && DAO.Consulta(model.id) == null)
                ModelState.AddModelError("id", "Este registro não existe!"); // Erro se registro não existe em atualização
            if (model.id <= 0)
                ModelState.AddModelError("id", "Id inválido!"); // Erro se ID for inválido
        }

        // Método para exibir o formulário de edição de um registro
        public IActionResult Edit(int id)
        {
            try
            {
                if (NecessitaCaixaComboFuncionarios == true)
                {
                    PreparaListaFuncionariosParaCombo();
                    ViewBag.Operacao = "A";
                    var model = DAO.Consulta(id); // Busca o registro pelo ID
                    if (model == null)
                        return RedirectToAction(NomeViewIndex); // Redireciona se o registro não for encontrado
                    else
                    {
                        PreencheDadosParaView("A", model); // Preenche dados adicionais para a View
                        return View(NomeViewForm, model); // Retorna o formulário preenchido com o registro
                    }
                }
                else if (NecessitaCaixaComboEmpresas == true)
                {

                    PreparaListaEmpresasParceirasParaCombo();
                    ViewBag.Operacao = "A";
                    var model = DAO.Consulta(id); // Busca o registro pelo ID
                    if (model == null)
                        return RedirectToAction(NomeViewIndex); // Redireciona se o registro não for encontrado
                    else
                    {
                        PreencheDadosParaView("A", model); // Preenche dados adicionais para a View
                        return View(NomeViewForm, model); // Retorna o formulário preenchido com o registro
                    }

                }
                else if (NecessitaCaixaComboEmpresas == true && NecessitaCaixaComboFuncionarios == true)
                {

                    PreparaListaFuncionariosParaCombo();
                    PreparaListaEmpresasParceirasParaCombo();
                    ViewBag.Operacao = "A";
                    var model = DAO.Consulta(id); // Busca o registro pelo ID
                    if (model == null)
                        return RedirectToAction(NomeViewIndex); // Redireciona se o registro não for encontrado
                    else
                    {
                        PreencheDadosParaView("A", model); // Preenche dados adicionais para a View
                        return View(NomeViewForm, model); // Retorna o formulário preenchido com o registro
                    }

                }
                else
                {

                    ViewBag.Operacao = "A";
                    var model = DAO.Consulta(id); // Busca o registro pelo ID
                    if (model == null)
                        return RedirectToAction(NomeViewIndex); // Redireciona se o registro não for encontrado
                    else
                    {
                        PreencheDadosParaView("A", model); // Preenche dados adicionais para a View
                        return View(NomeViewForm, model); // Retorna o formulário preenchido com o registro
                    }

                }

            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        // Método para excluir um registro
        public IActionResult Delete(int id)
        {
            try
            {
                DAO.Delete(id); // Exclui o registro pelo ID
                return RedirectToAction(NomeViewIndex); // Redireciona para a lista de registros
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        protected virtual void PreparaListaFuncionariosParaCombo()
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

        protected virtual void PreparaListaEmpresasParceirasParaCombo()
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

        private void PreparaCamposDeData()
        {

            FuncionarioViewModel funcionario = new FuncionarioViewModel();
            funcionario.dt_cadr = DateTime.Now;

            SensorViewModel sensor = new SensorViewModel();
            sensor.dt_vend = DateTime.Now;

        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (ExigeAutenticacao && !HelperControllers.VerificaUserLogado(HttpContext.Session))
                context.Result = RedirectToAction("Index", "Login");
            else
            {
                ViewBag.Logado = true;
                base.OnActionExecuting(context);
            }
        }

    }
}