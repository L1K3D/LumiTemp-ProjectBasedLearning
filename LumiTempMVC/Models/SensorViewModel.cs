using System;
using System.Collections.Generic; // Importa o namespace necessário para trabalhar com tipos básicos, como DateTime e Nullable

namespace LumiTempMVC.Models // Declaração do namespace para organizar o código dos modelos
{
    // Classe SensorViewModel que representa os dados de um sensor
    public class SensorViewModel : PadraoViewModel
    {
        // Propriedade para armazenar o código do sensor (ID)
        //public int id { get; set; }

        // Propriedade para armazenar a descrição do tipo de sensor
        public string ds_tipo_sens { get; set; }
        
        // Propriedade para armazenar a data de venda do sensor
        // É nullable para permitir que não haja um valor definido
        public DateTime dt_vend { get; set; }

        // Propriedade para armazenar o valor da temperatura alvo configurada
        // É nullable para permitir que não haja um valor definido
        public double vl_temp_alvo { get; set; }

        // Propriedade para armazenar o código do motor associado ao sensor
        public int cd_motor { get; set; }

        // Propriedade para armazenar o número do usuário (ID) que está associado ao sensor
        public int id_func { get; set; }

        // Propriedade para armazenar o código da empresa associada ao sensor
        public int id_empr { get; set; }
    }
}