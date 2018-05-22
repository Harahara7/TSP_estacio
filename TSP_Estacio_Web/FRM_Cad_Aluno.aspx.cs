using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TSP_Estacio_Web
{
    public partial class FRM_Cad_Aluno : System.Web.UI.Page
    {
        #region Objetos
        string gValor = string.Empty;

        #endregion

        #region Metodos
        /// <summary>
        /// Método para limpar campos.
        /// </summary>
        public void LimparCampos()
        {
            tbNome.Text = string.Empty;
            tbSobrenome.Text = string.Empty;
            tbIdade.Text = string.Empty;
        }

        /// <summary>
        /// Método responsavel por trnasformar em maiusculo.
        /// </summary>
        /// <param name="pValor"></param>
        /// <returns></returns>
        public string ColocarMaiusculo(string pValor)
        {
            return pValor.ToUpper();
        }

        public string ColocarMaiusculo(string pNome, string pSobrenome)
        {
            return (pNome + " " + pSobrenome).ToUpper();
        }

        
        #endregion

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btSalvar_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(tbIdade.Text) < 18)
            {
                lblMensagem.Text = "Proibido para menores de idade!";
            } else
            {
                lblMensagem.Text = ColocarMaiusculo(tbNome.Text, tbSobrenome.Text) + " - Idade: " + tbIdade.Text ;
            }
            
        }

        protected void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        #endregion
    }
}