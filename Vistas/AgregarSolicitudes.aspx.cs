using MiCamioncitoFrontend.Modelos;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web.UI;

namespace MiCamioncitoFrontend
{
    public partial class AgregarSolicitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected async Task AccionRegistrar_Click(object sender, EventArgs e)
        {
            Solicitud nuevaSolicitud = new Solicitud
            {
                IdCliente = Convert.ToInt32(txtIdCliente.Text),
                IdConductor = Convert.ToInt32(txtIdConductor.Text),
                IdAyudante = Convert.ToInt32(txtIdAyudante.Text),
                IdVehiculo = Convert.ToInt32(txtIdVehiculo.Text),
                DireccionOrigen = txtDireccionOrigen.Text,
                DireccionDestino = txtDireccionDestino.Text,
                EstadoSolicitud = DDLEstadoSolicitud.SelectedValue,
                PrecioTotal = Convert.ToDouble(txtPrecioTotal.Text)
            };

            // Crear una solicitud HTTP y enviar la nueva solicitud a la API
            using (HttpClient clienteHttp = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await clienteHttp.PostAsJsonAsync(
                        "https://localhost:44367/api/solicitud", nuevaSolicitud);

                    // Verificar si la solicitud fue exitosa
                    response.EnsureSuccessStatusCode();

                    // Mostrar mensaje de éxito
                    string script = "swal('Solicitud registrada', 'Presiona OK', 'success');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "SolicitudRegistradaExitosamenteScript", script, true);

                    // Redirigir después de 3 segundos
                    string redirectScript = "setTimeout(function(){ window.location.href = 'PaginaInicio.aspx'; }, 3000);";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "RedirectScript", redirectScript, true);
                }
                catch (HttpRequestException)
                {
                    // Mostrar mensaje de error
                    string script = "swal('Registro Denegado :(', 'No se pudo registrar la solicitud', 'error');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "SolicitudNoRegistradaScript", script, true);

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
            txtIdCliente.Text = "";
            txtIdConductor.Text = "";
            txtIdAyudante.Text = "";
            txtIdVehiculo.Text = "";
            txtDireccionOrigen.Text = "";
            txtDireccionDestino.Text = "";
            DDLEstadoSolicitud.SelectedIndex = 0;
            txtPrecioTotal.Text = "";
        }

    }
}