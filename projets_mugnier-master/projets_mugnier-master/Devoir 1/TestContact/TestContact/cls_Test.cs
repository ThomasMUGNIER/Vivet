using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_Contacts;
using dll_Contacts.Modele;
using dll_Contacts.DAO;

namespace TestContact
{
    public class cls_Test
    {

           public static cls_Entreprise[] GenereEntreprises()
        {
            cls_Entreprise[] l_tabEntreprises = new cls_Entreprise[50];
            for(int i = 0; i < 50; i++)
            {
                l_tabEntreprises[i] = new cls_Entreprise(i + 1, "Raison sociale " + (i + 1), "mail " + (i + 1));
            }
            return l_tabEntreprises;
        }

        public static void CreContact(cls_Contact[] ptabContacts, cls_Entreprise[] ptabEntreprise)
        {
            Random l_Rnd = new Random();

            for(int i = 0; i < ptabContacts.Length; i++)
            {
                int l_IndiceEntreprise = l_Rnd.Next(0, 75);
                cls_Entreprise l_Entreprise = null;
                if(l_IndiceEntreprise < 50)
                {
                    l_Entreprise = ptabEntreprise[l_IndiceEntreprise];
                }
                ptabContacts[i] = new cls_Contact(i,"Nom " + (i + 1), "Prenom " + (i + 1), l_Entreprise);
            }

        }

        public static void CreProjet()
        {
           cls_Projet[] l_tabProjet = DAO_Projet.cree_Projet();
        }

    }
}
