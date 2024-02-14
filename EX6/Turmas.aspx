<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Turmas.aspx.cs" Inherits="EX6.Turmas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main style="max-width: 1200px; margin: 0 auto; background-color: #333; color: #fff; padding: 20px;">
        <h2 class="text-center"> Gestão de Turmas</h2>
        <br /><br />
        <% Obter_dados(); %>
        <br /><br />
        <h3> Adicionar Turmas </h3>
         <asp:Label ID="lbl_turma" runat="server" Text="Turma: "></asp:Label>
         &nbsp;<asp:TextBox ID="txt_turma" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btn_inserir" runat="server" CssClass="btn btn-primary btn-lg" BackColor="Gray" Text="Inserir" OnClick="btn_inserir_Click"></asp:Button>
    </main>
</asp:Content>

