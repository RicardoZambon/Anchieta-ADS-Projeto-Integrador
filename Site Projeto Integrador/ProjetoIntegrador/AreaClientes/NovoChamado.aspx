<%@ Page Title="" Language="C#" MasterPageFile="~/AreaClientes/MasterPage.Master" AutoEventWireup="true" CodeBehind="NovoChamado.aspx.cs" Inherits="ProjetoIntegrador.AreaClientes.NovoChamado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h3>Novo Chamado</h3>

    <asp:ScriptManager ID="ScriptManager1" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Table ID="tblNovoChamado" runat="server">
                <asp:TableRow>
                    <asp:TableCell CssClass="titulo">Prioridade:</asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="cmbPrioridades" runat="server" Width="880" />
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell CssClass="titulo">Assunto:</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtAssunto" runat="server" Width="880" /></asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell CssClass="titulo">Descrição:</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine" Height="305" Width="880" /></asp:TableCell>
                </asp:TableRow>

                <asp:TableFooterRow>
                    <asp:TableCell ColumnSpan="2" CssClass="botao">
                        <asp:Button ID="btnGravar" runat="server" OnClick="btnGravar_Click" OnClientClick="MostraLoader(this,'imgLoader');" Text="Abrir chamado" />
                        <img src="/imagens/loader.gif" id="imgLoader" alt="Carregando..." style="display:none;" />
                    </asp:TableCell>
                </asp:TableFooterRow>
            </asp:Table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
