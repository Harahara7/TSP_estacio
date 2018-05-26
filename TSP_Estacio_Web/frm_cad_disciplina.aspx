<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_cad_disciplina.aspx.cs" Inherits="TSP_Estacio_Web.frm_cad_diciplina" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        
            <h2>Disciplina</h2>

        <div id="div_grid" runat="server">

        <asp:GridView class="table" ID="gvDisciplina" DataKeyNames="id" runat="server" OnRowCommand="gvDisciplina_RowCommand"  >
            <Columns>
                <asp:ButtonField ControlStyle-Width="20px" HeaderStyle-Width="20px" ButtonType="Image" ImageUrl="../imagens/edit.png"  CommandName="Editar"/>
                <asp:ButtonField ControlStyle-Width="20px" HeaderStyle-Width="20px" ButtonType="Image" ImageUrl="../imagens/delete.jpg" CommandName="Excluir"/>
            </Columns>
          <%--  <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />--%>
        </asp:GridView>

        </div>

            <hr />

        <div class="form-group">
            <div  >
                <fieldset visible ="false" ID="id_fieldset" runat="server">
                    <div>
                        <div class="rotulo">Nome:</div>
                        <asp:TextBox ID="tb_nome" runat="server"></asp:TextBox>
                    </div>
                    <br />
                    <div>
                        <div class="rotulo">Carga horária:</div>
                        <asp:TextBox ID="tb_carga_horaria" runat="server"></asp:TextBox>
                    </div>
                    <br />
                    <div>
                        <div class="">Descrição:</div>
                        <%--<asp:Textarea ID="tb_descricao" runat="server"></asp:Textarea>--%>
                        <asp:TextBox ID="tb_descricao" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                    </div>
                    <br />
                    <div visible="true" ID="div_Salvar" runat="server">
                    <asp:Button ID="Button1" runat="server" Text="Salvar" OnClick="Button1_Click" />
                    </div>
                </fieldset>
                <div visible="true" ID="div_Novo" runat="server">
                <asp:Button ID="Button2" runat="server" Text="Novo" OnClick="Button2_Click" />
                </div>
                <div visible="false" ID="div_Atualizar" runat="server">
                <asp:Button ID="btn_atualizar" runat="server" Text="Atualizar" OnClick="btn_atualizar_Click"  />
                </div>
            </div>
        </div>
    </div>
        
</asp:Content>
