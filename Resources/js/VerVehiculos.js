$(document).ready(function () {
    // Función para cargar los datos de los vehículos desde la API
    function cargarVehiculos() {
        $.ajax({
            url: 'https://localhost:44367/api/vehiculo', // URL de tu API
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                // Limpiar la tabla antes de agregar los nuevos datos
                $('#tbl_body_table').empty();
                // Iterar sobre los datos y agregarlos a la tabla
                $.each(data, function (index, vehiculo) {
                    $('#tbl_body_table').append(
                        '<tr>' +    
                        '<td>' + vehiculo.IdVehiculo + '</td>' +
                        '<td>' + vehiculo.TipoVehiculo + '</td>' +
                        '<td>' + vehiculo.CapacidadCarga + '</td>' +
                        '<td>' + vehiculo.CombustiblePorKm + '</td>' +
                        '<td>' + vehiculo.Disponibilidad + '</td>' +
                        '<td>' + vehiculo.DepreciacionPorKm + '</td>' +
                        '<td>' + vehiculo.TipoCarga + '</td>' +
                        '</tr>'
                    );
                });
            },
            error: function () {
                swal('Error :(', 'No se puedo conectar con la base', 'error');
            }
        });
    }

    // Llamar a la función para cargar los vehículos al cargar la página
    cargarVehiculos();
});