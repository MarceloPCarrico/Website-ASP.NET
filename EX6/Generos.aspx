<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Generos.aspx.cs" Inherits="EX6.Generos
    " %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main style="max-width: 1200px; margin: 0 auto; background-color: #333; color: #fff; padding: 20px;">
        <h2 class="text-center"> Gestão de Géneros</h2>
        <br /><br />
        <% Obter_dados(); %>
        <br /><br />
        <h3> Adicionar Géneros </h3>
         <asp:Label ID="lbl_genero" runat="server" Text="Género: "></asp:Label>
         &nbsp;<asp:TextBox ID="txt_genero" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btn_inserir" runat="server" Text="Inserir" CssClass="btn btn-primary btn-lg" BackColor="Gray" OnClick="btn_inserir_Click"></asp:Button>
    </main>
</asp:Content>

