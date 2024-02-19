<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="VerVehiculos.aspx.cs" Inherits="MiCamioncitoFrontend.VerVehiculos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-xs-12">
            <div class="box box-primary">
                <div class="box-header">
                    <h3 class="box-title">Lista de Vehiculos</h3>
                </div>
                <div class="box-body table-responsive">
                    <table id="tbl_pacientes" class="table table-bordered table-hover text-center">
                        <thead>
                            <tr>
                                <th>IDVEHICULO</th>
                                <th>TIPOVEHICULO</th>
                                <th>CAPACIDAD</th>
                                <th>COMBUSTIBLE</th>
                                <th>DISPONIBILIDAD</th>             
                                <th>DEPRECIACION</th>
                                <th>TIPODECARGA</th>
                            </tr>
                        </thead>
                        <tbody id="tbl_body_table">
                            <tr>

                            </tr>
                            <tr>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>



    <script src="../Resources/js/VerVehiculos.js">
   
    </script>





</asp:Content>
