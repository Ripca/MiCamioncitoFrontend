using MiCamioncitoFrontend.Modelos;
using System;
//quitar las que no se utilicen
using System.Net.Http; //este
using System.Net.Http.Json; //este
using System.Threading.Tasks; //este
using System.Web.UI;
//FIJATE EN TODO LO QUE TUVISTE QUE IMPORTAR Y ALGUNOS PAQUETES


namespace MiCamioncitoFrontend
{
    public partial class AgregarClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected async Task AccionRegistrar_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente
            {
                NombreCliente = txtNombreCliente.Text,
                Correo = txtCorreo.Text,
                DPI = txtDpi.Text
            };

            // Crear una solicitud HTTP y enviar el nuevo cliente a la API
            using (HttpClient clienteHttp = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await clienteHttp.PostAsJsonAsync(
                        "https://localhost:44367/api/cliente", nuevoCliente);

                    // Verificar si la solicitud fue exitosa
                    response.EnsureSuccessStatusCode();

                    if (nuevoCliente.NombreCliente != "" && nuevoCliente.Correo != "" && nuevoCliente.DPI != "")
                    {   
                        string script = "swal('Cliente registrado', 'Presiona OK', 'success');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "ClienteRegistradoExitosamenteScript", script, true);
                    }


                    string redirectScript = "setTimeout(function(){ window.location.href = 'PaginaInicio.aspx'; }, 3000);";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "RedirectScript", redirectScript, true);

                }
                catch (HttpRequestException)
                {
                    
                    string script = "swal('Registro Denegado :(', 'No se puedo registrar el cliente', 'error');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "PeticionScript", script, true);

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
            txtNombreCliente.Text = "";
            txtCorreo.Text = "";
            txtDpi.Text = "";
        }
    }
}
