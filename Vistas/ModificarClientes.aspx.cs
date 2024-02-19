using MiCamioncitoFrontend.Modelos;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web.UI;
//Microsoft.AspNet.WebApi.Client INSTALASTE ESE PAQUETE


namespace MiCamioncitoFrontend
{
    public partial class EliminarClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnModificar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del cliente a modificar desde el TextBox
            int idCliente = Convert.ToInt32(txtIdModificar.Text);

            // URL del endpoint de la API para obtener los datos del cliente
            string apiUrl = "https://localhost:44367/api/cliente/" + idCliente;

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
                        var cliente = await response.Content.ReadAsAsync<Cliente>();

                        // Mostrar los datos del cliente en los TextBoxes
                        txtNombreCliente.Text = cliente.NombreCliente;
                        txtCorreo.Text = cliente.Correo;
                        txtDpi.Text = cliente.DPI;
                    }
                    else
                    {
                        // Mostrar un mensaje de error
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorObtenerClienteScript", "alert('Error al obtener los datos del cliente');", true);
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
            

            // Obtener los datos modificados del cliente desde los TextBoxes
            int idCliente = Convert.ToInt32(txtIdModificar.Text);
            string nombreCliente = txtNombreCliente.Text;
            string correo = txtCorreo.Text;
            string dpi = txtDpi.Text;

            // URL del endpoint de la API para modificar el cliente
            string apiUrl = "https://localhost:44367/api/cliente";

            // Crear una instancia de HttpClient
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Crear un objeto Cliente con los datos modificados
                    Cliente clienteModificado = new Cliente
                    {
                        IdCliente = idCliente,
                        NombreCliente = nombreCliente,
                        Correo = correo,
                        DPI = dpi
                    };

                    // Realizar la petición PUT para modificar el cliente
                    HttpResponseMessage response = await httpClient.PutAsJsonAsync(
                        apiUrl, clienteModificado);

                    // Verificar si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        string script = "swal('Cliente modificado', 'Presiona OK', 'success');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "ClienteModificadoExitosamenteScript", script, true);
                    }

                    else
                    {
                        string script = "swal('Modificacion Denegada :(', 'No se puedo modificar el cliente', 'error');";
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