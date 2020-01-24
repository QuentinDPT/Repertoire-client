
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

