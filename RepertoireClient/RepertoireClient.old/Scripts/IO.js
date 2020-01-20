function test() {
    let entr = new Entreprise();

    entr.Nom = "Gefco";
    entr.Code_Ordre = "Guillaume de POTTER";
    entr.Code_Postal = "67 000";
    entr.Commentaire = "Il bosse pas beaucoup";
    entr.Fax = "fax.gefco.fr:512";
    entr.Rue = "Port du Rhin";
    entr.Ville = "Strasbourg";
    entr.Site = "gefco-france.fr";
    entr.Telephone = "+33 6 xx xx xx xx";

    let emp = new Employee();

    emp.Entreprise_ID = 1;
    emp.Mail = "robert.deniero@gmail.com";
    emp.Nom = "robert";

    entr.Contacts.push(emp);

    entr.toHTML();

}

function htmlToModel() {
    let rezz = new Entreprise();

    rezz.Nom = document.getElementById("entreprise_name").value;
    rezz.Telephone = document.getElementById("telephone").value;
    rezz.Fax = document.getElementById("fax").value;
    rezz.Code_Ordre = document.getElementById("cde_ordre").value;
    rezz.Site = document.getElementById("web_site").value;
    rezz.Ville = document.getElementById("ville").value;
    rezz.Code_Postal = document.getElementById("code_postal").value;
    rezz.Rue = document.getElementById("rue").value;
    rezz.Commentaire = document.getElementById("commentaire").value;

    return rezz;
}

function exportEntreprise(entr) {
    $.ajax({
        url: "/api/Entreprise",
        type: "POST",
        contentType: 'application/json',
        data: JSON.stringify(entr),
        success: function (req) {
            console.log(req);
        }
    });

}

window.onload = function () {
    /*
    let savebtn = document.getElementById("saveBtn");

    if (savebtn != null) {

        savebtn.onclick = function () {
            htmlToModel().save();
            window.location.replace("/Home/AllEntreprises");
        };
    }
    //*/
};

