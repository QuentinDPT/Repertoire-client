using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepertoireClient.Models
{
    public class Entreprise
    {
        #region Variables

        #region Informations générales

        /// <summary>
        /// Identifiant unique de l'entreprise
        /// </summary>
        public int ID;

        /// <summary>
        /// Nom de l'entreprise
        /// </summary>
        public string Nom;

        /// <summary>
        /// Site internet de l'entreprise
        /// </summary>
        public string Site;

        /// <summary>
        /// Code de donneur d'ordres
        /// </summary>
        public string Code_Ordre;

        /// <summary>
        /// Numéro de téléphone de l'entreprise
        /// </summary>
        public string Telephone;

        /// <summary>
        /// Fax de l'entreprise
        /// </summary>
        public string Fax;

        #endregion

        #region Horraires

        /// <summary>
        /// Heure d'ouverture (Matin) de l'entreprise
        /// </summary>
        public string OuvertureAM;

        /// <summary>
        /// Heure de fermeture (Matin) de l'entreprise
        /// </summary>
        public string FermetureAM;

        /// <summary>
        /// Heure d'ouverture (Après-midi) de l'entreprise
        /// </summary>
        public string OuverturePM;

        /// <summary>
        /// Heure de fermeture (Après-midi) de l'entreprise
        /// </summary>
        public string FermeturePM;

        /// <summary>
        /// Spécificités des fermetures exceptionnelles
        /// </summary>
        public string Fermeture_exceptionnelleSpecification;

        /// <summary>
        /// Jour et heure de fermeture exceptionnelle le matin
        /// </summary>
        public string Fermeture_exceptionnelleAM;

        /// <summary>
        /// Jour et heure de fermeture exceptionnelle l'après-midi
        /// </summary>
        public string Fermeture_exceptionnellePM;

        #endregion

        #region Coordonnées

        /// <summary>
        /// Rue de l'entreprise
        /// </summary>
        public string Rue;

        /// <summary>
        /// Code postal de l'entreprise
        /// </summary>
        public string Code_Postal;

        /// <summary>
        /// Ville de l'entreprise
        /// </summary>
        public string Ville;

        #endregion

        #region Materiel

        /// <summary>
        /// L'entreprise est équipée d'un porteur
        /// </summary>
        public bool Porteur;

        /// <summary>
        /// L'entreprise est équipée de semis remorques
        /// </summary>
        public bool Semis_Remorque;

        /// <summary>
        /// L'entreprise est équipée de Vul
        /// </summary>
        public bool Vul;

        /// <summary>
        /// L'entreprise est équipée de haillons
        /// </summary>
        public bool Haillon;

        /// <summary>
        /// L'entreprise est équipée de tire palettes
        /// </summary>
        public bool Tire_Palette;

        /// <summary>
        /// L'entreprise est équipée de Tautliner
        /// </summary>
        public bool Remorque_Tautliner;

        /// <summary>
        /// L'entrepise est équipée de fourgons
        /// </summary>
        public bool Remorque_Fourgon;

        /// <summary>
        /// l'entreprise est équipée de remorques frigorifiques
        /// </summary>
        public bool Remorque_Frigorifique;

        #endregion


        /// <summary>
        /// Commentaire sur l'entreprise
        /// </summary>
        public string Commentaire;

        #endregion

        public Entreprise()
        {

        }

        /// <summary>
        /// Convertis le model en view model
        /// </summary>
        /// <returns>View model associé au model</returns>
        public ViewModel.Entreprise toVM()
        {
            return new ViewModel.Entreprise()
            {
                ID = this.ID,
                Nom = this.Nom,
                Site = this.Site,
                Code_Ordre = this.Code_Ordre,
                Telephone = this.Telephone,
                Fax = this.Fax,
                Contacts = new List<ViewModel.Employee>(),
                OuvertureAM = this.OuvertureAM,
                FermetureAM = this.FermetureAM,
                OuverturePM = this.OuverturePM,
                FermeturePM = this.FermeturePM,
                Fermeture_exceptionnelleSpecification = this.Fermeture_exceptionnelleSpecification,
                Fermeture_exceptionnelleAM = this.Fermeture_exceptionnelleAM,
                Fermeture_exceptionnellePM = this.Fermeture_exceptionnellePM,
                Rue = this.Rue,
                Code_Postal = this.Code_Postal,
                Ville = this.Ville,
                Porteur = this.Porteur,
                Semis_Remorque = this.Semis_Remorque,
                Vul = this.Vul,
                Haillon = this.Haillon,
                Tire_Palette = this.Tire_Palette,
                Remorque_Tautliner = this.Remorque_Tautliner,
                Remorque_Fourgon = this.Remorque_Fourgon,
                Remorque_Frigorifique = this.Remorque_Frigorifique,
                Commentaire = this.Commentaire
            };
        }

        /// <summary>
        /// Donne une ligne à exporter dans un CSV
        /// </summary>
        /// <param name="d">delimitter : delimitter par défaut dans Services.IO.cs</param>
        /// <returns>ligne à importer</returns>
        public string toCSV(char? d = null)
        {
            if (d == null)
                d = Services.IO.Delimitter;

            return ID +
                d + Site +
                d + Code_Ordre +
                d + Telephone +
                d + Fax +
                d + OuvertureAM +
                d + FermeturePM +
                d + Fermeture_exceptionnelleSpecification +
                d + Fermeture_exceptionnelleAM +
                d + Fermeture_exceptionnellePM +
                d + Rue +
                d + Code_Ordre +
                d + Ville +
                d + Porteur +
                d + Semis_Remorque +
                d + Vul +
                d + Haillon +
                d + Tire_Palette +
                d + Remorque_Tautliner +
                d + Remorque_Fourgon +
                d + Remorque_Frigorifique +
                d + Commentaire;
        }
    }
}