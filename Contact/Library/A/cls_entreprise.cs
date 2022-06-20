using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Library.B;
using Library.A;

namespace Library.A
{
    public class cls_entreprise : cls_ID
    {
        public string Raisonsociale;
        public string codepostale;
        public string Mail;
        public string commune;
        public string URLl;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="praisonsociale"></param>
        /// <param name="pcodepostale"></param>
        /// <param name="pcommune"></param>
        /// <param name="pmail"></param>
        /// <param name="pURL"></param>
        /// <param name="pID"></param>

        public cls_entreprise(int pID, string praisonsociale, string pcodepostale, string pmail, string pcommune, string pURL) : base(pID)
        {
            setmail(pmail);
            setURL(pURL);
            codepostale = pcodepostale;
            Mail = pmail;
            commune = pcommune;
            URLl = pURL;
            Raisonsociale = praisonsociale;
        }

        /// <summary>
        /// Permet de redéfinir la méthode ToString de la classe cls_Entreprise
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return raisonsociale;
        }

        /// <summary>
        /// Permet de definir et de retourner la commun
        /// </summary>
        /// 
        public string Commune
        {
            get { return commune; }
            set { commune = value; }
        }

        /// <summary>
        /// Permet de definir la raisonsociale
        /// </summary>
        public string raisonsociale
        {
            get { return Raisonsociale; }
            set
            {
                if (value != "" && value != null)
                {
                    Raisonsociale = value;
                }
                else
                {
                    throw new Exception("Le nom ne doit pas être vide ou null");
                }
            }
        }

        /// <summary>
        /// Permet de définir l'adresse mail
        /// </summary>
        public void setmail(string pmail)
        {
            if (pmail != "" && pmail != null)
            {
                Mail = pmail;
            }
            else
            {
                throw new Exception("L'adresse mail ne peut pas etre vide");
            }


        }

        /// <summary>
        /// Permet de définir l'URL
        /// </summary>
        public void setURL(string pURL)
        {
            if (pURL != "" && pURL != null)
            {
                URLl = pURL;
            }
            else
            {
                throw new Exception("L'URL ne peut pas etre vide");
            }


        }

        /// <summary>
        /// Permet de definir et de retourner le codepostale
        /// </summary>
        public string Codepostale
        {
            get
            {
                return codepostale;
            }

            set
            {
                Regex regex = new Regex(@"^[0-9]{5}$");
                Match match = regex.Match(Convert.ToString(value));
                if (match.Success)
                {
                    codepostale = value;
                }
                else
                {
                    throw new Exception("Le format du code postal n'est pas valide.");
                }
            }
        }
        /// <summary>
        /// Permet de retourner le mail
        /// </summary>
        public string mail
        {
            get { return Mail; }
        }

        /// <summary>
        /// Permet de retourner l'URL
        /// </summary>
        public string URL
        {
            get { return URLl; }
        }

    }
}