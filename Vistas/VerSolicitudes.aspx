<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="VerSolicitudes.aspx.cs" Inherits="MiCamioncitoFrontend.VerSolicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="row">
        <div class="col-xs-12">
            <div class="box box-primary">
                <div class="box-header">
                    <h3 class="box-title">Solicitudes</h3>
                </div>
                <div class="box-body table-responsive">
                    <table id="tbl_pacientes" class="table table-bordered table-hover text-center">
                        <thead>
                            <tr>
                                <th>NO.</th>
                                <th>FECHASOLICITUD</th>
                                <th>IDCLIENTE</th>
                                <th>IDVEHICULO</th>
                                <th>IDCONDUCTOR</th>
                                <th>IDAYUDANTE</th>
                                <th>ESTADOSOLICITUD</th>
                                <th>PRECIOTOTAL</th>
                            </tr>
                        </thead>
                        <tbody id="tbl_body_table">
                            <%--probar borrar esos tr--%>

                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>

    <script src="../Resources/js/VerSolicitudes.js">
   
    </script>


</asp:Content>
