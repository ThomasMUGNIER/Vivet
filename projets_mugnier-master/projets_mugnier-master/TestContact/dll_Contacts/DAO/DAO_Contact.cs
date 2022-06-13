using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Contacts
{
    public class DAO_Contact
    {
        public static void EnregistreContact(cls_Contact[] ptabContacts)
        {

            StreamWriter sw = new StreamWriter("Contacts.csv");

            foreach (cls_Contact l_Element in ptabContacts)
            {
                string l_strIDEntreprise = "";
                if(l_Element.Entreprise!=null)
                {
                    l_strIDEntreprise = l_Element.Entreprise.ID.ToString();
                }
                sw.WriteLine(l_Element.ID + ";" + l_Element.getNom() + ";" + l_Element.Prenom + ";"+ l_strIDEntreprise);
            }
            sw.Close();
        }

        public static cls_Contact[] ChargerContact(cls_Entreprise[] ptabEntreprises)
        {
            List<cls_Contact> l_lstContact = new List<cls_Contact>();
            using (StreamReader l_StreamReader = new StreamReader("Contacts.csv"))
            {
                string l_Ligne = l_Ligne = l_StreamReader.ReadLine();

                while (l_Ligne != null)
                {
                    cls_Contact l_Contact = CreContact(l_Ligne, ptabEntreprises);
                    l_lstContact.Add(l_Contact);
                    l_Ligne = l_StreamReader.ReadLine();
                }
            }
            return l_lstContact.ToArray();
        }

        /// <summary>
        /// Constructeur qui permet d'initialiser une Contact à partir d'une chaine au format CSV
        /// </summary>
        /// <param name="pChaineCSV">Chaine au format CSV permettant d'initialiser l'objet Contact</param>
        public static cls_Contact CreContact(string pChaineCSV,cls_Entreprise[] ptabEntreprises)
        {
            //Récupération des informations contenues dans la chaine CSV
            string[] l_tabInfosSTR = pChaineCSV.Split(';');
            int l_ID = int.Parse(l_tabInfosSTR[0]);
            string l_Nom = l_tabInfosSTR[1];
            string l_Prenom = l_tabInfosSTR[2];
            string l_ID_str = l_tabInfosSTR[3];
            if(l_ID_str != "")
            {
                return new cls_Contact(l_ID, l_Nom, l_Prenom, EntrepriseParID(int.Parse(l_ID_str), ptabEntreprises));
            }
            else
            {
                return new cls_Contact(l_ID, l_Nom, l_Prenom,null);
            }
        }

        private static cls_Entreprise EntrepriseParID(int pID, cls_Entreprise[] ptab_Entreprises)
        {
            foreach(cls_Entreprise l_entreprise in ptab_Entreprises)
            {
                if(l_entreprise.ID == pID)
                {
                    return l_entreprise;
                }
            }
            return null;
        }


    }
}
