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
            SqlParameter[] parametros = new SqlParameter[8];
            // Atribuição de cada propriedade do modelo aos parâmetros correspondentes
            parametros[0] = new SqlParameter("CD_SENS", sensor.cd_sens);
            parametros[1] = new SqlParameter("DS_TIPO_SENS", sensor.ds_tipo_sens);
            parametros[2] = new SqlParameter("DT_VEND", sensor.dt_vend);
            parametros[3] = new SqlParameter("VL_TEMP_ALVO", sensor.vl_temp_alvo);
            parametros[4] = new SqlParameter("VL_UMID_ALVO", sensor.vl_umid_alvo);
            parametros[5] = new SqlParameter("CD_MOTOR", sensor.cd_motor);
            parametros[6] = new SqlParameter("FK_CD_FUNC", sensor.fk_cd_func);
            parametros[7] = new SqlParameter("FK_CD_EMPR", sensor.fk_cd_empr);

            return parametros; // Retorna o array de parâmetros
        }

        // Método para inserir um novo sensor no banco de dados
        public void Inserir(SensorViewModel sensor)
        {
            // Comando SQL para inserção
            string sql = "INSERT INTO cadr_sens (CD_SENS, DS_TIPO_SENS, DT_VEND, VL_TEMP_ALVO, VL_UMID_ALVO, CD_MOTOR, FK_CD_FUNC, FK_CD_EMPR) " +
                         "VALUES (@CD_SENS, @DS_TIPO_SENS, @DT_VEND, @VL_TEMP_ALVO, @VL_UMID_ALVO, @CD_MOTOR, @FK_CD_FUNC, @FK_CD_EMPR)";
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
                "VL_UMID_ALVO=@VL_UMID_ALVO, " +
                "CD_MOTOR=@CD_MOTOR, " +
                "FK_CD_FUNC=@FK_CD_FUNC, " +
                "FK_CD_EMPR=@FK_CD_EMPR " +
                "WHERE CD_SENS=@CD_SENS";
            // Executa o comando SQL utilizando a função HelperDAO
            HelperDAO.ExecutaSQL(sql, CriaParametros(sensor));
        }

        // Método para excluir um sensor pelo seu código
        public void Excluir(int cd_sens)
        {
            // Comando SQL para exclusão
            string sql = "DELETE cadr_sens WHERE CD_SENS = " + cd_sens;
            // Executa o comando SQL
            HelperDAO.ExecutaSQL(sql, null);
        }

        // Método para consultar um sensor pelo seu código
        public SensorViewModel Consulta(int cd_sens)
        {
            // Comando SQL para consulta
            string sql = "SELECT * FROM cadr_sens WHERE id = " + cd_sens;
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
            sensor.cd_sens = Convert.ToInt32(registro["CD_SENS"]);
            sensor.ds_tipo_sens = Convert.ToString(registro["DS_TIPO_SENS"]);
            sensor.dt_vend = Convert.ToDateTime(registro["DT_VEND"]);
            sensor.vl_temp_alvo = Convert.ToInt32(registro["VL_TEMP_ALVO"]);
            sensor.vl_umid_alvo = Convert.ToInt32(registro["VL_UMID_ALVO"]);
            sensor.cd_motor = Convert.ToInt32(registro["CD_MOTOR"]);
            sensor.fk_cd_func = Convert.ToInt32(registro["FK_CD_FUNC"]);
            sensor.fk_cd_empr = Convert.ToInt32(registro["FK_CD_EMPR"]);

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
            string sql = "SELECT * FROM cadr_sens ORDER BY cd_sens";
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
            string sql = "SELECT ISNULL(MAX(cd_sens) +1, 1) AS 'MAIOR' FROM cadr_sens";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]); // Retorna o próximo ID
        }
    }
}