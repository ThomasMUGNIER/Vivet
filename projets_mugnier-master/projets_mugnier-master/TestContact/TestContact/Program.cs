using System;
using System.Collections.Generic;
using System.IO;
using dll_Contacts;

namespace TestContact
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            cls_Contact[] l_tabContacts = new cls_Contact[200];
            cls_Entreprise[] l_tabEntreprise = new cls_Entreprise[50];

            l_tabEntreprise = cls_Test.GenereEntreprises();

            DAO_Entreprise.EnregistreEntreprise(l_tabEntreprise);

            l_tabEntreprise = DAO_Entreprise.ChargerEntreprise();

            cls_Test.CreContact(l_tabContacts, l_tabEntreprise);

            DAO_Contact.EnregistreContact(l_tabContacts);
            

            Console.ReadLine();
        }

 

    

       

     


    }
}
