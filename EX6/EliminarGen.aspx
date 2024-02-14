<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarGen.aspx.cs" Inherits="EX6.EliminarGen
    " %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main style="max-width: 1200px; margin: 0 auto; background-color: #333; color: #fff; padding: 20px;">
        <h2 class="text-center"> Eliminar Géneros</h2>
        <br /><br />
        <asp:Label ID="lbl_numero" runat="server" Text="ID: "></asp:Label>
         &nbsp;<asp:TextBox ID="txt_id" runat="server"></asp:TextBox>
         <br /><br />
         <asp:Label ID="lbl_genero" runat="server" Text="Género: "></asp:Label>
         &nbsp;<asp:TextBox ID="txt_genero" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" CssClass="btn btn-primary btn-lg" BackColor="Gray" OnClick="btn_eliminar_Click"></asp:Button>
    </main>
</asp:Content>

