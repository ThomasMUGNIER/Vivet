using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class cls_DAO_Entreprise_BD:Cls_DAO_Entreprise
    {
         /// <summary>
         /// Permet d'instancier les objets
         /// </summary>
         /// <returns></returns>
        public override Dictionary<int, Cls_Entreprise> CreerEntreprise()
        {
            Dictionary<int, Cls_Entreprise> l_DicEntreprise = new();

            for (int i = 0; i < 50; i++)
            {
                l_DicEntreprise.Add((i + 1), new Cls_Entreprise((i + 1), "Raison sociale " + (i + 1), CodePostalAleatoire(), "Commune " + (i + 1), "mail." + (i + 1) + "@gmail.com", "www.URL" + (i + 1) + ".fr"));
            }

            return l_DicEntreprise;
        }

        /// <summary>
        /// Permet d'enregistrer le tableau des entreprises en CSV
        /// </summary>
        /// <param name="pListEntreprise"></param>
        public override void EnregistreEntrepriseCSV(List<Cls_Entreprise> pListEntreprise)
        {
            StreamWriter l_StreamWritter = new("Entreprises.csv");

            foreach (Cls_Entreprise l_Element in pListEntreprise)
            {
                l_StreamWritter.WriteLine(l_Element.ID + ";" + l_Element.RaisonSociale + ";" + l_Element.CodePostal + ";" + l_Element.Commune + ";" + l_Element.Mail + ";" + l_Element.URL);
            }
            l_StreamWritter.Close();
        }

        /// <summary>
        /// Permet d'enregistrer une entreprise à partir d'une chaîne au format CSV
        /// </summary>
        /// <param name="pChaineCSV">Chaine au format CSV permettant d'initialiser l'objet entreprise</param>
        public override Cls_Entreprise CreationEntreprise(string pChaineCSV)
        {
            string[] l_tabInfosSTR = pChaineCSV.Split(';');
            int ID = int.Parse(l_tabInfosSTR[0]);
            string RaisonSociale = l_tabInfosSTR[1];
            string CodePostal = l_tabInfosSTR[2];
            string Commune = l_tabInfosSTR[3];
            string Mail = l_tabInfosSTR[4];
            string URL = l_tabInfosSTR[5];

            return new Cls_Entreprise(ID, RaisonSociale, CodePostal, Commune, Mail, URL);
        }

        /// <summary>
        /// Permet de lire le CSV des entreprises et de les transformer en objet
        /// </summary>
        public override Dictionary<int, Cls_Entreprise> LireEntrepriseCSV()
        {
            Dictionary<int, Cls_Entreprise> l_DicEntreprise = new();
            using (StreamReader l_StreamReader = new("Entreprises.csv"))
            {
                string? l_Ligne = l_StreamReader.ReadLine();

                while (l_Ligne != null)
                {
                    Cls_Entreprise l_Entreprise = CreationEntreprise(l_Ligne);
                    l_DicEntreprise.Add(l_Entreprise.ID, l_Entreprise);
                    l_Ligne = l_StreamReader.ReadLine();
                }
                l_StreamReader.Close();
            }
            return l_DicEntreprise;
        }
    }
}
