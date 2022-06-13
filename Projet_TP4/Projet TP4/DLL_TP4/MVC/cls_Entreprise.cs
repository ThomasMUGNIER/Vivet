using System.Text.RegularExpressions;

namespace DLL
{
    public class Cls_Entreprise:Cls_ID
    {
        private string? c_RaisonSociale;
        private string? c_CodePostal;
        private string? c_Commune;
        private string? c_Mail;
        private string? c_URL;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="pRaisonSociale"></param>
        /// <param name="pCodePostal"></param>
        /// <param name="pCommune"></param>
        /// <param name="pMail"></param>
        /// <param name="pURL"></param>
        public Cls_Entreprise(int pID, string pRaisonSociale, string pCodePostal, string pCommune, string pMail, string pURL):base(pID)
        {
            RaisonSociale = pRaisonSociale;
            CodePostal = pCodePostal;
            Commune = pCommune;
            Mail = pMail;
            URL = pURL;
        }

        /// <summary>
        /// Permet de red�finir la m�thode ToString de la classe cls_Entreprise
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return c_RaisonSociale + " - Code Postal : " + c_CodePostal;
        }

        /// <summary>
        /// Permet de d�finir et de r�cup�rer la raison sociale
        /// </summary>
        public string? RaisonSociale
        {
            get
            {
                return c_RaisonSociale;
            }

            set
            {
                if (value != null && value != "")
                {
                    c_RaisonSociale = value;
                }
                else
                {
                    throw new Exception("La raison sociale ne doit pas �tre null ou vide");
                }
            }
        }

        /// <summary>
        /// Permet de d�finir et de r�cup�rer le code postal
        /// </summary>
        public string? CodePostal
        {
            get
            {
                return c_CodePostal;
            }

            set
            {
                if (value != null && value != "")
                {
                    Regex regex = new(@"^[0-9]{3}00$");
                    Match match = regex.Match(Convert.ToString(value));
                    if (match.Success)
                    {
                        c_CodePostal = value;
                    }
                    else
                    {
                        throw new Exception("Le format du code postal n'est pas valide.");
                    }
                }
                else
                {
                    throw new Exception("La raison sociale ne doit pas �tre null ou vide");
                }
            }
        }

        /// <summary>
        /// Permet de d�finir et de r�cup�rer la commune
        /// </summary>
        public string? Commune
        {
            get
            {
                return c_Commune;
            }

            set
            {
                if (value != null && value != "")
                {
                    c_Commune = value;
                }
                else
                {
                    throw new Exception("La commune ne doit pas �tre null ou vide");
                }
            }
        }

        /// <summary>
        /// Permet de d�finir et de r�cup�rer l'adresse email
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
                    Regex regex = new(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
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
                    throw new Exception("L'adresse mail ne doit pas �tre null ou vide");
                }
            }
        }

        /// <summary>
        /// Permet de d�finir et de r�cup�rer l'URL
        /// </summary>
        public string? URL
        {
            get
            {
                return c_URL;
            }

            set
            {
                if (value != null && value != "")
                {
                    Regex regex = new(@"((www)\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)");
                    Match match = regex.Match(value);
                    if (match.Success)
                    {
                        c_URL = value;
                    }
                    else
                    {
                        throw new Exception("Le format de l'URL n'est pas valide.");
                    }
                }
                else
                {
                    throw new Exception("L'URL ne doit pas �tre null ou vide");
                }
            }
        }
    }
}