function showDeleteConfirmation() {
    setTimeout(function () {
        swal({
            title: "¿Estás seguro?",
            text: "Una vez eliminado, este registro no se puede recuperar.",
            icon: "warning",
            buttons: {
                cancel: "Cancelar",
                confirm: {
                    text: "OK",
                    value: true,
                },
            },
            dangerMode: true,
        })
            .then((willDelete) => {
                if (willDelete) {
                    // El usuario hizo clic en el botón "Eliminar"
                    // Puedes agregar aquí tu lógica de eliminación
                    // Por ejemplo, enviar el formulario para eliminar el registro
                    document.querySelector("form").submit();
                } else {
                    // El usuario hizo clic en el botón "Cancelar"
                    swal("El registro no fue eliminado.", {
                        icon: "info",
                    });
                }
            });
    }
        , 10000); // 2000 milisegundos = 2 segundos
}