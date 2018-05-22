using ERYTEC.GEXP.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSP_Estacio_Entidade;

namespace TSP_Estacio_Modelo
{
    public class DisciplinaModelo
    {
        //Estancia de um objeto da classe de conexao
        Model gModel = new Model();
        //variavel usada para armazenar as Queries Sql
        string gSql = string.Empty;

        public int Inserir(Disciplina_entidade pDisciplinaEntidade)
        {
            gSql = "Insert into tb_disciplina (nome, carga_h, dsp_desc, data_reg) values (@DSP_nome, @DSP_carga_oraria, @DSP_descricao, @DSP_data_registro)";

            gModel.AddParameter("@DSP_nome", pDisciplinaEntidade.DSP_nome);
            gModel.AddParameter("@DSP_carga_oraria", pDisciplinaEntidade.DSP_carga_oraria);
            gModel.AddParameter("@DSP_descricao", pDisciplinaEntidade.DSP_descricao);
            gModel.AddParameter("@DSP_data_registro", pDisciplinaEntidade.DSP_data_registro);

            return gModel.ExecutaComando(gSql); 
        }

       public DataTable Consultar()
        {
            string Sql = "Select id, nome, carga_h, dsp_desc from tb_disciplina";
            //retorna um DataTable dt 
            return gModel.ExecuteDataTable(Sql); 
        }

        public int Excluir(Disciplina_entidade pDisciplinaEntidade)
        {
            string query = "Delete from tb_disciplina where id = @DSP_Codigo";

            gModel.AddParameter("@DSP_Codigo", pDisciplinaEntidade.DSP_codigo);
    
            return gModel.ExecutaComando(query);
        }

        public DataTable ConsultarLinha(Disciplina_entidade pDisciplinaEntidade)
        {
            string gSql = "Select * from tb_disciplina where id = @DSP_Codigo";

            gModel.AddParameter("@DSP_Codigo", pDisciplinaEntidade.DSP_codigo);

            return gModel.ExecuteDataTable(gSql);

        }

        public int Atualizar(Disciplina_entidade pDisciplinaEntidade)
        {
            gSql = "UPDATE tb_disciplina SET nome = @DSP_nome, carga_h = @DSP_carga_oraria, dsp_desc = @DSP_descricao, data_reg = @DSP_data_registro WHERE id = @DSP_codigo" ;

            gModel.AddParameter("@DSP_codigo", pDisciplinaEntidade.DSP_codigo);
            gModel.AddParameter("@DSP_nome", pDisciplinaEntidade.DSP_nome);
            gModel.AddParameter("@DSP_carga_oraria", pDisciplinaEntidade.DSP_carga_oraria);
            gModel.AddParameter("@DSP_descricao", pDisciplinaEntidade.DSP_descricao);
            gModel.AddParameter("@DSP_data_registro", pDisciplinaEntidade.DSP_data_registro);

            return gModel.ExecutaComando(gSql);
        }

    }//classe

}//namespace
