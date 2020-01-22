
class Entreprise {
    constructor() {
        this.ID = 0;
        this.Nom = "";
        this.Site = "";
        this.Code_Ordre = "";
        this.Telephone = "";
        this.Fax = "";
        this.Contacts = [];
        this.JourOuverture = "";
        this.JourFermeture = "";
        this.OuvertureAM = "";
        this.FermetureAM = "";
        this.OuverturePM = "";
        this.FermeturePM = "";
        this.Fermeture_exceptionnelleSpecification = "";
        this.JourFermeture_exceptionnelle = "";
        this.Fermeture_exceptionnelleAM = "";
        this.Fermeture_exceptionnellePM = "";
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
        return true;
    }

    nextClose(date) {
        let rezz;

        return date;
    }

    nextOpen(date) {

    }

}