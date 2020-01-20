class Employee {
    constructor() {
        this.Entreprise_ID = 0;
        this.Nom = "";
        this.Mail = "";
    }


}

class Entreprise {
    constructor() {
        this.ID = 0;
        this.Nom = "";
        this.Site = "";
        this.Code_Ordre = "";
        this.Telephone = "";
        this.Fax = "";
        this.Contacts = [];
        this.OuvertureAM = new Date();
        this.FermetureAM = new Date();
        this.OuverturePM = new Date();
        this.FermeturePM = new Date();
        this.Fermeture_exceptionnelleSpecification = "";
        this.Fermeture_exceptionnelleAM = new Date();
        this.Fermeture_exceptionnellePM = new Date();
        this.Rue = "";
        this.Code_Postal = "";
        this.Ville = "";
        this.Porteur = false;
        this.Semis_Remorque = false;
        this.Vul = false;
        this.Haillon = false;
        this.Tire_Palette = false;
        this.Remorque_Tautliner = false;
        this.Remorque_Fourgon = false;
        this.Remorque_Frigorifique = false;
        this.Commentaire = false;
    }

    isOpen(date) {
        console.log(date);
        return true ;
    }

    nextClose(date) {
        let rezz;

        return date;
    }

    nextOpen(date) {

    }

    save() {

        for (let i = 0; i < this.Contacts.length; i++) {
            this.Contacts[i].Entreprise_ID = this.ID;
        }

        exportEntreprise(this);
    }

    toHTML() {
        document.getElementById("entreprise_name").value = this.Nom;
        document.getElementById("telephone").value = this.Telephone;
        document.getElementById("fax").value = this.Fax;
        document.getElementById("cde_ordre").value = this.Code_Ordre;
        document.getElementById("web_site").value = this.Site;
        document.getElementById("ville").value = this.Ville;
        document.getElementById("code_postal").value = this.Code_Postal;
        document.getElementById("rue").value = this.Rue;
        document.getElementById("commentaire").value = this.Commentaire;

        let _contacts = document.getElementById("contact_content");
        for (let i in this.Contacts) {
            _contacts += "<tr><td>" + i.Nom + "</td><td>" + i.Mail + "</td><\tr>";
        }
    }
}

