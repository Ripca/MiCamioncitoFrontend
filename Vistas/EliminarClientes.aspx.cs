using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiCamioncitoFrontend.Vistas
{
    public partial class EliminarClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected async void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del cliente a eliminar desde el TextBox
            int idCliente = Convert.ToInt32(txtIdEliminar.Text);

            // URL del endpoint de la API para eliminar clientes
            string apiUrl = "https://localhost:44367/api/cliente/" + idCliente;

            // Crear una instancia de HttpClient
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Realizar la petición DELETE
                    HttpResponseMessage response = await httpClient.DeleteAsync(apiUrl);

                    // Verificar si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        string script = "swal('Cliente Eliminado', 'Presiona OK', 'success');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "ClienteEliminadoExitosamenteScript", script, true);

                        string redirectScript = "setTimeout(function(){ window.location.href = 'PaginaInicio.aspx'; }, 3000);";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "RedirectScript", redirectScript, true);
                    }
                    else
                    {
                        string script = "swal('Error :(', 'No se puedo eliminar el cliente', 'error');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "NoClienteEliminadoScript", script, true);

                        string redirectScript = "setTimeout(function(){ window.location.href = 'PaginaInicio.aspx'; }, 3000);";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "RedirectScript", redirectScript, true);
                    }
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
    }
}