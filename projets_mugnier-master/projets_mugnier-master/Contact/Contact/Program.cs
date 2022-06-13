using System;
using System.IO;
using System.Collections.Generic;
using Library.B;
using Library.A;

namespace Contact
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Créer les entreprises et contacts et remplir leur fichier CSV respectif
            Cls_DAO_Entreprise c_DAO_entreprise = new Cls_DAO_Entreprise();
            Cls_DAO_Contact c_DAO_contact = new Cls_DAO_Contact();

            /* cls_DAO_entreprise.save_entreprise_CSV(l_tab_entreprise);
             cls_DAO_contact.save_contact_CSV(l_tab_contact, l_tab_entreprise);

             // Charge les entreprises et contacts à partir du fichier CSV
             cls_entreprise[] l_tab_entreprises = cls_DAO_entreprise.lire_entreprise_CSV();
             cls_contact[] l_tab_contacts = cls_DAO_contact.lire_contact_CSV(l_tab_entreprises);

             for (int i = 0; i < l_tab_entreprises.GetLength(0); i++)
             {
                 Console.WriteLine(l_tab_entreprises[i].ToString());
             }

             for (int i = 0; i < l_tab_contact.GetLength(0); i++)
             {
                 Console.WriteLine(l_tab_contact[i].ToString());
                 Console.WriteLine(l_tab_contact[i].entreprise);
             }*/
        }
    }
}