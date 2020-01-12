using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepertoireClient.ViewModel
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

        public Models.Employee toModel()
        {
            return new Models.Employee()
            {
                Entreprise_ID = this.Entreprise_ID,
                Nom = this.Nom,
                Mail = this.Mail,
                Telephone = this.Telephone
            };
        }
    }
}