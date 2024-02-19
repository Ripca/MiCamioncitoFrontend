<%@ Page Title="" Language="C#" Async="true" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="AgregarSolicitudes.aspx.cs" Inherits="MiCamioncitoFrontend.AgregarSolicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1 class="text-center">REGISTRO DE SOLICITUDES</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        
                        <div class="form-group">
                        <label>Nombre del Cliente</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtIdCliente" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>


                        <div class="form-group">
                            <label>ID del Conductor</label>
                        </div>
                           <div class="form-group">
                            <asp:TextBox ID="txtIdConductor" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>


                        <div class="form-group">
                            <label>ID del Ayudante</label>
                        </div>
                         <div class="form-group">
                            <asp:TextBox ID="txtIdAyudante" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>


                        <div class="form-group">
                            <label>ID del Vehiculo</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtIdVehiculo" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">

                        <div class="form-group">
                            <label>Dirección Origen</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtDireccionOrigen" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>


                        <div class="form-group">
                            <label>Dirección Destino</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtDireccionDestino" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>


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

                        
                        <div class="form-group">
                            <label>Precio Total</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtPrecioTotal" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                         
                        
                    </div>
                </div>
            </div>
        </div>

            <div align="center">
                <table>
                    <tr>
                        <td style="margin-left:30px";>
                            <asp:button ID="btnRegistrar" Style="margin:20px; font-size:1.4em; width:30vw"   runat="server" text="Registrar" cssclass="btn btn-primary" OnClick="btnRegistrar_Click"/>
                        </td>
                        <td>
                            <asp:Button ID="btnCancelar" Style="margin:20px; font-size:1.4em;width:30vw" runat="server" width="200px" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelar_Click"/>
                        </td>
                    </tr>
                </table>
            </div>


    </section>

</asp:Content>
