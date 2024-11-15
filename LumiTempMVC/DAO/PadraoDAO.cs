using LumiTempMVC.Models; // Importa o namespace contendo os modelos (ViewModels).
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LumiTempMVC.DAO
{
    // Classe abstrata genérica para Data Access Object (DAO). 
    // T é o tipo de modelo que será manipulado, e deve herdar de PadraoViewModel.
    public abstract class PadraoDAO<T> where T : PadraoViewModel
    {
        // Construtor da classe. Configura a tabela ao inicializar o DAO.
        public PadraoDAO()
        {
            SetTabela(); // Método abstrato que define a tabela específica.
        }

        // Propriedade protegida para o nome da tabela que será usada no banco de dados.
        protected string Tabela { get; set; }

        // Nome da stored procedure para listagem, com valor padrão "spListagem".
        protected string NomeSpListagem { get; set; } = "spListagem";

        // Método abstrato para criar os parâmetros necessários para as operações no banco.
        protected abstract SqlParameter[] CriaParametros(T model);

        // Método abstrato para montar o modelo a partir de um registro do banco.
        protected abstract T MontaModel(DataRow registro);

        // Método abstrato para definir o nome da tabela. Deve ser implementado nas classes concretas.
        protected abstract void SetTabela();

        // Método para inserir um novo registro no banco de dados.
        public virtual void Insert(T model)
        {
            // Executa a stored procedure específica de inserção para a tabela definida.
            HelperDAO.ExecutaProc("spInsert_" + Tabela, CriaParametros(model));
        }

        // Método para atualizar um registro existente no banco de dados.
        public virtual void Update(T model)
        {
            // Executa a stored procedure específica de atualização para a tabela definida.
            HelperDAO.ExecutaProc("spUpdate_" + Tabela, CriaParametros(model));
        }

        // Método para excluir um registro do banco de dados pelo ID.
        public virtual void Delete(int id)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("id", id), // Define o parâmetro de ID.
                new SqlParameter("tabela", Tabela) // Define o nome da tabela.
            };
            // Executa a stored procedure genérica de exclusão.
            HelperDAO.ExecutaProc("spDelete", p);
        }

        // Método para consultar um registro específico pelo ID.
        public virtual T Consulta(int id)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("id", id), // Define o parâmetro de ID.
                new SqlParameter("tabela", Tabela) // Define o nome da tabela.
            };
            // Executa a stored procedure de consulta e retorna os dados em forma de DataTable.
            var tabela = HelperDAO.ExecutaProcSelect("spConsulta", p);

            // Se não houver registros, retorna null; caso contrário, monta o modelo a partir do registro.
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaModel(tabela.Rows[0]);
        }

        // Método para obter o próximo ID disponível na tabela.
        public virtual int ProximoId()
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("tabela", Tabela) // Define o nome da tabela.
            };
            // Executa a stored procedure para obter o próximo ID.
            var tabela = HelperDAO.ExecutaProcSelect("spProximoId", p);

            // Converte o resultado para inteiro e retorna.
            return Convert.ToInt32(tabela.Rows[0][0]);
        }

        // Método para listar todos os registros da tabela.
        public virtual List<T> Listagem()
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("tabela", Tabela), // Define o nome da tabela.
                new SqlParameter("Ordem", "1") // Define a ordem padrão para a listagem.
            };
            // Executa a stored procedure para listagem e retorna os dados em forma de DataTable.
            var tabela = HelperDAO.ExecutaProcSelect(NomeSpListagem, p);

            // Cria uma lista para armazenar os modelos.
            List<T> lista = new List<T>();

            // Itera por cada registro e monta o modelo correspondente, adicionando-o à lista.
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaModel(registro));

            // Retorna a lista de modelos.
            return lista;
        }
    }
}