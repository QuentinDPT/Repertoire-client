using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepertoireClient.Services
{
    public class IO
    {
        /// <summary>
        /// Document CSV de sauvegarde et de restauration
        /// </summary>
        public static string Document = "C:/Users/YP9NSS/Documents/Dev/Repertoire-client/RepertoireClient/RepertoireClient/data.csv";

        /// <summary>
        /// Délimitteur dans le document CSV
        /// </summary>
        public static char Delimitter = ';';

        /// <summary>
        /// Donne toutes les entreprises d'un document CSV avec leur contacts
        /// </summary>
        /// <param name="document">Stockage du document CSV</param>
        /// <returns>Liste d'entreprises avec leurs contacts</returns>
        public static List<ViewModel.Entreprise> getEntreprises(string document)
        {
            List<ViewModel.Entreprise> rezz = new List<ViewModel.Entreprise>();

            List<Models.Entreprise> entreprises = _getEntreprises(document);
            List<Models.Employee> employees = _getEmployees(document);

            for (int i = 0; i < entreprises.Count; i++)
            {
                List<ViewModel.Employee> tmps = new List<ViewModel.Employee>();

                Models.Employee[] emps = employees.Where(x => x.Entreprise_ID == entreprises[i].ID).ToArray();

                for (int j = 0; j < emps.Length; j++)
                {
                    tmps.Add(emps[j].toVM());
                }

                var vmEntreprise = entreprises[i].toVM();

                vmEntreprise.Contacts = tmps;

                rezz.Add(vmEntreprise);
            }

            return rezz;
        }

        /// <summary>
        /// Ajoute un contact à une entreprise déja existante
        /// </summary>
        /// <param name="employee">contact à ajouter à l'entreprise</param>
        /// <param name="document">document à modifier</param>
        public static void addContact(ViewModel.Employee employee, string document)
        {


            System.IO.File.WriteAllText(document, "");
        }

        /// <summary>
        /// Ajoute une entreprise avec tous ses contacts
        /// </summary>
        /// <param name="entreprise">entreprise à ajouter</param>
        /// <param name="document">document à modifier</param>
        public static void addEntreprise(ViewModel.Entreprise entreprise, string document)
        {
            List<ViewModel.Employee> emps = entreprise.Contacts;


            System.IO.File.WriteAllText(document, entreprise.toModels().toCSV());
        }


        private static List<Models.Entreprise> _getEntreprises(string document)
        {
            List<Models.Entreprise> rezz = new List<Models.Entreprise>();

            string[] fileContent = System.IO.File.ReadAllLines(document);

            int i;

            for (i = 0; i < fileContent.Length && fileContent[i].Trim(new Char[] { Delimitter }) != "<ENTREPRISES>"; i++) { }

            if (++i >= fileContent.Length)
                return null;

            for (; i < fileContent.Length; i++)
            {
                if (fileContent[i].Trim(new Char[] { Delimitter }) == "")
                    return rezz;
                string[] line = fileContent[i].Split(Delimitter);

                rezz.Add(new Models.Entreprise()
                {
                    ID = int.Parse(line[0]),
                    Nom = line[1],
                    Site = line[2],
                    Code_Ordre = line[3],
                    Telephone = line[4],
                    Fax = line[5],
                    OuvertureAM = line[6],
                    FermetureAM = line[7],
                    OuverturePM = line[8],
                    FermeturePM = line[9],
                    Fermeture_exceptionnelleSpecification = line[10],
                    Fermeture_exceptionnelleAM = line[11],
                    Fermeture_exceptionnellePM = line[12],
                    Rue = line[13],
                    Code_Postal = line[14],
                    Ville = line[15],
                    Porteur = line[16] == "x",
                    Semis_Remorque = line[17] == "x",
                    Vul = line[18] == "x",
                    Haillon = line[19] == "x",
                    Tire_Palette = line[20] == "x",
                    Remorque_Tautliner = line[21] == "x",
                    Remorque_Fourgon = line[22] == "x",
                    Remorque_Frigorifique = line[23] == "x",
                    Commentaire = line[24]
                });
            }

            return rezz;
        }

        private static List<Models.Employee> _getEmployees(string document)
        {
            List<Models.Employee> rezz = new List<Models.Employee>();

            string[] fileContent = System.IO.File.ReadAllLines(document);

            int i;

            for (i = 0; i < fileContent.Length && fileContent[i].Trim(new Char[] { Delimitter }) != "<CONTACTS>"; i++) { }

            if (++i >= fileContent.Length)
                return null;

            for (; i < fileContent.Length; i++)
            {
                if (fileContent[i].Trim(new Char[] { Delimitter }) == "")
                    return rezz;
                string[] line = fileContent[i].Split(Delimitter);

                rezz.Add(new Models.Employee()
                {
                    Entreprise_ID = int.Parse(line[0]),
                    Nom = line[1],
                    Mail = line[2],
                    Telephone = line[3]
                });
            }

            return rezz;
        }
    }
}