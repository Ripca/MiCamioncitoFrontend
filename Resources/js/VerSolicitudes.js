$(document).ready(function () {
    // Función para cargar los datos de las solicitudes desde la API
    function cargarSolicitudes() {
        $.ajax({
            url: 'https://localhost:44367/api/solicitud', // URL de tu API
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                // Limpiar la tabla antes de agregar los nuevos datos
                $('#tbl_body_table').empty();
                // Iterar sobre los datos y agregarlos a la tabla
                $.each(data, function (index, solicitud) {
                    $('#tbl_body_table').append(
                        '<tr>' +
                        '<td>' + solicitud.IdSolicitud + '</td>' +
                        '<td>' + solicitud.FechaSolicitud + '</td>' +
                        '<td>' + solicitud.IdCliente + '</td>' +
                        '<td>' + solicitud.IdVehiculo + '</td>' +
                        '<td>' + solicitud.IdConductor + '</td>' +
                        '<td>' + solicitud.IdAyudante + '</td>' +
                        '<td>' + solicitud.EstadoSolicitud + '</td>' +
                        '<td>' + solicitud.PrecioTotal + '</td>' +
                        '</tr>'
                    );
                });
            },
            error: function () {
                swal('Error :(', 'No se puedo conectar con la base', 'error');
            }
        });
    }

    // Llamar a la función para cargar las solicitudes al cargar la página
    cargarSolicitudes();
});