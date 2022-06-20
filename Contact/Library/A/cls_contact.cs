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
    public class cls_contact : cls_ID
    {
        public string? Nom;
        public string? Prenom;
        public string? Phone;
        public string? Mail;
        public DateTime Datedenaissance;
        public string? Adresse;
        public int Age;
        public cls_entreprise? entreprise;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="pnom"></param>
        /// <param name="pprenom"></param>
        /// <param name="pdatedenaissance"></param>
        /// <param name="padresse"></param>
        /// <param name="pmail"></param>
        /// <param name="pphone"></param>
        public cls_contact(string pnom, string pprenom, DateTime pdatedenaissance, string padresse, string pmail, string pphone, int pID, cls_entreprise? p_entreprise) : base(pID)
        {
            Nom = pnom;
            Prenom = pprenom;
            Datedenaissance = pdatedenaissance;
            Adresse = padresse;
            Mail = pmail;
            Phone = pphone;
        }

        /// <summary>
        /// Permet de redéfinir la méthode ToString de la classe cls_Entreprise
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return nom + " " + prenom;
        }
        public string adresse
        {
            get { return Adresse; }
            set { Adresse = value; }
        }

        /// <summary>
        /// Permet de définir et de récupérer la date de naissance
        /// </summary>
        public DateTime datedenaissance
        {
            get { return Datedenaissance; }
            set { Datedenaissance = value; }
        }

        /// <summary>
        /// Permet de définir et de récupérer le nom
        /// </summary>
        public void setnom(string pnom)
        {
            if (pnom != "" && pnom != null)
            {
                Nom = pnom;
            }
            else
            {
                throw new Exception("Le nom ne peut pas etre vide");
            }

        }
 
        /// <summary>
        /// Permet de définir et de récupérer le téléphone
        /// </summary>
        public string? phone
        {
            get
            {
                return Phone;
            }

            set
            {
                if (value != null)
                {
                    Regex regex = new(@"^\(?([0-7])\)?[-. ]?([0-9]{9})$");
                    Match match = regex.Match(Convert.ToString(value));
                    if (match.Success)
                    {
                        phone = value;
                    }
                    else
                    {
                        throw new Exception("Le format du numéro de téléphone n'est pas valide.");
                    }
                }
                else
                {
                    throw new Exception("Le numéro de téléphone ne doit pas être null ou vide");
                }
            }
        }
        /// <summary>
        /// Permet de définir et de récupérer l'adresse email
        /// </summary>
        public string mail
        {
            get { return Mail; }

            set
            {
                Regex regex = new Regex(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$");
                Match match = regex.Match(value);
                if (match.Success)
                {
                    Mail = value;
                }
                else
                {
                    throw new Exception("Le format de l'adresse mail n'est pas valide.");
                }
            }
        }
        /// <summary>
        /// Permet de définir l'âge et de récupérer l'age
        /// </summary>
        public int age
        {

            get { return Age; }

            set
            {
                if (datedenaissance.Month <= DateTime.Now.Month)
                {
                    if (datedenaissance.Day <= DateTime.Now.Day)
                    {
                        Age = Convert.ToInt32(DateTime.Now.Year - datedenaissance.Year);
                    }
                    else
                    {
                        Age = Convert.ToInt32(DateTime.Now.Year - datedenaissance.Year) - 1;
                    }
                }
                else
                {
                    Age = Convert.ToInt32(DateTime.Now.Year - datedenaissance.Year) - 1;
                }
            }
        }
        /// <summary>
        /// Permet de récupérer le nom
        /// </summary>
        public string nom
        {
            get { return Nom; }
        }

        /// <summary>
        /// Permet de définir et de récupérer le prénom
        /// </summary>

        public string prenom
        {
            get { return Prenom; }
        }
        /// <summary>
        /// Permet de définir et de récupérer l'entreprise
        /// </summary>
        public cls_entreprise? c_entreprise
        {
            get { return entreprise; }
            set { entreprise = value; }
        }
    }
}
