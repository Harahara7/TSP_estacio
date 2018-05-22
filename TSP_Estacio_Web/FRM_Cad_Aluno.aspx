<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRM_Cad_Aluno.aspx.cs" Inherits="TSP_Estacio_Web.FRM_Cad_Aluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="estilo.css" rel="stylesheet" />
    <title>Formulário de Cadastro</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <legend>Aluno</legend>
                <div>
                    <div class="rotulo">Nome:</div>
                    <asp:TextBox ID="tbNome" runat="server" placeholder="nome"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Insira um nome!" ControlToValidate="tbNome"></asp:RequiredFieldValidator>
                </div>
                <br />
                <div>
                    <div class="rotulo">Sobrenome:</div>
                    <asp:TextBox ID="tbSobrenome" runat="server" placeholder="sobrenome"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Insira um sobrenome!" ControlToValidate="tbSobrenome"></asp:RequiredFieldValidator>
                </div>
                <br />
                <div>
                    <div class="rotulo">Idade:</div>
                    <asp:TextBox ID="tbIdade" runat="server" placeholder="Idade" TextMode="Number"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Insira sua idade!" ControlToValidate="tbIdade"></asp:RequiredFieldValidator>
                </div>

                <br />
                <br />
                <asp:Button ID="btSalvar" runat="server" Text="Salvar" OnClick="btSalvar_Click" />
                <asp:Button ID="btLimpar" runat="server" Text="Limpar" OnClick="btLimpar_Click" />
            </fieldset>
        </div>
        <p>
            <asp:Label ID="lblMensagem" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
