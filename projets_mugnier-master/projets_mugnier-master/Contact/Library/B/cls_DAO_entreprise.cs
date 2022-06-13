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
    public class Cls_DAO_Entreprise
    {
        /// <summary>
        /// Permet d'instancier les objets
        /// </summary>
        /// <returns></returns>
        public virtual Dictionary<int, cls_entreprise> cree_entreprise()
        {
            Dictionary<int, cls_entreprise> l_dic_entreprise = new();

            for (int i = 0; i < 50; i++)
            {
                l_dic_entreprise.Add((i + 1), new cls_entreprise((i + 1), "Raison sociale " + (i + 1), codepostalealeatoire(), "Commune " + (i + 1), "mail." + (i + 1) + "@gmail.com", "www.URL" + (i + 1) + ".fr"));
            }

            return l_dic_entreprise;
        }

        /// <summary>
        /// Enregistrer le tableau des entreprises en CSV
        /// </summary>
        /// <param name="p_list_entreprise"></param>
        public virtual void save_entreprise_CSV(List<cls_entreprise> p_list_entreprise)
        {
            StreamWriter l_StreamWritter = new("Entreprises.csv");

            foreach (cls_entreprise l_element in p_list_entreprise)
            {
                l_StreamWritter.WriteLine(l_element.ID + ";" + l_element.raisonsociale + ";" + l_element.Codepostale + ";" + l_element.Commune + ";" + l_element.mail + ";" + l_element.URL);
            }
            l_StreamWritter.Close();
        }

        /// <summary>
        /// Znregistrer une entreprise au format CSV
        /// </summary>
        /// <param name="p_chaine_CSV">Chaine au format CSV permettant d'initialiser l'objet entreprise</param>
        public virtual cls_entreprise CreationEntreprise(string p_chaine_CSV)
        {
            string[] l_tabInfosSTR = p_chaine_CSV.Split(';');
            int ID = int.Parse(l_tabInfosSTR[0]);
            string raisonsociale = l_tabInfosSTR[1];
            string Codepostale = l_tabInfosSTR[2];
            string Commune = l_tabInfosSTR[3];
            string mail = l_tabInfosSTR[4];
            string URL = l_tabInfosSTR[5];

            return new cls_entreprise(ID, raisonsociale, Codepostale, Commune, mail, URL);
        }

        /// <summary>
        /// Permet de lire le CSV des entreprises et de les transformer en objet
        /// </summary>
        public virtual Dictionary<int, cls_entreprise> lire_entreprise_CSV()
        {
            Dictionary<int, cls_entreprise> l_dic_entreprise = new();
            using (StreamReader l_StreamReader = new("entreprises.csv"))
            {
                string? l_ligne = l_StreamReader.ReadLine();

                while (l_ligne != null)
                {
                    cls_entreprise l_entreprise = CreationEntreprise(l_ligne);
                    l_dic_entreprise.Add(l_entreprise.ID, l_entreprise);
                    l_ligne = l_StreamReader.ReadLine();
                }
                l_StreamReader.Close();
            }
            return l_dic_entreprise;
        }

        /// <summary>
        /// Permet de retourner un code postal aléatoire
        /// </summary>
        /// <returns></returns>
        public static int codepostalealeatoire()
            {
                Random l_random = new Random();
                int codepostale = l_random.Next(10000, 99999);
                return codepostale;
            }
    } 
}

