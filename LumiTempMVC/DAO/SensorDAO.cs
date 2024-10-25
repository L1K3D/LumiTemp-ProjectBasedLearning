using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using LumiTempMVC.Models;

namespace LumiTempMVC.DAO
{
    public class SensorDAO
    {
        // Método para criar os parâmetros SQL a partir de um objeto SensorViewModel
        private SqlParameter[] CriaParametros(SensorViewModel sensor)
        {
            // Criação de um array de parâmetros SQL com o tamanho adequado
            SqlParameter[] parametros = new SqlParameter[7];
            // Atribuição de cada propriedade do modelo aos parâmetros correspondentes
            parametros[0] = new SqlParameter("ID", sensor.id);
            parametros[1] = new SqlParameter("DS_TIPO_SENS", sensor.ds_tipo_sens);
            parametros[2] = new SqlParameter("DT_VEND", sensor.dt_vend);
            parametros[3] = new SqlParameter("VL_TEMP_ALVO", sensor.vl_temp_alvo);
            parametros[4] = new SqlParameter("CD_MOTOR", sensor.cd_motor);
            parametros[5] = new SqlParameter("ID_FUNC", sensor.id_func);
            parametros[6] = new SqlParameter("ID_EMPR", sensor.id_empr);
            return parametros; // Retorna o array de parâmetros
        }

        // Método para inserir um novo sensor no banco de dados
        public void Inserir(SensorViewModel sensor)
        {
            // Comando SQL para inserção
            string sql = "INSERT INTO cadr_sens (ID, DS_TIPO_SENS, DT_VEND, VL_TEMP_ALVO, CD_MOTOR, ID_FUNC, ID_EMPR)" +
                         "VALUES (@ID, @DS_TIPO_SENS, @DT_VEND, @VL_TEMP_ALVO, @CD_MOTOR, @ID_FUNC, @ID_EMPR)";
            // Executa o comando SQL utilizando a função HelperDAO
            HelperDAO.ExecutaSQL(sql, CriaParametros(sensor));
        }

        // Método para atualizar os dados de um sensor existente
        public void Alterar(SensorViewModel sensor)
        {
            // Comando SQL para atualização
            string sql =
                "UPDATE cadr_sens SET " +
                "DS_TIPO_SENS=@DS_TIPO_SENS, " +
                "DT_VEND=@DT_VEND, " +
                "VL_TEMP_ALVO=@VL_TEMP_ALVO, " +
                "CD_MOTOR=@CD_MOTOR, " +
                "ID_FUNC=@ID_FUNC, " +
                "ID_EMPR=@ID_EMPR " +
                "WHERE ID = @ID";
            // Executa o comando SQL utilizando a função HelperDAO
            HelperDAO.ExecutaSQL(sql, CriaParametros(sensor));
        }

        // Método para excluir um sensor pelo seu código
        public void Excluir(int id)
        {
            // Comando SQL para exclusão
            string sql = "DELETE cadr_sens WHERE ID =" + id;
            // Executa o comando SQL
            HelperDAO.ExecutaSQL(sql, null);
        }

        // Método para consultar um sensor pelo seu código
        public SensorViewModel Consulta(int id)
        {
            // Comando SQL para consulta
            string sql = "SELECT * FROM cadr_sens WHERE ID =" + id;
            // Executa a consulta e armazena o resultado em uma DataTable
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            // Verifica se a consulta retornou resultados
            if (tabela.Rows.Count == 0)
                return null; // Retorna null se nenhum resultado for encontrado
            else
                return MontaModelSensor(tabela.Rows[0]); // Monta e retorna o modelo a partir do primeiro registro
        }

        // Método estático para construir um SensorViewModel a partir de um DataRow
        public static SensorViewModel MontaModelSensor(DataRow registro)
        {
            // Criação de um novo objeto SensorViewModel
            SensorViewModel sensor = new SensorViewModel();
            // Atribuição de cada coluna do DataRow às propriedades do modelo
            sensor.id = Convert.ToInt32(registro["ID"]);
            sensor.ds_tipo_sens = Convert.ToString(registro["DS_TIPO_SENS"]);
            sensor.dt_vend = Convert.ToDateTime(registro["DT_VEND"]);
            sensor.vl_temp_alvo = Convert.ToDecimal(registro["VL_TEMP_ALVO"]);
            sensor.cd_motor = Convert.ToInt32(registro["CD_MOTOR"]);
            sensor.id_func = Convert.ToInt32(registro["ID_FUNC"]);
            sensor.id_empr = Convert.ToInt32(registro["ID_EMPR"]);

            return sensor; // Retorna o objeto SensorViewModel preenchido
        }

        // Método para consultar todos os sensores
        public List<SensorViewModel> ConsultaTodos()
        {
            List<SensorViewModel> sensores = new List<SensorViewModel>();

            // Estabelece uma conexão com o banco de dados
            using (SqlConnection cx = ConexaoDB.GetConexao())
            {
                // Comando SQL para selecionar todos os sensores
                string sql = "SELECT * FROM cadr_sens";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, cx))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela); // Preenche a DataTable com os resultados

                    // Percorre cada registro e monta a lista de sensores
                    foreach (DataRow registro in tabela.Rows)
                    {
                        sensores.Add(MontaModelSensor(registro));
                    }
                }
            }

            return sensores; // Retorna a lista de sensores
        }

        // Método para listar todos os sensores ordenados por código
        public List<SensorViewModel> Listagem()
        {
            List<SensorViewModel> lista = new List<SensorViewModel>();
            // Comando SQL para selecionar todos os sensores ordenados
            string sql = "SELECT * FROM cadr_sens ORDER BY ID";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            // Percorre cada registro e monta a lista de sensores
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaModelSensor(registro));
            return lista; // Retorna a lista de sensores
        }

        // Método para obter o próximo ID disponível para um novo sensor
        public int ProximoId()
        {
            // Comando SQL para encontrar o maior ID atual e adicionar 1
            string sql = "SELECT ISNULL(MAX(ID) +1, 1) AS 'MAIOR' FROM cadr_sens";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]); // Retorna o próximo ID
        }
    }
}