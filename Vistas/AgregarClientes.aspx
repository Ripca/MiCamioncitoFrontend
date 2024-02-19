<%@ Page Title="" Language="C#" Async="true" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="AgregarClientes.aspx.cs" Inherits="MiCamioncitoFrontend.AgregarClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1 class="text-center">REGISTRO DE CLIENTES</h1>
    </section>
    <section class="content">
        <div class="row">
            <div >
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Nombre del Cliente</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtNombreCliente" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label>Correo</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label>Documento de Identificación Personal(DPI)</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtDpi" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>                     
                    </div>

                </div>
            </div>
          </div>

            <div align="center">
                <table>
                    <tr>
                        <td style="margin-left:30px";>
                            <asp:button ID="btnRegistrar" style="margin:20px; font-size:1.4em; width:30vw"   runat="server" text="Registrar" cssclass="btn btn-primary" OnClick="btnRegistrar_Click" />
                        </td>
                        <td>
                            <asp:Button ID="btnCancelar" Style="margin:20px; font-size:1.4em;width:30vw" runat="server" width="200px" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelar_Click" />
                        </td>
                    </tr>
                </table>
            </div>

    </section>

</asp:Content>
