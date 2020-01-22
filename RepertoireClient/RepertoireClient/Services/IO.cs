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
        public static string Document;

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
            List<string> fileContent = System.IO.File.ReadAllLines(document).ToList();
            List<ViewModel.Employee> emps = entreprise.Contacts;

            int i ;
            int id = 1;

            // Add Entreprise

            for (i = 0; i < fileContent.Count && fileContent[i].Trim(new Char[] { Delimitter }) != "<ENTREPRISES>"; i++) { }

            for (i++; i < fileContent.Count && fileContent[i].Trim(new Char[] { Delimitter }) != ""; i++)
            {
                int curr_id = int.Parse(fileContent[i].Split(Delimitter)[0]);
                if (id <= curr_id)
                    id = curr_id + 1;
            }

            if (i >= fileContent.Count)
                return ;

            entreprise.ID = id;

            fileContent.Insert(i, entreprise.toModels().toCSV());


            // Add contacts
            
            for (i++; i < fileContent.Count && fileContent[i].Trim(new Char[] { Delimitter }) != "<CONTACTS>"; i++) { }

            for (i++; i < fileContent.Count && fileContent[i].Trim(new Char[] { Delimitter }) != ""; i++){ }


            List<string> lst_contacts = new List<string>();

            for(int j = 0; j<entreprise.Contacts.Count; j++)
            {
                lst_contacts.Add(entreprise.Contacts[j].toModel().toCSV());
            }

            fileContent.InsertRange(i, lst_contacts);

            System.IO.File.WriteAllLines(document, fileContent);
        }

        /// <summary>
        /// Enlève une entreprise
        /// </summary>
        /// <param name="id">identifiant de l'entreprise</param>
        /// <param name="doc">document à modifier</param>
        /// <returns></returns>
        public static bool removeEntreprise(int id, string doc)
        {
            List<string> fileContent = System.IO.File.ReadAllLines(doc).ToList();

            bool lineRemoved = false;

            for(int i = 0; i<fileContent.Count; i++)
            {
                try
                {
                    if (int.Parse(fileContent[i].Split(Delimitter)[0]) == id)
                    {
                        fileContent.RemoveAt(i);
                        lineRemoved = true;
                        i--;
                    }
                }
                catch (Exception e) { };
            }

            System.IO.File.WriteAllLines(doc, fileContent);

            return lineRemoved;
        }

        /// <summary>
        /// Modifie une entreprise existante
        /// </summary>
        /// <param name="entreprise">entreprise à modifier</param>
        /// <param name="document">document à modifier</param>
        public static bool modifyEntreprise(ViewModel.Entreprise entreprise, string document)
        {
            if (entreprise.ID != 0 && removeEntreprise(entreprise.ID, document))
            {
                addEntreprise(entreprise, document);
                return true;
            }
            return false;
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
                    OuvertureAM = Convert.ToDateTime(line[6]),
                    FermetureAM = Convert.ToDateTime(line[7]),
                    OuverturePM = Convert.ToDateTime(line[8]),
                    FermeturePM = Convert.ToDateTime(line[9]),
                    Fermeture_exceptionnelleSpecification = line[10],
                    Fermeture_exceptionnelleAM = Convert.ToDateTime(line[11]),
                    Fermeture_exceptionnellePM = Convert.ToDateTime(line[12]),
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