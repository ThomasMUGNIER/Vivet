using System;
using System.Collections.Generic;
using System.Linq;
using DLL;

namespace POO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cls_DAO_Entreprise c_DAOEntreprise = new Cls_DAO_Entreprise();
            Cls_DAO_Contact c_DAOContact = new Cls_DAO_Contact();

            // Créer les entreprises et contacts et remplir leur fichier CSV respectif
            /*Dictionary<int, Cls_Entreprise> l_DicEntreprise = c_DAOEntreprise.CreerEntreprise();
            Dictionary<int, Cls_Contact> l_DicContact = c_DAOContact.CreerContact(l_DicEntreprise.Values.ToList());
            c_DAOEntreprise.EnregistreEntrepriseCSV(l_DicEntreprise.Values.ToList());
            c_DAOContact.EnregistreContactCSV(l_DicContact.Values.ToList());*/

            // Charge les entreprises et contacts à partir du fichier CSV
            Dictionary<int, Cls_Entreprise> l_DicEntreprise = c_DAOEntreprise.LireEntrepriseCSV();
            Dictionary<int, Cls_Contact> l_DicContact = c_DAOContact.LireContactCSV(l_DicEntreprise.Values.ToList());

            for(int i = 0; i < l_DicEntreprise.Count; i++)
            {
                Console.WriteLine(l_DicEntreprise[i].ToString());
            }

            for(int i = 0; i < l_DicContact.Count; i++)
            {
                Console.WriteLine(l_DicContact[i].ToString());
                Console.WriteLine(l_DicContact[i].Entreprise);
            }
        }
    }
}