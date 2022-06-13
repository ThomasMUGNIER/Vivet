using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_Contacts.Modele;
using dll_Contacts.DAO;

namespace dll_Contacts
{
    public class cls_Contact:cls_ID
    {
        private string c_Nom;
        private string c_Prenom;
        private cls_Entreprise? c_Entreprise;

        public cls_Contact(int pID,string pNom, string pPrenom,cls_Entreprise? pEntreprise):base(pID)
        {
            setNom(pNom);
            c_Prenom = pPrenom;
            c_Entreprise = pEntreprise;
        }

        public override string ToString()
        {
            return getNom() + " " + Prenom;
        }

        public cls_Entreprise? Entreprise
        {
            get { return c_Entreprise; }
            set { c_Entreprise = value; }
        }

        public string Prenom
        {
            get { return c_Prenom; }
            set { c_Prenom = value; }
        }

        public void setNom(string pNom)
        {
            if(pNom!=null && pNom!="")
            {
                c_Nom = pNom;
            }
            else
            {
                throw new Exception("Le nom ne doit pas être null ou vide");
            }

        }

        public string getNom()
        {
            return c_Nom;
        }




    }
}
