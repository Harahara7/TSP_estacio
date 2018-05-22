using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSP_Estacio_Entidade;
using TSP_Estacio_Modelo;


namespace TSP_Estacio_controle
{
    public class Disciplina_controle
    {
            DisciplinaModelo gDisciplinaModelo = new DisciplinaModelo();

        public int Inserir(Disciplina_entidade pDiciplina)
        {
           return gDisciplinaModelo.Inserir(pDiciplina);
        }

        public DataTable Consultar()
        {
            return gDisciplinaModelo.Consultar();
        }

        public int Excluir(Disciplina_entidade pDiciplina)
        {
            return gDisciplinaModelo.Excluir(pDiciplina);
        }

        public DataTable ConsultarLinha(Disciplina_entidade pDiciplina)
        {
            return gDisciplinaModelo.ConsultarLinha(pDiciplina);
        }

        public int Atualizar(Disciplina_entidade pDisciplina)
        {
            return gDisciplinaModelo.Atualizar(pDisciplina);
        }

    }
}
