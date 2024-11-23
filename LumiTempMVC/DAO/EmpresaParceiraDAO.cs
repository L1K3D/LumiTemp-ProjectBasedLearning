using System.Data.SqlClient; // Biblioteca para manipulação de SQL Server.
using System.Data; // Biblioteca para trabalhar com tabelas e registros.
using System; // Biblioteca para funcionalidades básicas.
using LumiTempMVC.Models; // Namespace que contém os modelos utilizados.

namespace LumiTempMVC.DAO
{
    // Classe DAO específica para a tabela de empresas parceiras.
    // Herda a funcionalidade genérica da classe base PadraoDAO.
    public class EmpresaParceiraDAO : PadraoDAO<EmpresaParceiraViewModel>
    {
        // Método responsável por criar os parâmetros SQL para as stored procedures
        // Recebe um objeto do tipo EmpresaParceiraViewModel como entrada.
        protected override SqlParameter[] CriaParametros(EmpresaParceiraViewModel model)
        {
            // Cria um array de parâmetros SQL de tamanho 12, correspondente aos campos da tabela.
            SqlParameter[] parametros = new SqlParameter[12];

            // Preenche o array de parâmetros com os dados do modelo.
            parametros[0] = new SqlParameter("ID", model.id);                      // Identificador único da empresa.
            parametros[1] = new SqlParameter("NM_EMPR", model.nm_empr);           // Nome da empresa parceira.
            parametros[2] = new SqlParameter("CEP_EMPR", model.cep_empr);         // CEP da empresa parceira.
            parametros[3] = new SqlParameter("LOG_EMPR", model.log_empr);         // Logradouro da empresa parceira.      
            parametros[4] = new SqlParameter("NUM_EMPR", model.num_empr);         //Número da empresa parceira.
            if (model.compl_empr == null)
                parametros[5] = new SqlParameter("COMPL_EMPR", DBNull.Value);
            else
                parametros[5] = new SqlParameter("COMPL_EMPR", model.compl_empr);  //Complemento da empresa parceira.
            parametros[6] = new SqlParameter("BAIRRO_EMPR", model.bairro_empr);   //Bairro da empresa parceira.
            parametros[7] = new SqlParameter("CIDADE_EMPR", model.cidade_empr);   //Cidade da emresa parceira.
            parametros[8] = new SqlParameter("ESTADO_EMPR", model.estado_empr);   //Estado da empresa parceira.
            parametros[9] = new SqlParameter("CNPJ_EMPR", model.cnpj_empr);       // CNPJ da empresa parceira.
            parametros[10] = new SqlParameter("TELF_CONT_EMPR", model.telf_cont_empr); // Telefone de contato da empresa.
            parametros[11] = new SqlParameter("ID_FUNC", model.id_func);           // Identificador do funcionário associado (chave estrangeira).

            return parametros; // Retorna o array de parâmetros preenchido.
        }

        // Método responsável por montar um objeto EmpresaParceiraViewModel a partir de uma linha da tabela.
        protected override EmpresaParceiraViewModel MontaModel(DataRow registro)
        {
            // Cria uma nova instância do modelo EmpresaParceiraViewModel.
            EmpresaParceiraViewModel empresa = new EmpresaParceiraViewModel();

            // Preenche as propriedades do modelo com os valores extraídos do DataRow.
            empresa.id = Convert.ToInt32(registro["ID"]);                          // Identificador único da empresa.
            empresa.nm_empr = Convert.ToString(registro["NM_EMPR"]);              // Nome da empresa parceira.
            empresa.cep_empr = Convert.ToString(registro["CEP_EMPR"]);            // CEP da empresa parceira.
            empresa.log_empr = Convert.ToString(registro["LOG_EMPR"]);            // Logradouro da empresa parceira.
            empresa.num_empr = Convert.ToString(registro["NUM_EMPR"]);            // Número da empresa parceira.
            empresa.compl_empr = Convert.ToString(registro["COMPL_EMPR"]);        // Complemento da empresa parceira.
            empresa.bairro_empr = Convert.ToString(registro["BAIRRO_EMPR"]);      // Bairro da empresa parceira.
            empresa.cidade_empr = Convert.ToString(registro["CIDADE_EMPR"]);      // Cidade da empresa parceira.
            empresa.estado_empr = Convert.ToString(registro["ESTADO_EMPR"]);      // Estado da empresa parceira.
            empresa.cnpj_empr = Convert.ToString(registro["CNPJ_EMPR"]);          // CNPJ da empresa parceira.
            empresa.telf_cont_empr = Convert.ToString(registro["TELF_CONT_EMPR"]); // Telefone de contato da empresa.
            empresa.id_func = Convert.ToInt32(registro["ID_FUNC"]);               // Identificador do funcionário associado.

            return empresa; // Retorna o modelo preenchido.
        }

        // Método que define o nome da tabela a ser utilizada pelo DAO.
        // Este método é obrigatório, pois a classe base exige a definição da tabela.
        protected override void SetTabela()
        {
            Tabela = "cadr_empr_parc"; // Nome da tabela no banco de dados para empresas parceiras.
        }
    }
}