using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using LumiTempMVC.Models;

namespace LumiTempMVC.DAO
{
    public class EmpresaParceiraDAO : PadraoDAO<EmpresaParceiraViewModel>
    {
        // Método para criar os parâmetros SQL a partir de um objeto EmpresaParceiraViewModel
        protected override SqlParameter[] CriaParametros(EmpresaParceiraViewModel empresa)
        {
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("ID", empresa.id);
            parametros[1] = new SqlParameter("NM_EMPR", empresa.nm_empr);
            parametros[2] = new SqlParameter("CEP_EMPR", empresa.cep_empr);
            parametros[3] = new SqlParameter("CNPJ_EMPR", empresa.cnpj_empr);
            parametros[4] = new SqlParameter("TELF_CONT_EMPR", empresa.telf_cont_empr);
            parametros[5] = new SqlParameter("ID_FUNC", empresa.id_func);

            return parametros;
        }

        // Método auxiliar para montar o modelo EmpresaParceiraViewModel a partir de uma linha da tabela
        protected override EmpresaParceiraViewModel MontaModel(DataRow registro)
        {
            EmpresaParceiraViewModel empresa = new EmpresaParceiraViewModel
            {
                id = Convert.ToInt32(registro["ID"]),
                nm_empr = registro["NM_EMPR"].ToString(),
                cep_empr = registro["CEP_EMPR"].ToString(),
                cnpj_empr = registro["CNPJ_EMPR"].ToString(),
                telf_cont_empr = registro["TELF_CONT_EMPR"].ToString(),
                id_func = Convert.ToInt32(registro["ID_FUNC"])
            };

            return empresa;
        }

        // Método para definir a tabela e stored procedure de listagem
        protected override void SetTabela()
        {
            Tabela = "cadr_empr_parc";
            NomeSpListagem = "spListagemEmpresa"; 
        }

    }

}




/*using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using LumiTempMVC.Models;

namespace LumiTempMVC.DAO
{
    public class EmpresaParceiraDAO 
    {
        // Método para criar os parâmetros SQL a partir de um objeto EmpresaParceiraViewModel
        private SqlParameter[] CriaParametros(EmpresaParceiraViewModel empresa)
        {
            // Cria um array de parâmetros SQL e associa os valores das propriedades do modelo EmpresaParceira
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("ID", empresa.id);               // Código da empresa
            parametros[1] = new SqlParameter("NM_EMPR", empresa.nm_empr);               // Nome da empresa
            parametros[2] = new SqlParameter("CEP_EMPR", empresa.cep_empr);             // CEP da empresa
            parametros[3] = new SqlParameter("CNPJ_EMPR", empresa.cnpj_empr);           // CNPJ da empresa
            parametros[4] = new SqlParameter("TELF_CONT_EMPR", empresa.telf_cont_empr); // Telefone de contato
            parametros[5] = new SqlParameter("ID_FUNC", empresa.id_func);         // Código do funcionário associado (chave estrangeira)
            return parametros;
        }

        // Método para inserir uma nova empresa parceira no banco de dados
        public void Inserir(EmpresaParceiraViewModel empresa)
        {
            // Define a query SQL para inserção
            string sql = "INSERT INTO cadr_empr_parc (ID, NM_EMPR, CEP_EMPR, CNPJ_EMPR, TELF_CONT_EMPR, ID_FUNC) " +
                         "VALUES (@ID, @NM_EMPR, @CEP_EMPR, @CNPJ_EMPR, @TELF_CONT_EMPR, @ID_FUNC)";
            // Executa a query chamando o método HelperDAO.ExecutaSQL
            HelperDAO.ExecutaSQL(sql, CriaParametros(empresa));
        }

        // Método para alterar os dados de uma empresa parceira existente
        public void Alterar(EmpresaParceiraViewModel empresa)
        {
            // Define a query SQL para atualização dos dados
            string sql =
                "UPDATE cadr_empr_parc SET " +
                "NM_EMPR=@NM_EMPR, " +
                "CEP_EMPR=@CEP_EMPR, " +
                "CNPJ_EMPR=@CNPJ_EMPR, " +
                "TELF_CONT_EMPR=@TELF_CONT_EMPR, " +  // Atualiza o telefone de contato
                "ID_FUNC=@ID_FUNC " +          // Atualiza o código do funcionário associado
                "WHERE ID = @ID";          // Condição para identificar a empresa a ser alterada
            HelperDAO.ExecutaSQL(sql, CriaParametros(empresa)); // Executa a query
        }

        // Método para excluir uma empresa parceira do banco de dados
        public void Excluir(int id)
        {
            // Define a query SQL para exclusão
            string sql = "DELETE cadr_empr_parc WHERE ID =" + id;
            HelperDAO.ExecutaSQL(sql, null); // Executa a query, passando o ID da empresa
        }

        // Método para consultar uma empresa parceira pelo código
        public EmpresaParceiraViewModel Consulta(int id)
        {
            // Define a query SQL para consulta de uma empresa pelo seu código
            string sql = "SELECT * FROM cadr_empr_parc WHERE ID =" + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null); // Executa a consulta
            if (tabela.Rows.Count == 0)
                return null; // Retorna null se não encontrar registros
            else
                return MontaModelEmpresa(tabela.Rows[0]); // Monta o objeto EmpresaParceiraViewModel com os dados retornados
        }

        // Método auxiliar para montar o modelo EmpresaParceiraViewModel a partir de uma linha da tabela
        public static EmpresaParceiraViewModel MontaModelEmpresa(DataRow registro)
        {
            EmpresaParceiraViewModel empresa = new EmpresaParceiraViewModel();

            // Preenche os dados do modelo com os valores obtidos no registro da tabela
            empresa.id = Convert.ToInt32(registro["ID"]);
            empresa.nm_empr = Convert.ToString(registro["NM_EMPR"]);
            empresa.cep_empr = Convert.ToString(registro["CEP_EMPR"]);
            empresa.cnpj_empr = Convert.ToString(registro["CNPJ_EMPR"]);
            empresa.telf_cont_empr = Convert.ToString(registro["TELF_CONT_EMPR"]);
            empresa.id_func = Convert.ToInt32(registro["ID_FUNC"]);

            return empresa; // Retorna o objeto preenchido
        }

        // Método para consultar todas as empresas parceiras cadastradas
        public List<EmpresaParceiraViewModel> ConsultaTodos()
        {
            List<EmpresaParceiraViewModel> empresas = new List<EmpresaParceiraViewModel>();

            using (SqlConnection cx = ConexaoDB.GetConexao()) // Abre conexão com o banco de dados
            {
                string sql = "SELECT * FROM cadr_empr_parc"; // Query SQL para selecionar todas as empresas
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, cx))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela); // Preenche um DataTable com os resultados da consulta

                    foreach (DataRow registro in tabela.Rows)
                    {
                        empresas.Add(MontaModelEmpresa(registro)); // Adiciona cada registro à lista de empresas
                    }
                }
            }

            return empresas; // Retorna a lista de empresas
        }

        // Método para listar todas as empresas parceiras, ordenadas pelo código
        public List<EmpresaParceiraViewModel> Listagem()
        {
            List<EmpresaParceiraViewModel> lista = new List<EmpresaParceiraViewModel>();
            string sql = "SELECT * FROM cadr_empr_parc ORDER BY ID"; // Query SQL para selecionar e ordenar as empresas
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null); // Executa a consulta

            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaModelEmpresa(registro)); // Monta a lista de empresas a partir dos registros
            return lista;
        }

        // Método para obter o próximo ID disponível para a empresa parceira
        public int ProximoId()
        {
            // Query SQL para obter o maior ID de empresa e adicionar 1, ou retornar 1 se não houver registros
            string sql = "SELECT ISNULL(MAX(ID) +1, 1) AS 'MAIOR' FROM cadr_empr_parc";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null); // Executa a consulta
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]); // Retorna o próximo ID
        }
}*/