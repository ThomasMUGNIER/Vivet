using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_Contacts.Modele;
using dll_Contacts.DAO;

namespace dll_Contacts.Modele
{
    public class cls_Projet :cls_ID
    {
        cls_Entreprise? Entreprise;
        public string? c_Sociale;
        public int Postale;

        /// <summary>
        /// Constructeur le la classe entreprise
        /// </summary>
        /// <param name="pSociale"></param>
        /// /// <param name="pID"></param>
        /// /// <param name="pPostale"></param>
        public cls_Projet(int pID, string pSociale, int pPostale) : base(pID)
        {
            c_Sociale = pSociale;
            Postale = pPostale;
        }
        /// <summary>
        /// Propriété qui permet de lire ou de modifier la raison sociale
        /// </summary>
        public string sociale
        {
            get { return c_Sociale; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("La raison sociale d'une entreprise ne peut être ni vide ni nulle");
                }
                else
                {
                    c_Sociale = value;
                }
            }
        }
        public cls_Entreprise? entreprise
        {
            get { return Entreprise; }
            set { Entreprise = value; }
        }


        public int postale
        {
            get { return Postale; }
            set { Postale = value; }
        }
    }
    }
