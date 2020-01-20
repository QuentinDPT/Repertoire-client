
function sendEntreprise(entreprise, fct) {
    document.getElementById("load_hider").style.display = "block";
    $.ajax({
        url: "/api/Entreprise",
        type: "POST",
        contentType: 'application/json',
        data: JSON.stringify(entreprise),
        success: function (req) {
            fct();
        }
    });
}

function deleteEntreprise(ID, fct) {
    document.getElementById("load_hider").style.display = "block";
    $.ajax({
        url: "/api/Entreprise/" + ID,
        type: "DELETE",
        success: function (req) {
            fct();
        }
    });
}
