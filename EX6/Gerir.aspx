<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Gerir.aspx.cs" Inherits="EX6.Gerir" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main style="max-width: 1200px; margin: 0 auto; background-color: #333; color: #fff; padding: 20px;">
        <h2 class="text-center">Gerir Alunos</h2>
        <% Obter_dados(); %>
        <br />
        <div class="text-center mx-auto"> 
            <asp:Button ID="btn_voltar" runat="server" Text="Voltar" CssClass="btn btn-secondary btn-lg" BackColor="Gray" OnClick="btn_voltar_Click"></asp:Button>
        </div>

    </main>
</asp:Content>


