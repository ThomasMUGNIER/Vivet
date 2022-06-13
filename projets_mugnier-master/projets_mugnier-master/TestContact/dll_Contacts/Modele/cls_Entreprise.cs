using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Contacts
{
    /// <summary>
    /// Classe qui contient les données d'une entreprise
    /// </summary>
    public class cls_Entreprise:cls_ID
    {
        private string c_RaisonSociale;
        private string c_AdresseMail;

        /// <summary>
        /// Constructeur le la classe entreprise
        /// </summary>
        /// <param name="pRaisonSociale">Raison sociale de l'entreprise</param>
        public cls_Entreprise(int pID,string pRaisonSociale,string pAdresseMail):base(pID)
        {
            this.RaisonSociale = pRaisonSociale;
            c_AdresseMail = pAdresseMail;
        }

        public override string ToString()
        {
            return c_RaisonSociale ;
        }

        /// <summary>
        /// Propriété qui permet de lire ou de modifier la raison sociale
        /// </summary>
        public string RaisonSociale
        {
            get { return c_RaisonSociale; }

            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("La raison sociale d'une entreprise ne peut être ni vide ni nulle");
                }
                else
                {
                    c_RaisonSociale = value;
                }
            }
        }

        public string Mail
        {
            get { return c_AdresseMail; }
            set { c_AdresseMail = value; }
        }



    }
}
