<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="EX6.Eliminar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main class="container mt-5" style="max-width: 1200px; margin: 0 auto; background-color: #333; color: #fff; padding: 20px;">
        <h2 class="text-center">Eliminar Aluno</h2>
        <br />
        <div class="form-group row">
            <asp:Label ID="lbl_numero" runat="server" CssClass="col-sm-2 col-form-label" Text="Número:"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txt_numero" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="form-group row">
            <asp:Label ID="lbl_nome" runat="server" CssClass="col-sm-2 col-form-label" Text="Nome:"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txt_nome" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="form-group row">
            <asp:Label ID="lbl_email" runat="server" CssClass="col-sm-2 col-form-label" Text="Email:"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txt_email" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="form-group row">
            <asp:Label ID="lbl_data_nasc" runat="server" CssClass="col-sm-2 col-form-label" Text="Data Nascimento:"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txt_data_nasc" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="form-group row">
            <asp:Label ID="lbl_morada" runat="server" CssClass="col-sm-2 col-form-label" Text="Morada:"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txt_morada" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="form-group row">
            <asp:Label ID="lbl_genero" runat="server" CssClass="col-sm-2 col-form-label" Text="Género:"></asp:Label>
            <div class="col-sm-10">
                <asp:DropDownList ID="dd_genero" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
        </div>

        <div class="form-group row">
            <asp:Label ID="lbl_turma" runat="server" CssClass="col-sm-2 col-form-label" Text="Turma:"></asp:Label>
            <div class="col-sm-10">
                <asp:DropDownList ID="dd_turma" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
        </div>

        <div class="d-flex justify-content-center flex-column">
            <div class="col-sm-6 text-center mb-3">
                <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" CssClass="btn btn-secondary btn-lg" BackColor="Gray" OnClick="btn_eliminar_Click"></asp:Button>
            </div>
            <div class="col-sm-6 text-center"> 
                <asp:Button ID="btn_voltar" runat="server" Text="Voltar" CssClass="btn btn-secondary btn-lg" BackColor="Gray" OnClick="btn_voltar_Click"></asp:Button>
            </div>
        </div>
    </main>
</asp:Content>
