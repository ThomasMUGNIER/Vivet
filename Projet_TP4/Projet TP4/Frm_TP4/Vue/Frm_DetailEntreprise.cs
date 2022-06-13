using DLL;

namespace Frm_TP4
{
    public partial class Frm_DetailEntreprise : Form
    {
        Cls_Entreprise? c_Entreprise;
        readonly Frm_TP4 c_Frm_TP4;

        /// <summary>
        /// Initialise le composant et affiche les informations de l'entreprise
        /// </summary>
        /// <param name="pEntreprise"></param>
        public Frm_DetailEntreprise(Cls_Entreprise? pEntreprise, Frm_TP4 p_Frm_TP4)
        {
            InitializeComponent();

            c_Frm_TP4 = p_Frm_TP4;

            c_Entreprise = pEntreprise;

            if(c_Entreprise != null)
            {
                txb_RaisonSociale.Text = c_Entreprise.RaisonSociale;
                txb_CodePostal.Text = c_Entreprise.CodePostal;
                txb_Commune.Text = c_Entreprise.Commune;
                txb_Mail.Text = c_Entreprise.Mail;
                txb_URL.Text = c_Entreprise.URL;
            }
        }

        /// <summary>
        /// Permet d'enregistrer les modifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DetailEntrepriseValidation_Click(object sender, EventArgs e)
        {
            string RaisonSociale = txb_RaisonSociale.Text;
            string CodePostal = txb_CodePostal.Text;
            string Commune = txb_Commune.Text;
            string Mail = txb_Mail.Text;
            string URL = txb_URL.Text;

            if (c_Entreprise == null)
            {
                c_Entreprise = new Cls_Entreprise(Cls_ID.NouvelID(), RaisonSociale, CodePostal, Commune, Mail, URL);

                List<Cls_Entreprise> l_ListEntreprises = c_Frm_TP4.ListeEntreprises;
                l_ListEntreprises.Add(c_Entreprise);
            }
            else
            {
                c_Entreprise.RaisonSociale = RaisonSociale;
                c_Entreprise.CodePostal = CodePostal;
                c_Entreprise.Commune = Commune;
                c_Entreprise.Mail = Mail;
                c_Entreprise.URL = URL;
            }

            // Pour mettre à jour automatiquement les modifications ou la création d'entreprise
            c_Frm_TP4.ExporterEntreprises();
            c_Frm_TP4.ImporterEntreprises();

            Close();
        }

        /// <summary>
        /// Permet d'annuler la modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DetailEntrepriseAnnulation_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
