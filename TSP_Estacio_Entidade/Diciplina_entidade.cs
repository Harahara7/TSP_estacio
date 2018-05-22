using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP_Estacio_Entidade
{
    public class Disciplina_entidade
    {
        public int DSP_codigo { get; set; }
        public string DSP_nome { get; set; }
        public int DSP_carga_oraria { get; set; }
        public DateTime DSP_data_registro { get; set; }

        //atributo adicionado
        public string DSP_descricao { get; set; }
    }
}
