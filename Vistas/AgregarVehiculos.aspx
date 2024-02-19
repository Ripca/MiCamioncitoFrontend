<%@ Page Title="" Async="true" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="AgregarVehiculos.aspx.cs" Inherits="MiCamioncitoFrontend.AgregarVehiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1 class="text-center">REGISTRO DE VEHICULOS</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Tipo de Vehiculo</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="DDLTipoVehiculo" runat="server" CssClass="form-control">
                                <asp:ListItem Text="Camioncito" Value="Camioncito" />
                                <asp:ListItem Text="Camion" Value="Camion" />
                                 <asp:ListItem Text="Trailer" Value="Trailer" />
                                </asp:DropDownList>
                            </div>

                        <div class="form-group">
                            <label>Capacidad de Carga</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="DDLCapacidadCarga" runat="server" CssClass="form-control">
                                <asp:ListItem Text="30 metros Cubitos" Value="30m3" />
                                <asp:ListItem Text="60 metros Cubitos" Value="60m3" />
                                 <asp:ListItem Text="100 metros Cubitos" Value="100m3" />
                                </asp:DropDownList>
                            </div>
                        
                        
                        <div class="form-group">
                            <label>Combustible por KM Recorrido</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="DDLCombustiblePorKM" runat="server" CssClass="form-control">
                                <asp:ListItem Text="Q3.00" Value="Q3.00" />
                                <asp:ListItem Text="Q5.00" Value="Q5.00" />
                                 <asp:ListItem Text="Q7.00" Value="Q7.00" />
                                </asp:DropDownList>
                            </div>                        

                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                         <div class="form-group">
                            <label>Disponibilidad</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="DDLDisponibilidad" runat="server" CssClass="form-control">
                                <asp:ListItem Text="Si" Value="1" />
                                <asp:ListItem Text="No" Value="0" />
                                </asp:DropDownList>
                            </div>                      

                         <div class="form-group">
                            <label>Depreciación por KM Recorrido</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="DDLDepreciacion" runat="server" CssClass="form-control">
                                <asp:ListItem Text="Q1.00" Value="Q1.00" />
                                </asp:DropDownList>
                            </div>                      


                         <div class="form-group">
                            <label>Tipo de Carga</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="DDLTipoDeCarga" runat="server" CssClass="form-control">
                                <asp:ListItem Text="Refrigerado" Value="Refrigerado" />
                                <asp:ListItem Text="Mudanzas" Value="Mudanzas" />
                                 <asp:ListItem Text="Mercaderia" Value="Mercaderia" />
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
                            <asp:button ID="btnRegistrar" style="margin:20px; font-size:1.4em; width:30vw"   runat="server" text="Registrar" cssclass="btn btn-primary" OnClick="btnRegistrar_Click"/>
                        </td>
                        <td>
                            <asp:Button ID="btnCancelar" Style="margin:20px; font-size:1.4em;width:30vw" runat="server" width="200px" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelar_Click"/>
                        </td>
                    </tr>
                </table>
            </div>


    </section>


</asp:Content>
