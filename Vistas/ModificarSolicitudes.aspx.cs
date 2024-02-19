using MiCamioncitoFrontend.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiCamioncitoFrontend.Vistas
{
    public partial class ModificarSolicitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnModificar_Click(object sender, EventArgs e)
        {
            // Obtener el ID de la solicitud a modificar desde el TextBox
            int idSolicitud = Convert.ToInt32(txtIdModificar.Text);

            // URL del endpoint de la API para obtener los datos del cliente
            string apiUrl = "https://localhost:44367/api/solicitud/" + idSolicitud;

            // Crear una instancia de HttpClient
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Realizar la petición GET para obtener los datos del cliente
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    // Verificar si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer los datos del cliente desde la respuesta
                        var solicitud = await response.Content.ReadAsAsync<Solicitud>();

                        // Mostrar el estado de la solicitud en el droplist
                        DDLEstadoSolicitud.Text = solicitud.EstadoSolicitud;
                        
                    }
                    else
                    {
                        // Mostrar un mensaje de error
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorObtenerSolicitudScript", "alert('Error al obtener los datos del cliente');", true);
                    }
                }
                catch (HttpRequestException)
                {
                    // Mostrar un mensaje de error en caso de que falle la conexión
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorConexionScript", "alert('Error de conexión');", true);
                }
            }
        }

        protected async Task AccionModificar_Click(object sender, EventArgs e)
        {


            // Obtener el estado de la solicitud desde el droplist
            int idSolicitud = Convert.ToInt32(txtIdModificar.Text);
            string estadoSolicitud = DDLEstadoSolicitud.SelectedValue;
            
            // URL del endpoint de la API para modificar el estado de la solicitud
            string apiUrl = "https://localhost:44367/api/cliente";

            // Crea una instancia de HttpClient
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Crea un objeto Solicitud con los datos modificados
                    Solicitud solicitudModificada = new Solicitud
                    {
                        IdSolicitud = idSolicitud,
                        EstadoSolicitud = estadoSolicitud
                    };

                    // Realizar la petición PUT para modificar el cliente
                    HttpResponseMessage response = await httpClient.PutAsJsonAsync(
                        "https://localhost:44367/api/solicitud", solicitudModificada);

                    // Verificar si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        string script = "swal('Estado Actualizado', 'Presiona OK', 'success');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "ActualizacionEstadoScript", script, true);
                    }

                    else
                    {
                        string script = "swal('Modificacion Denegada :(', 'No se pudo actualizar el estado', 'error');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "PeticionFallidaScript", script, true);
                    }
                    string redirectScript = "setTimeout(function(){ window.location.href = 'PaginaInicio.aspx'; }, 3000);";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "RedirectScript", redirectScript, true);
                }
                catch (HttpRequestException)
                {
                    string script = "swal('Error :(', 'No se puedo conectar con la base', 'error');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "NoConexionScript", script, true);

                    string redirectScript = "setTimeout(function(){ window.location.href = 'PaginaInicio.aspx'; }, 2000);";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "RedirectScript", redirectScript, true);
                }
            }
        }

        protected async void btnGuardar_Click(object sender, EventArgs e)
        {
            await AccionModificar_Click(sender, e);
        }


    }
}