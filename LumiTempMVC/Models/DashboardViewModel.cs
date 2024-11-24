using System.Collections.Generic;

namespace LumiTempMVC.Models
{
    public class DashboardViewModel
    {
        public List<SensorViewModel> Sensores { get; set; }
        public List<FuncionarioViewModel> Funcionarios { get; set; }
        public List<EmpresaParceiraViewModel> Empresas { get; set; }
    }
}