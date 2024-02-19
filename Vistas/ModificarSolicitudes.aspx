<%@ Page Title="" Async="true" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="ModificarSolicitudes.aspx.cs" Inherits="MiCamioncitoFrontend.Vistas.ModificarSolicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1 class="text-center">ACTUALIZAR ESTADO DE SOLICITUDES</h1>
    </section>

    <section class="content">
        <div class="row">
            <div class="box box-primary">
               <div class="box-body">
                        <div class="form-group">
                            <label>ID de la solicitud:</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtIdModificar" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">            
                            
                            <asp:button ID="btnModificar"  runat="server" text="Modificar" cssclass="btn btn-primary" OnClick="btnModificar_Click" /> </div>
                </div>
            </div>
        </div>


        <div class="row">
            <div >
                <div class="box box-primary">
                    <div class="box-body">
                          <div class="form-group">
                            <label>Estado de la Servicio</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="DDLEstadoSolicitud" runat="server" CssClass="form-control">
                                <asp:ListItem Text="Iniciando" Value="Iniciando" />
                                <asp:ListItem Text="En proceso" Value="En proceso" />
                                <asp:ListItem Text="Finalizando" Value="Finalizando" />
                                </asp:DropDownList>
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
