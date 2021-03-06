using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.B;
using Library.A;

namespace Library.B
{
    public class cls_DAO_Contact_BD : Cls_DAO_Contact
    {
        /// <summary>
        /// Vérifier le lien entre une entreprise et un contat via l'ID
        /// </summary>
        /// <param name="pID"></param>
        /// <param name="p_list_entreprise"></param>
        /// <returns></returns>
        public override cls_entreprise? entreprise_by_ID(int pID, List<cls_entreprise> p_list_entreprise)
        {
            foreach (cls_entreprise l_entreprise in p_list_entreprise)
            {
                if (l_entreprise.ID == pID)
                {
                    return l_entreprise;
                }
            }
            return null;
        }

        /// <summary>
        /// Instancier les objets dans les tableaux
        /// </summary>
        /// <param name="pListEntreprise"></param>
        /// <returns></returns>
        public override Dictionary<int, cls_contact> cree_contact(List<cls_entreprise> p_list_entreprise)
        {
            Dictionary<int, cls_contact> l_dic_contact = new();

            for (int j = 0; j < 200; j++)
            {
                l_dic_contact.Add((j + 1), new cls_contact("Nom " + (j + 1), "Prenom " + (j + 1), datealeatoire(), "Adresse " + (j + 1), "mail." + (j + 1) + "@gmail.com", phonerandom(), (j + 1), null));

                Random Rand = new();
                int l_numero = Rand.Next(0, (p_list_entreprise.Count + (p_list_entreprise.Count * 25) / 100));
                if (l_numero < p_list_entreprise.Count)
                {
                    l_dic_contact.ElementAt(j).Value.entreprise = p_list_entreprise[l_numero];
                }
            }

            return l_dic_contact;
        }

        /// <summary>
        /// Permet d'enregistrer le tableau des contacts en CSV
        /// </summary>
        /// <param name="pListContact"></param>
        public override void save_contact_CSV(List<cls_contact> p_list_contact)
        {
            StreamWriter l_StreamWritter = new("Contacts.csv");

            foreach (cls_contact l_element in p_list_contact)
            {
                string l_ID_entreprise = "";
                if (l_element.entreprise != null)
                {
                    l_ID_entreprise = l_element.entreprise.ID.ToString();
                }
                l_StreamWritter.WriteLine(l_element.ID + ";" + l_element.nom + ";" + l_element.prenom + ";" + l_element.datedenaissance + ";" + l_element.adresse + ";" + l_element.mail + ";" + l_element.phone + ";" + l_ID_entreprise);
            }
            l_StreamWritter.Close();
        }

        /// <summary>
        /// Enregistrer un contact au format CSV
        /// </summary>
        /// <param name="p_chaine_CSV"></param>
        /// <param name="p_list_entreprise"></param>
        /// <returns></returns>
        public override cls_contact crea_contact(string p_chaine_CSV, List<cls_entreprise> p_list_entreprise)
        {
            string[] l_tabInfosSTR = p_chaine_CSV.Split(';');
            int ID = int.Parse(l_tabInfosSTR[0]);
            string nom = l_tabInfosSTR[1];
            string prenom = l_tabInfosSTR[2];
            DateTime datedenaissance = DateTime.Parse(l_tabInfosSTR[3]);
            string Adresse = l_tabInfosSTR[4];
            string mail = l_tabInfosSTR[5];
            string phone = l_tabInfosSTR[6];
            string l_IDStr = l_tabInfosSTR[7];
            // Pour gérer la liaison avec les entreprises quand on importe le fichier CSV
            if (l_IDStr != "")
            {
                return new cls_contact(nom, prenom, datedenaissance, Adresse, mail, phone, ID, entreprise_by_ID(int.Parse(l_IDStr), p_list_entreprise));
            }
            else
            {
                return new cls_contact(nom, prenom, datedenaissance, Adresse, mail, phone, ID, null);
            }
        }

        /// <summary>
        /// Lire le CSV des contacts et de les transformer en objet
        /// </summary>
        /// <param name="pListEntreprise"></param>
        /// <returns></returns>
        public override Dictionary<int, cls_contact> lire_contact_CSV(List<cls_entreprise> p_list_entreprise)
        {
            Dictionary<int, cls_contact> l_dic_contact = new();
            using (StreamReader l_StreamReader = new("Contacts.csv"))
            {
                string? l_ligne = l_StreamReader.ReadLine();

                while (l_ligne != null)
                {
                    cls_contact l_Contact = crea_contact(l_ligne, p_list_entreprise);
                    l_dic_contact.Add(l_Contact.ID, l_Contact);
                    l_ligne = l_StreamReader.ReadLine();
                }
                l_StreamReader.Close();
            }
            return l_dic_contact;
        }
    }
}
