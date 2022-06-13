using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_Contacts.Modele;
using dll_Contacts.DAO;

namespace dll_Contacts.DAO
{
    public class DAO_Projet
    {
        public static cls_Projet[] cree_Projet()
        {
            cls_Projet[] l_tab_Projet = new cls_Projet[80];

            for (int i = l_tab_Projet.GetLength(0) - 1; i >= 0; i--)
            {
                l_tab_Projet[i] = new cls_Projet((i + 1), "Sociale " + (i + 1), + (i + 1));
            }

            return l_tab_Projet;
        }

        /// <summary>
        /// Permet d'enregistrer le tableau des entreprises en CSV
        /// </summary>
        /// <param name="ptab_entreprise"></param>
        public static void save_Projet_CSV(cls_Projet[] ptab_Projet)
        {
            StreamWriter l_StreamWritter = new StreamWriter("Projet.csv");

            foreach (cls_Projet l_element in ptab_Projet)
            {
                l_StreamWritter.WriteLine(l_element.ID + ";" + l_element.sociale + ";" + l_element.Postale);
            }
            l_StreamWritter.Close();
        }

        /// <summary>
        /// Permet d'enregistrer une entreprise à partir d'une chaîne au format CSV
        /// </summary>
        /// <param name="pchaineCSV">Chaine au format CSV permettant d'initialiser l'objet entreprise</param>
        public static cls_Projet crea_Projet(string pchaineCSV)
        {
            string[] l_tab_STR = pchaineCSV.Split(';');
            int ID = int.Parse(l_tab_STR[0]);
            string Sociale = l_tab_STR[1];
            int Postale = int.Parse(l_tab_STR[2]);

            return new cls_Projet(ID, Sociale, Postale);
        }

        /// <summary>
        /// Permet de lire le CSV des entreprises et de les transformer en objet
        /// </summary>
        public static cls_Projet[] lire_Projet_CSV()
        {
            List<cls_Projet> l_list_Projet = new List<cls_Projet>();
            using (StreamReader l_StreamReader = new StreamReader("Projet.csv"))
            {
                string l_Ligne = l_StreamReader.ReadLine();

                while (l_Ligne != null)
                {
                    l_list_Projet.Add(crea_Projet(l_Ligne));
                    l_Ligne = l_StreamReader.ReadLine();
                }
                l_StreamReader.Close();
            }
            return l_list_Projet.ToArray();
        }
    }
}