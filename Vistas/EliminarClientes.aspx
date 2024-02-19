<%@ Page Title="" Async="true" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="EliminarClientes.aspx.cs" Inherits="MiCamioncitoFrontend.Vistas.EliminarClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1 class="text-center">ELIMINAR CLIENTES</h1>
    </section>

    <section class="content">
        <div class="row">
            <div class="box box-primary">
               <div class="box-body">
                        <div class="form-group">
                            <label>ID del cliente a eliminar</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtIdEliminar" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">            
                            <asp:button ID="btnEliminar"  runat="server" text="Eliminar" cssclass="btn btn-primary" OnClick="btnEliminar_Click"/> </div>
                </div>
            </div>
        </div>
        </section>
</asp:Content>
