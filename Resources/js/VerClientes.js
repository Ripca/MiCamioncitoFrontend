$(document).ready(function () {
    // Función para cargar los datos de los clientes desde la API
    function cargarClientes() {
        $.ajax({
            url: 'https://localhost:44367/api/cliente', // URL de tu API
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                // Limpiar la tabla antes de agregar los nuevos datos
                $('#tbl_body_table').empty();
                // Iterar sobre los datos y agregarlos a la tabla
                $.each(data, function (index, cliente) {
                    $('#tbl_body_table').append(
                        '<tr>' +
                        '<td>' + cliente.IdCliente + '</td>' +
                        '<td>' + cliente.NombreCliente + '</td>' +
                        '<td>' + cliente.Correo + '</td>' +
                        '<td>' + cliente.DPI + '</td>' +
                        '</tr>'
                    );
                });
            },
            error: function () {
                swal('Error :(', 'No se puedo conectar con la base', 'error');
            }
        });
    }

    // Llamar a la función para cargar los clientes al cargar la página
    cargarClientes();
});