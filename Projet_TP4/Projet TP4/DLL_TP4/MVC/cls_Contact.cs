using System.Text.RegularExpressions;

namespace DLL
{
    public class Cls_Contact:Cls_ID
    {
        private string? c_Nom;
        private string? c_Prenom;
        private DateTime c_DateDeNaissance;
        private string? c_Adresse;
        private string? c_Mail;
        private string? c_Telephone;
        private Cls_Entreprise? c_Entreprise;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="pNom"></param>
        /// <param name="pPrenom"></param>
        /// <param name="pDateDeNaissance"></param>
        /// <param name="pAdresse"></param>
        /// <param name="pMail"></param>
        /// <param name="pTelephone"></param>
        /// <param name="pEntreprise"></param>
        public Cls_Contact(int pID, string pNom, string pPrenom, DateTime pDateDeNaissance, string pAdresse, string pMail, string pTelephone, Cls_Entreprise? pEntreprise) : base(pID)
        {
            Nom = pNom;
            Prenom = pPrenom;
            DateDeNaissance = pDateDeNaissance;
            Adresse = pAdresse;
            Mail = pMail;
            Telephone = pTelephone;
            Entreprise = pEntreprise;
        }

        /// <summary>
        /// Permet de redéfinir la méthode ToString de la classe cls_Entreprise
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if(c_Entreprise != null)
            {
                return c_Nom + " " + c_Prenom + " - Né(e) le " + c_DateDeNaissance.ToString("dd/MM/yyyy") + " - " + c_Entreprise.RaisonSociale;
            }
            else
            {
                return c_Nom + " " + c_Prenom + " - Né(e) le " + c_DateDeNaissance.ToString("dd/MM/yyyy");
            }
        }

        /// <summary>
        /// Permet de définir et de récupérer le nom
        /// </summary>
        public string? Nom
        {
            get
            {
                return c_Nom;
            }

            set
            {
                if (value != null && value != "")
                {
                    c_Nom = value;
                }
                else
                {
                    throw new Exception("Le nom ne doit pas être null ou vide");
                }
            }
        }

        /// <summary>
        /// Permet de définir et de récupérer le prénom
        /// </summary>
        public string? Prenom
        {
            get
            {
                return c_Prenom;
            }

            set
            {
                if (value != null && value != "")
                {
                    c_Prenom = value;
                }
                else
                {
                    throw new Exception("Le prénom ne doit pas être null ou vide");
                }
            }
        }

        /// <summary>
        /// Permet de définir et de récupérer la date de naissance
        /// </summary>
        public DateTime DateDeNaissance
        {
            get
            {
                return c_DateDeNaissance;
            }

            set
            {
                c_DateDeNaissance = value;
            }
        }

        public string? Adresse
        {
            get
            {
                return c_Adresse;
            }

            set
            {
                if (value != null && value != "")
                {
                    c_Adresse = value;
                }
                else
                {
                    throw new Exception("L'adresse ne doit pas être null ou vide");
                }
            }
        }

        /// <summary>
        /// Permet de définir et de récupérer l'adresse email
        /// </summary>
        public string? Mail
        {
            get
            {
                return c_Mail;
            }

            set
            {
                if (value != null && value != "")
                {
                    Regex regex = new(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$");
                    Match match = regex.Match(value);
                    if (match.Success)
                    {
                        c_Mail = value;
                    }
                    else
                    {
                        throw new Exception("Le format de l'adresse mail n'est pas valide.");
                    }
                }
                else
                {
                    throw new Exception("L'adresse ne doit pas être null ou vide");
                }
            }
        }

        /// <summary>
        /// Permet de définir et de récupérer le téléphone
        /// </summary>
        public string? Telephone
        {
            get
            {
                return c_Telephone;
            }

            set
            {
                if (value != null)
                {
                    Regex regex = new(@"^\(?([0-7])\)?[-. ]?([0-9]{9})$");
                    Match match = regex.Match(Convert.ToString(value));
                    if (match.Success)
                    {
                        c_Telephone = value;
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
        /// Permet d'instancier une entreprise
        /// </summary>
        public Cls_Entreprise? Entreprise
        {
            get
            {
                return c_Entreprise;
            }

            set
            {
                c_Entreprise = value;
            }
        }
    }
}