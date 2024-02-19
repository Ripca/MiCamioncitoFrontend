<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="VerClientes.aspx.cs" Inherits="MiCamioncitoFrontend.VerClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-xs-12">
            <div class="box box-primary">
                <div class="box-header">
                    <h3 class="box-title">Lista de Clientes</h3>
                </div>
                <div class="box-body table-responsive">
                    <table id="tbl_pacientes" class="table table-bordered table-hover text-center">
                        <thead>
                            <tr>
                                <th>IDCLIENTE</th>
                                <th>NOMBRE</th>
                                <th>CORREO</th>
                                <th>DPI</th>
                            </tr>
                        </thead>
                        <tbody id="tbl_body_table">
                          
                         </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>


    <script src="../Resources/js/VerClientes.js">
    </script>


</asp:Content>
