document.addEventListener("DOMContentLoaded", function () {
    // Adicionar um evento de confirmação antes de excluir qualquer registro
    let deleteButtons = document.querySelectorAll(".btn-danger");

    deleteButtons.forEach(function (button) {
        button.addEventListener("click", function (event) {
            let confirmDelete = confirm("Tem certeza que deseja excluir este registro?");
            if (!confirmDelete) {
                event.preventDefault();
            }
        });
    });
});
