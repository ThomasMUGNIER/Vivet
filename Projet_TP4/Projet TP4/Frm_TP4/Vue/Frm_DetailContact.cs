using DLL;

namespace Frm_TP4
{
    public partial class Frm_DetailContact : Form
    {
        Cls_Contact? c_Contact;
        readonly Frm_TP4 c_Frm_TP4;

        /// <summary>
        /// Initialise le contact
        /// </summary>
        /// <param name="pContact"></param>
        /// <param name="p_Frm_TP4"></param>
        public Frm_DetailContact(Cls_Contact? pContact, Frm_TP4 p_Frm_TP4)
        {
            InitializeComponent();

            c_Contact = pContact;
            c_Frm_TP4 = p_Frm_TP4;

            List<Cls_Entreprise> l_ListEntreprises = c_Frm_TP4.ListeEntreprises;

            cbx_Entreprise.Items.AddRange(l_ListEntreprises.ToArray());

            if(c_Contact != null)
            {
                txb_Nom.Text = c_Contact.Nom;
                txb_Prenom.Text = c_Contact.Prenom;
                dtp_DateDeNaissance.Text = Convert.ToString(c_Contact.DateDeNaissance);
                txb_Adresse.Text = c_Contact.Adresse;
                txb_Mail.Text = c_Contact.Mail;
                txb_Telephone.Text = Convert.ToString(c_Contact.Telephone);
                if (c_Contact.Entreprise != null)
                {
                    cbx_Entreprise.Text = c_Contact.Entreprise.ToString();
                }
            }
        }

        /// <summary>
        /// Permet de valider les modifications ou la création
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DetailContactValidation_Click_1(object sender, EventArgs e)
        {
            string Nom = txb_Nom.Text;
            string Prenom = txb_Prenom.Text;
            DateTime DateDeNaissance = Convert.ToDateTime(dtp_DateDeNaissance.Text);
            string Adresse = txb_Adresse.Text;
            string Mail = txb_Mail.Text;
            string Telephone = txb_Telephone.Text;

            Cls_Entreprise Entreprise = (Cls_Entreprise)cbx_Entreprise.SelectedItem;

            if (c_Contact == null)
            {
                c_Contact = new Cls_Contact(Cls_ID.NouvelID(), Nom, Prenom, DateDeNaissance, Adresse, Mail, Telephone, Entreprise);

                List<Cls_Contact> l_ListContacts = c_Frm_TP4.ListeContacts;
                l_ListContacts.Add(c_Contact);
            }
            else
            {
                c_Contact.Nom = Nom;
                c_Contact.Prenom = Prenom;
                c_Contact.DateDeNaissance = DateDeNaissance;
                c_Contact.Adresse = txb_Adresse.Text;
                c_Contact.Mail = txb_Mail.Text;
                c_Contact.Telephone = txb_Telephone.Text;
                if (cbx_Entreprise.SelectedItem != null)
                {
                    c_Contact.Entreprise = (Cls_Entreprise)cbx_Entreprise.SelectedItem;
                }
            }

            // Pour mettre à jour automatiquement les modifications ou la création de contact
            c_Frm_TP4.ExporterContacts();
            c_Frm_TP4.ImporterContacts();

            Close();
        }

        /// <summary>
        /// Permet d'enregistrer les modifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Btn_DetailContactAnnulation_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
