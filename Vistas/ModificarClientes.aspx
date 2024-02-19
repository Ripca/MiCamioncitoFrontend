<%@ Page Title="" Async="true" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="ModificarClientes.aspx.cs" Inherits="MiCamioncitoFrontend.EliminarClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <section class="content-header">
        <h1 class="text-center">MODIFICAR CLIENTES</h1>
    </section>

    <section class="content">
        <div class="row">
            <div class="box box-primary">
               <div class="box-body">
                        <div class="form-group">
                            <label>ID del cliente a modificar</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtIdModificar" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">            
                            <asp:button ID="btnModificar"  runat="server" text="Modificar" cssclass="btn btn-primary" OnClick="btnModificar_Click"/> </div>
                </div>
            </div>
        </div>


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
                            <asp:button ID="btnGuardar" Style="margin:20px; font-size:1.4em; width:30vw"   runat="server" text="Guardar" cssclass="btn btn-primary" OnClick="btnGuardar_Click"/>
                        </td>
                  
                    </tr>
                </table>
            </div>

    </section>
</asp:Content>
