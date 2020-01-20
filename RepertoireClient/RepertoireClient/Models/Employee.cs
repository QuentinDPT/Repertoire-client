using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepertoireClient.Models
{
    public class Employee
    {
        #region Variables

        /// <summary>
        /// ID de l'entreprise dans laquelle l'employé travaille
        /// </summary>
        public int Entreprise_ID;

        /// <summary>
        /// Nom de l'employé
        /// </summary>
        public string Nom;

        /// <summary>
        /// Addresse mail de l'employé
        /// </summary>
        public string Mail;

        /// <summary>
        /// Numéro de téléphone de l'employé
        /// </summary>
        public string Telephone;

        #endregion

        public Employee()
        {

        }

        /// <summary>
        /// Convertis le model en view model
        /// </summary>
        /// <returns>View model associé au model</returns>
        public ViewModel.Employee toVM()
        {
            return new ViewModel.Employee()
            {
                Entreprise_ID = this.Entreprise_ID,
                Nom = this.Nom,
                Mail = this.Mail,
                Telephone = this.Telephone
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

            return Entreprise_ID.ToString() +
                d + Nom +
                d + Mail +
                d + Telephone;
        }
    }
}