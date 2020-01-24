
function htmlToModel() {
    let rezz = new Entreprise();

    rezz.Nom = document.getElementById("entreprise_name").value;
    rezz.Telephone = document.getElementById("telephone").value;
    rezz.Fax = document.getElementById("fax").value;
    rezz.Code_Ordre = document.getElementById("cde_ordre").value;
    rezz.Site = document.getElementById("web_site").value;

    rezz.JourOuverture = document.getElementById("jour_ouverture").value;
    rezz.JourFermeture = document.getElementById("jour_fermeture").value;
    rezz.OuvertureAM = document.getElementById("oAM").value;
    rezz.FermetureAM = document.getElementById("fAM").value;
    rezz.OuverturePM = document.getElementById("oPM").value;
    rezz.FermeturePM = document.getElementById("fPM").value;
    rezz.JourFermeture_exceptionnelle = document.getElementById("jour_exeptionnel").value;
    rezz.Fermeture_exceptionnelleAM = document.getElementById("feAM").value;
    rezz.Fermeture_exceptionnellePM = document.getElementById("fePM").value;
    rezz.Fermeture_exceptionnelleSpecification = document.getElementById("feDesc").value;

    rezz.Ville = document.getElementById("ville").value;
    rezz.Code_Postal = document.getElementById("code_postal").value;
    rezz.Rue = document.getElementById("rue").value;

    rezz.Commentaire = document.getElementById("commentaire").value;

    rezz.Porteur = document.getElementById("porteur").checked;
    rezz.Semis_Remorque = document.getElementById("semis").checked;
    rezz.Vul = document.getElementById("vul").checked;
    rezz.Haillon = document.getElementById("haillon").checked;
    rezz.Tire_Palette = document.getElementById("tire_pal").checked;
    rezz.Remorque_Tautliner = document.getElementById("tautliner").checked;
    rezz.Remorque_Fourgon = document.getElementById("fourgon").checked;
    rezz.Remorque_Frigorifique = document.getElementById("frigo").checked;

    for (let i = 0; i < count_contacts; i++) {

        let ct_line = document.getElementById("contact_" + i);
        if (ct_line != null) {
            let contact = new Employee();

            let nom = ct_line.getElementsByClassName("name")[0].value;
            let mail = ct_line.getElementsByClassName("mail")[0].value;
            let tel = ct_line.getElementsByClassName("tel")[0].value;

            if (nom != "") {
                contact.Nom = nom;
                contact.Mail = mail;
                contact.Telephone = tel;

                rezz.Contacts.push(contact);
            }
        }
    }

    return rezz;
}

