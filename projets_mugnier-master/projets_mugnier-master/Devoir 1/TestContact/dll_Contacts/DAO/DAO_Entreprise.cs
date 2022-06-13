using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Contacts
{
    public class DAO_Entreprise
    {
        public static void EnregistreEntreprise(cls_Entreprise[] ptabEntreprises)
        {

            StreamWriter sw = new StreamWriter("Entreprises.csv");

            foreach(cls_Entreprise l_Element in ptabEntreprises)
            {
               sw.WriteLine(l_Element.ID + ";" + l_Element.RaisonSociale + ";" + l_Element.Mail);
            }
            sw.Close();
        }

        public static cls_Entreprise[] ChargerEntreprise()
        {
            List<cls_Entreprise> l_lstEntreprise = new List<cls_Entreprise>();
            using(StreamReader l_StreamReader = new StreamReader("Entreprises.csv"))
            {
                string l_Ligne = l_Ligne = l_StreamReader.ReadLine();

                while(l_Ligne != null)
                {
                    cls_Entreprise l_Enreprise = CreEntreprise(l_Ligne);
                    l_lstEntreprise.Add(l_Enreprise);
                    l_Ligne = l_StreamReader.ReadLine();
                }
            }
            return l_lstEntreprise.ToArray();
        }

        /// <summary>
        /// Constructeur qui permet d'initialiser une entreprise à partir d'une chaine au format CSV
        /// </summary>
        /// <param name="pChaineCSV">Chaine au format CSV permettant d'initialiser l'objet entreprise</param>
        public static  cls_Entreprise CreEntreprise(string pChaineCSV)
        {
            //Récupération des informations contenues dans la chaine CSV
            string[] l_tabInfosSTR = pChaineCSV.Split(';');
            int l_ID = int.Parse(l_tabInfosSTR[0]);
            string l_RaisonSociale = l_tabInfosSTR[1];
            string l_AdresseMail = l_tabInfosSTR[2];
            return new cls_Entreprise(l_ID, l_RaisonSociale, l_AdresseMail);
        }

        

    }
}
