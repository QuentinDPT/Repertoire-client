
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

            contact.Nom = ct_line.getElementsByClassName("name")[0].value;
            contact.Mail = ct_line.getElementsByClassName("mail")[0].value;
            contact.Telephone = ct_line.getElementsByClassName("tel")[0].value;

            rezz.Contacts.push(contact);
        }
    }

    return rezz;
}

