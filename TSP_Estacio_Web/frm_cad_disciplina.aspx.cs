using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TSP_Estacio_controle;
using TSP_Estacio_Entidade;

namespace TSP_Estacio_Web
{
    public partial class frm_cad_diciplina : System.Web.UI.Page
    {
        #region Objetos
        Disciplina_entidade gdisciplina_entidade = new Disciplina_entidade();
        Disciplina_controle gDisciplinaControle = new Disciplina_controle();
      
        #endregion

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            //garante que executa apenas uma vez!
            if (!IsPostBack)
            {
                CarregarDisciplinas();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Botão Salvar
            GravarCamposEntidade();
            
            gDisciplinaControle.Inserir(gdisciplina_entidade);
            CarregarDisciplinas();
            id_fieldset.Visible = false;
            LimparCampos();
        }

        //Evento para desocultar o fieldset
        protected void Button2_Click(object sender, EventArgs e)
        {
            id_fieldset.Visible = true;
        }

        protected void gvDisciplina_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //valor do datakeycommand, ele pega o id!
            int lIndex = Convert.ToInt16(e.CommandArgument);

            switch (e.CommandName)
            {
                case "Editar":
                    int lId = Convert.ToInt16(gvDisciplina.DataKeys[lIndex]["id"]);

                    //Antes de tudo, o indice da linha a ser editada. E gravada na entidade!
                    gdisciplina_entidade.DSP_codigo = lId;

                    //ViewState garante que o lid não seja perdido!
                    ViewState["codigo"] = lId;

                    DataTable tabelaDados = new DataTable();
                    //objeto tabelaDados para receber uma tabela de dados do bd
                    tabelaDados = gDisciplinaControle.ConsultarLinha(gdisciplina_entidade);
                    //se existir linhas na tabela, faça
                    if (tabelaDados.Rows.Count > 0)
                    {
                        id_fieldset.Visible = true;
                        tb_nome.Text = tabelaDados.Rows[0]["nome"].ToString();
                        tb_carga_horaria.Text = tabelaDados.Rows[0]["carga_h"].ToString();
                        tb_descricao.Text = tabelaDados.Rows[0]["dsp_desc"].ToString();
                        CarregarDisciplinas();
                        OcultarBotoesEditar();
                        
                    }

                    break;

                case "Excluir":
                    int lId2 = Convert.ToInt16(gvDisciplina.DataKeys[lIndex]["id"]);
                    gdisciplina_entidade.DSP_codigo = lId2;
                    gDisciplinaControle.Excluir(gdisciplina_entidade);

                    CarregarDisciplinas();
                    break;


                default:
                    break;


            }//switch

        }//rowCommand

        protected void btn_atualizar_Click(object sender, EventArgs e)
        {
            GravarCamposEntidade();

            int id = Convert.ToInt32(ViewState["codigo"]);

            gdisciplina_entidade.DSP_codigo = id;
            gDisciplinaControle.Atualizar(gdisciplina_entidade);
            CarregarDisciplinas();
            LimparCampos();
            MostrarBotoesEditar();
            
        }

        #endregion

        #region Metodos
        //realiza a consulta da tabela tb_disciplinas
        public void CarregarDisciplinas()
        {
            gvDisciplina.DataSource = gDisciplinaControle.Consultar();
            gvDisciplina.DataBind();
        }

        //oculta os botoes de Salvar e Novo durante a Edicao
        public void OcultarBotoesEditar()
        {
            //Executado ao editar uma linha da tabela 
            div_Salvar.Visible = false;
            div_Novo.Visible = false;
            div_Atualizar.Visible = true;
        }

        //apos terminar de editar, mostre os botoes anteriores
        public void MostrarBotoesEditar()
        {
            div_Salvar.Visible = true;
            div_Novo.Visible = true;
            div_Atualizar.Visible = false;
            id_fieldset.Visible = false;
        }

        //Literalmente...
        public void LimparCampos()
        {
            tb_nome.Text = "";
            tb_carga_horaria.Text = "";
            tb_descricao.Text = "";
        }

        //Metodo que encaminha os dados do formulario para camada de entidade
        public void GravarCamposEntidade()
        {
            gdisciplina_entidade.DSP_nome = tb_nome.Text;
            gdisciplina_entidade.DSP_carga_oraria = Int32.Parse(tb_carga_horaria.Text);
            gdisciplina_entidade.DSP_data_registro = DateTime.Now;
            gdisciplina_entidade.DSP_descricao = tb_descricao.Text;
        }

        //Em teste. Deseja-se limpar as variaveis de forma correta.
        public void LimparEntidadeDisciplinas()
        {
            gdisciplina_entidade.DSP_codigo = 0;
            gdisciplina_entidade.DSP_nome = "";
            gdisciplina_entidade.DSP_descricao = "";
            gdisciplina_entidade.DSP_carga_oraria = 0;

        }

        #endregion

        
    }//classe

}//namespace