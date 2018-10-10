$(document).ready(function () {
    $(".lettersOnly").keypress(function (event) {
        var inputValue = event.which;            
        if (!(inputValue >= 65 && inputValue <= 122) && (inputValue !== 32 && inputValue !== 0 && inputValue !== 241)) {
            event.preventDefault();
        }
    });
     //paginación
    $('#ctl00_MainContent_TablePersons').paging({ limit: 10 });
});

// evitar doble click en los botones
function DisableButtons() {
    var inputs = document.getElementsByTagName("INPUT");
    for (var i in inputs) {
        if (inputs[i].type === "button" || inputs[i].type === "submit") {
            inputs[i].disabled = true;
        }
    }
}
window.onbeforeunload = DisableButtons;

function calculateEdad(txt) {
    var year = parseInt(txt.value);
    var d = new Date();
    $("#ctl00_MainContent_EdadTxt").val(d.getFullYear() - year);
}

//abrir modal
function openDeleteModal() {   
    $('#btnShowModal').trigger("click");
}




