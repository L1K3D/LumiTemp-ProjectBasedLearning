using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using LumiTempMVC.Models;

namespace LumiTempMVC.DAO
{
    public class SensorDAO : PadraoDAO<SensorViewModel>
    {
        // Método para criar os parâmetros SQL a partir de um objeto SensorViewModel
        protected override SqlParameter[] CriaParametros(SensorViewModel model)
        {
            // Criação de um array de parâmetros SQL com o tamanho adequado
            SqlParameter[] parametros = new SqlParameter[7];
            // Atribuição de cada propriedade do modelo aos parâmetros correspondentes
            parametros[0] = new SqlParameter("ID", model.id);
            parametros[1] = new SqlParameter("DS_TIPO_SENS", model.ds_tipo_sens);
            parametros[2] = new SqlParameter("DT_VEND", model.dt_vend);
            parametros[3] = new SqlParameter("VL_TEMP_ALVO", model.vl_temp_alvo);
            parametros[4] = new SqlParameter("CD_MOTOR", model.cd_motor);
            parametros[5] = new SqlParameter("ID_FUNC", model.id_func);
            parametros[6] = new SqlParameter("ID_EMPR", model.id_empr);
            return parametros; // Retorna o array de parâmetros
        }

        protected override  SensorViewModel MontaModel(DataRow registro)
        {
            // Criação de um novo objeto SensorViewModel
            SensorViewModel sensor = new SensorViewModel();
            // Atribuição de cada coluna do DataRow às propriedades do modelo
            sensor.id = Convert.ToInt32(registro["ID"]);
            sensor.ds_tipo_sens = Convert.ToString(registro["DS_TIPO_SENS"]);
            sensor.dt_vend = Convert.ToDateTime(registro["DT_VEND"]);
            sensor.vl_temp_alvo = Convert.ToDouble(registro["VL_TEMP_ALVO"]);
            sensor.cd_motor = Convert.ToInt32(registro["CD_MOTOR"]);
            sensor.id_func = Convert.ToInt32(registro["ID_FUNC"]);
            sensor.id_empr = Convert.ToInt32(registro["ID_EMPR"]);

            return sensor; // Retorna o objeto SensorViewModel preenchido
        }

        protected override void SetTabela()
        {
            Tabela = "cadr_sens";
        }

    }
}