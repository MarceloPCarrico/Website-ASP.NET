<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inserir.aspx.cs" Inherits="EX6.Inserir" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main class="container text-center mt-5 ">
        <div class="card">
            <div class="card-header bg-secondary text-white">
                <h2>Inserir Aluno</h2>
            </div>
            <div class="card-body">
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group row">
                            <asp:Label ID="lbl_nome" runat="server" CssClass="col-sm-3 col-form-label" Text="Nome:"></asp:Label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txt_nome" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group row">
                            <asp:Label ID="lbl_email" runat="server" CssClass="col-sm-3 col-form-label" Text="Email:"></asp:Label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txt_email" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group row">
                            <asp:Label ID="lbl_data_nasc" runat="server" CssClass="col-sm-3 col-form-label" Text="Data Nasc.:"></asp:Label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txt_data_nasc" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group row">
                            <asp:Label ID="lbl_morada" runat="server" CssClass="col-sm-3 col-form-label" Text="Morada:"></asp:Label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="txt_morada" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group row">
                            <asp:Label ID="lbl_genero" runat="server" CssClass="col-sm-3 col-form-label" Text="Género:"></asp:Label>
                            <div class="col-sm-9">
                                <asp:DropDownList ID="dd_genero" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group row">
                            <asp:Label ID="lbl_turma" runat="server" CssClass="col-sm-3 col-form-label" Text="Turma:"></asp:Label>
                            <div class="col-sm-9">
                                <asp:DropDownList ID="dd_turma" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <img src="https://thumbs.web.sapo.io/?epic=V2:4d4RUE2g6oh9xEoA25KlVKS/NhZG8gqwrBSlM9FcgWOgnNP+mCZ9LhcMt2rj2NDUTzH3uO91zpjag4ySk3rc0jgOQTgQgf9xtFZvg5PF9lho9CU6UnFMtKdtV5qAvBOx&proxy=1" alt="Imagem" class="img-fluid"/>
                    </div>
                </div>
                <br />
                <div class="d-flex justify-content-center flex-column">
                    <div class="col-sm-6 text-center mb-3">
                        <asp:Button ID="btn_inserir" runat="server" Text="Inserir" CssClass="btn btn-primary btn-lg" BackColor="Gray" OnClick="btn_inserir_Click"></asp:Button>
                    </div>
                    <div class="col-sm-6 text-center">
                        <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" CssClass="btn btn-secondary btn-lg" BackColor="Gray" OnClick="btn_cancelar_Click"></asp:Button>
                    </div>
                </div>
            </div>
        </div>
    </main>
</asp:Content>

