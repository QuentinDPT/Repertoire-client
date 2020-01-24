using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepertoireClient.ViewModel
{
    public class Entreprise
    {
        #region Variables

        #region Informations générales

        /// <summary>
        /// Identifiant unique de l'entreprise
        /// </summary>
        public int ID {
            get { return _ID; }
            set {
                if (Contacts != null)
                {
                    for (int i = 0; i < this.Contacts.Count; i++)
                    {
                        this.Contacts[i].Entreprise_ID = value;
                    }
                }
                _ID = value;
            }
        }

        private int _ID;

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

        public string JourOuverture;

        public string JourFermeture;

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

        public string JourFermeture_exceptionnelle;

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

        /// <summary>
        /// Liste des contacts dans l'entreprise
        /// </summary>
        public List<Employee> Contacts;

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

        public Models.Entreprise toModels()
        {
            string[] tmp;

            // Heure d'ouverture matin
            tmp = this.OuvertureAM == "" ? new[] {"00","00" } : this.OuvertureAM.Split(new[] { ':' });        // Donne une date d'ouverture en fonction du jour
            DateTime _OuvertureAM = new DateTime(
                2018,1,dayToInt(this.JourOuverture),
                int.Parse(tmp[0]),int.Parse(tmp[1]),0);

            // Heure de fermeture matin
            tmp = this.FermetureAM == "" ? new[] { "00", "00" } : this.FermetureAM.Split(new[] { ':' });        // Donne une heure de fermeture en fonction du jour
            DateTime _FermetureAM = new DateTime(
                2018, 1, 1,
                int.Parse(tmp[0]), int.Parse(tmp[1]), 0);

            // Heure d'ouverture apres midi
            tmp = this.OuverturePM == "" ? new[] { "00", "00" } : this.OuverturePM.Split(new[] { ':' });        // Donne une heure d'ouverture en fonction du jour
            DateTime _OuverturePM = new DateTime(
                2018, 1, 1,
                int.Parse(tmp[0]), int.Parse(tmp[1]), 0);

            // Heure de fermeture apres midi
            tmp = this.FermeturePM == "" ? new[] { "00", "00" } : this.FermeturePM.Split(new[] { ':' });        // Donne une date de fermeture en fonction du jour
            DateTime _FermeturePM = new DateTime(
                2018, 1, dayToInt(this.JourFermeture),
                int.Parse(tmp[0]), int.Parse(tmp[1]), 0);


            // Heure de fermeture exceptionnelle debut
            tmp = this.Fermeture_exceptionnelleAM == "" ? new[] { "00", "00" } : this.Fermeture_exceptionnelleAM.Split(new[] { ':' });        // Donne une date de fermeture en fonction du jour
            DateTime _FermetureExBeg = new DateTime(
                2018, 1, dayToInt(this.JourFermeture_exceptionnelle),
                int.Parse(tmp[0]), int.Parse(tmp[1]), 0);

            // Heure de fermeture exceptionnelle fin
            tmp = this.Fermeture_exceptionnellePM == "" ? new[] { "00", "00" } : this.Fermeture_exceptionnellePM.Split(new[] { ':' });        // Donne une date de fermeture en fonction du jour
            DateTime _FermetureExEnd = new DateTime(
                2018, 1, dayToInt(this.JourFermeture_exceptionnelle),
                int.Parse(tmp[0]), int.Parse(tmp[1]), 0);

            return new Models.Entreprise()
            {
                ID = this.ID,
                Nom = this.Nom,
                Site = this.Site,
                Code_Ordre = this.Code_Ordre,
                Telephone = this.Telephone,
                Fax = this.Fax,
                OuvertureAM = _OuvertureAM,
                FermetureAM = _FermetureAM,
                OuverturePM = _OuverturePM,
                FermeturePM = _FermeturePM,
                Fermeture_exceptionnelleSpecification = this.Fermeture_exceptionnelleSpecification,
                Fermeture_exceptionnelleAM = _FermetureExBeg,
                Fermeture_exceptionnellePM = _FermetureExEnd,
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

        private int dayToInt(string day)
        {
            switch (day.ToLower())
            {
                case "lundi":
                    return 1;
                case "mardi":
                    return 2;
                case "mercredi":
                    return 3;
                case "jeudi":
                    return 4;
                case "vendredi":
                    return 5;
                case "samedi":
                    return 6;
                case "dimanche":
                    return 7;
                default:
                    return 0;
            }
        }
    }
}