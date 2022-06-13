using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class cls_DAO_Contact_BD:Cls_DAO_Contact
    {
        /// <summary>
        /// Permet de vérifier le lien entre une entreprise et un contat via l'ID
        /// </summary>
        /// <param name="pID"></param>
        /// <param name="pListEntreprise"></param>
        /// <returns></returns>
        public override Cls_Entreprise? EntrepriseParID(int pID, List<Cls_Entreprise> pListEntreprise)
        {
            foreach (Cls_Entreprise l_Entreprise in pListEntreprise)
            {
                if (l_Entreprise.ID == pID)
                {
                    return l_Entreprise;
                }
            }
            return null;
        }

        /// <summary>
        /// Permet d'instancier les objets dans les tableaux
        /// </summary>
        /// <param name="pListEntreprise"></param>
        /// <returns></returns>
        public override Dictionary<int, Cls_Contact> CreerContact(List<Cls_Entreprise> pListEntreprise)
        {
            Dictionary<int, Cls_Contact> l_DicContact = new();

            for (int j = 0; j < 200; j++)
            {
                l_DicContact.Add((j + 1), new Cls_Contact((j + 1), "Nom " + (j + 1), "Prenom " + (j + 1), DateAleatoire(), "Adresse " + (j + 1), "mail." + (j + 1) + "@gmail.com", TelephoneAleatoire(), null));

                Random Rand = new();
                int l_Numero = Rand.Next(0, (pListEntreprise.Count + (pListEntreprise.Count * 25) / 100));
                if (l_Numero < pListEntreprise.Count)
                {
                    l_DicContact.ElementAt(j).Value.Entreprise = pListEntreprise[l_Numero];
                }
            }

            return l_DicContact;
        }

        /// <summary>
        /// Permet d'enregistrer le tableau des contacts en CSV
        /// </summary>
        /// <param name="pListContact"></param>
        public override void EnregistreContactCSV(List<Cls_Contact> pListContact)
        {
            StreamWriter l_StreamWritter = new("Contacts.csv");

            foreach (Cls_Contact l_Element in pListContact)
            {
                string l_StrIDEntreprise = "";
                if (l_Element.Entreprise != null)
                {
                    l_StrIDEntreprise = l_Element.Entreprise.ID.ToString();
                }
                l_StreamWritter.WriteLine(l_Element.ID + ";" + l_Element.Nom + ";" + l_Element.Prenom + ";" + l_Element.DateDeNaissance + ";" + l_Element.Adresse + ";" + l_Element.Mail + ";" + l_Element.Telephone + ";" + l_StrIDEntreprise);
            }
            l_StreamWritter.Close();
        }

        /// <summary>
        /// Permet d'enregistrer un contact à partir d'une chaîne au format CSV
        /// </summary>
        /// <param name="pChaineCSV"></param>
        /// <param name="pListEntreprise"></param>
        /// <returns></returns>
        public override Cls_Contact CreationContact(string pChaineCSV, List<Cls_Entreprise> pListEntreprise)
        {
            string[] l_tabInfosSTR = pChaineCSV.Split(';');
            int ID = int.Parse(l_tabInfosSTR[0]);
            string Nom = l_tabInfosSTR[1];
            string Prenom = l_tabInfosSTR[2];
            DateTime DateDeNaissance = DateTime.Parse(l_tabInfosSTR[3]);
            string Adresse = l_tabInfosSTR[4];
            string Mail = l_tabInfosSTR[5];
            string Telephone = l_tabInfosSTR[6];
            string l_IDStr = l_tabInfosSTR[7];
            // Pour gérer la liaison avec les entreprises quand on importe le fichier CSV
            if (l_IDStr != "")
            {
                return new Cls_Contact(ID, Nom, Prenom, DateDeNaissance, Adresse, Mail, Telephone, EntrepriseParID(int.Parse(l_IDStr), pListEntreprise));
            }
            else
            {
                return new Cls_Contact(ID, Nom, Prenom, DateDeNaissance, Adresse, Mail, Telephone, null);
            }
        }

        /// <summary>
        /// Permet de lire le CSV des contacts et de les transformer en objet
        /// </summary>
        /// <param name="pListEntreprise"></param>
        /// <returns></returns>
        public override Dictionary<int, Cls_Contact> LireContactCSV(List<Cls_Entreprise> pListEntreprise)
        {
            Dictionary<int, Cls_Contact> l_DicContact = new();
            using (StreamReader l_StreamReader = new("Contacts.csv"))
            {
                string? l_Ligne = l_StreamReader.ReadLine();

                while (l_Ligne != null)
                {
                    Cls_Contact l_Contact = CreationContact(l_Ligne, pListEntreprise);
                    l_DicContact.Add(l_Contact.ID, l_Contact);
                    l_Ligne = l_StreamReader.ReadLine();
                }
                l_StreamReader.Close();
            }
            return l_DicContact;
        }
    }
}

