using MiCamioncitoFrontend.Modelos;
using System;
using System.Net.Http; 
using System.Net.Http.Json; 
using System.Threading.Tasks; 
using System.Web.UI;

namespace MiCamioncitoFrontend
{
    public partial class AgregarVehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async Task AccionRegistrar_Click(object sender, EventArgs e)
        {
            Vehiculo nuevoVehiculo = new Vehiculo
            {
                TipoVehiculo = DDLTipoVehiculo.SelectedValue,
                CapacidadCarga = DDLCapacidadCarga.SelectedValue,
                CombustiblePorKm = DDLCombustiblePorKM.SelectedValue,
                Disponibilidad = DDLDisponibilidad.SelectedValue,
                DepreciacionPorKm = DDLDepreciacion.SelectedValue,
                TipoCarga = DDLTipoDeCarga.SelectedValue
            };

            // Crear una solicitud HTTP y enviar el nuevo vehículo a la API
            using (HttpClient clienteHttp = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await clienteHttp.PostAsJsonAsync(
                        "https://localhost:44367/api/vehiculo", nuevoVehiculo);

                    // Verificar si la solicitud fue exitosa
                    response.EnsureSuccessStatusCode();

                    // Mostrar mensaje de éxito
                    string script = "swal('Vehículo registrado', 'Presiona OK', 'success');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "VehiculoRegistradoExitosamenteScript", script, true);

                    // Redirigir después de 3 segundos
                    string redirectScript = "setTimeout(function(){ window.location.href = 'PaginaInicio.aspx'; }, 3000);";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "RedirectScript", redirectScript, true);
                }
                catch (HttpRequestException)
                {
                    // Mostrar mensaje de error
                    string script = "swal('Registro Denegado :(', 'No se pudo registrar el vehículo', 'error');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "VehiculoNoRegistradoScript", script, true);

                    // Redirigir después de 3 segundos
                    string redirectScript = "setTimeout(function(){ window.location.href = 'PaginaInicio.aspx'; }, 3000);";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "RedirectScript", redirectScript, true);
                }
            }
        }

        protected async void btnRegistrar_Click(object sender, EventArgs e)
        {
            await AccionRegistrar_Click(sender, e);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar los valores de los campos de entrada de texto
            DDLTipoVehiculo.SelectedIndex = 0;
            DDLCapacidadCarga.SelectedIndex = 0;
            DDLCombustiblePorKM.SelectedIndex = 0;
            DDLDisponibilidad.SelectedIndex = 0;
            DDLDepreciacion.SelectedIndex = 0;  
            DDLTipoDeCarga.SelectedIndex = 0;
        }


    }
}