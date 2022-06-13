using DLL;

namespace Frm_TP4
{
    public partial class Frm_TP4 : Form
    {
        private Dictionary<int, Cls_Entreprise> c_DicEntreprise;
        private Dictionary<int, Cls_Contact> c_DicContact;
        Cls_DAO_Entreprise c_DAOEntreprise = new Cls_DAO_Entreprise();
        Cls_DAO_Contact c_DAOContact = new Cls_DAO_Contact();

        /// <summary>
        /// Initialise les composants
        /// </summary>
        public Frm_TP4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permet de récupérer la liste des entreprises
        /// </summary>
        public List<Cls_Entreprise> ListeEntreprises
        {
            get { return c_DicEntreprise.Values.ToList(); }
        }

        /// <summary>
        /// Permet de récupérer la liste des contacts
        /// </summary>
        public List<Cls_Contact> ListeContacts
        {
            get { return c_DicContact.Values.ToList(); }
        }

        /// <summary>
        /// Gère le chargement en mémoire des entreprises et des contacts, puis les affiche dans leurs listBox respectives
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_TP4_Load(object sender, EventArgs e)
        {
            // Permet d'afficher la date et l'heure dans le ToolStripStatus
            tss_FrmTP4.Text = DateTime.Now.ToLongDateString();

            // Permet de gérer le nom des onglets
            tabPage1.Text = "Contacts";
            tabPage2.Text = "Entreprises";


            // Permet de créer les entreprises et les contacts et de les enregistrer dans un fichier CSV
            /*c_DicEntreprise = c_DAOEntreprise.CreerEntreprise();
            c_DAOEntreprise.EnregistreEntrepriseCSV(c_DicEntreprise.Values.ToList());
            c_DicContact = c_DAOContact.CreerContact(c_DicEntreprise.Values.ToList());
            c_DAOContact.EnregistreContactCSV(c_DicContact.Values.ToList());*/

            // Permet de générer les entreprises à partir d'un fichier au format CSV
            c_DicEntreprise = c_DAOEntreprise.LireEntrepriseCSV();

            // Permet d'ajouter les entreprises générées à la liste de l'application
            lst_Entreprises.Items.AddRange(c_DicEntreprise.Values.ToArray());

            // Permet de générer les contacts à partir d'un fichier au format CSV
            c_DicContact = c_DAOContact.LireContactCSV(c_DicEntreprise.Values.ToList());

            // Permet d'ajouter les contacts générées à la liste de l'application
            lst_Contacts.Items.AddRange(c_DicContact.Values.ToArray());
        }

        /// <summary>
        /// Permet d'ajouter une entreprise à la liste des entreprises
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AddEntreprise_Click(object sender, EventArgs e)
        {
            Frm_DetailEntreprise l_FrmDetailEntreprise = new(null, this);

            l_FrmDetailEntreprise.ShowDialog();
        }

        /// <summary>
        /// Ouvre la modification des entreprises
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lst_Entreprises_DoubleClick(object sender, EventArgs e)
        {
            Cls_Entreprise l_EntrepriseSelect = (Cls_Entreprise)lst_Entreprises.SelectedItem;

            Frm_DetailEntreprise l_Frm_DetailEntreprise = new(l_EntrepriseSelect, this);

            l_Frm_DetailEntreprise.ShowDialog();
        }

        /// <summary>
        /// Permet de supprimer une entreprise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DelEntreprise_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer l'entreprise sélectionnée ?", "Supprimer entreprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result.Equals(DialogResult.Yes))
            {
                Cls_Entreprise l_Entreprise = (Cls_Entreprise)lst_Entreprises.SelectedItem;

                for(int i = 0; i < lst_Contacts.Items.Count; i++)
                {
                    lst_Contacts.SetSelected(i, true);
                    Cls_Contact l_Contact = (Cls_Contact)lst_Contacts.SelectedItem;
                    if(l_Contact.Entreprise != null)
                    {
                        if (l_Contact.Entreprise.ID == l_Entreprise.ID)
                        {
                            l_Contact.Entreprise = null;
                        }
                    }
                }

                lst_Entreprises.Items.Remove(lst_Entreprises.SelectedItem);

                // Met à jour automatiquement les listes
                ExporterEntreprises();
                ExporterContacts();

                ImporterEntreprises();
                ImporterContacts();
            }
        }

        /// <summary>
        /// Permet d'importer la liste des entreprises à partir d'un fichier CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBtn_Importer_Entreprises_Click_1(object sender, EventArgs e)
        {
            ImporterEntreprises();

            // Affiche une alerte
            MessageBox.Show("Entreprises importées avec succès");
        }

        /// <summary>
        /// Permet d'exporter la liste des entreprises en format CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBtn_Exporter_Entreprises_Click(object sender, EventArgs e)
        {
            ExporterEntreprises();

            // Affiche une alerte
            MessageBox.Show("Entreprises exportées avec succès");
        }

        /// <summary>
        /// Permet d'ajouter un nouveau contact à la liste des contacts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AddContact_Click(object sender, EventArgs e)
        {
            Frm_DetailContact l_FrmDetailContact = new(null, this);

            l_FrmDetailContact.ShowDialog();
        }

        /// <summary>
        /// Permet de supprimer un contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DelContact_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer le contact sélectionné ?", "Supprimer contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result.Equals(DialogResult.Yes))
            {
                lst_Contacts.Items.Remove(lst_Contacts.SelectedItem);
            }
        }

        /// <summary>
        /// Permet d'importer la liste des contacts à partir d'un fichier CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBtn_Importer_Contacts_Click(object sender, EventArgs e)
        {
            ImporterContacts();

            // Affiche une alerte
            MessageBox.Show("Contacts importés avec succès");
        }

        /// <summary>
        /// Permet d'exporter la liste des contacts en format CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBtn_Exporter_Contacts_Click(object sender, EventArgs e)
        {
            ExporterContacts();

            // Affiche une alerte
            MessageBox.Show("Contacts exportés avec succès");
        }

        /// <summary>
        /// Ouvre la modification des contacts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lst_Contacts_DoubleClick(object sender, EventArgs e)
        {
            Cls_Contact l_ContactSelect = (Cls_Contact)lst_Contacts.SelectedItem;

            Frm_DetailContact l_Frm_DetailContact = new(l_ContactSelect, this);

            l_Frm_DetailContact.ShowDialog();
        }

        /// <summary>
        /// Permet de quitter l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBtn_Fichier_Quitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Procédure pour importer les entreprises
        /// </summary>
        public void ImporterEntreprises()
        {
            // Permet de supprimer la liste précédente des entreprises
            lst_Entreprises.Items.Clear();

            // Permet de générer les entreprises à partir d'un fichier au format CSV
            c_DicEntreprise = c_DAOEntreprise.LireEntrepriseCSV();

            // Permet d'ajouter les entreprises générées à la liste de l'application
            lst_Entreprises.Items.AddRange(c_DicEntreprise.Values.ToArray());

            // Renvoie sur le bon onglet
            tab_Control.SelectedIndex = 1;
        }

        /// <summary>
        /// Procédure pour exporter les entreprises
        /// </summary>
        public void ExporterEntreprises()
        {
            // Permet de récupérer la liste des entreprises sous forme d'un tableau
            lst_Entreprises.Items.CopyTo(c_DicEntreprise.Values.ToArray(), 0);

            // Enregistre les entreprises dans un fichier CSV
            c_DAOEntreprise.EnregistreEntrepriseCSV(c_DicEntreprise.Values.ToList());

            // Renvoie sur le bon onglet
            tab_Control.SelectedIndex = 1;
        }

        /// <summary>
        /// Procédure pour importer les contacts
        /// </summary>
        public void ImporterContacts()
        {
            // Permet de supprimer la liste précédente des contacts
            lst_Contacts.Items.Clear();

            // Permet de générer les contact à partir d'un fichier au format CSV
            c_DicEntreprise = c_DAOEntreprise.LireEntrepriseCSV();
            c_DicContact = c_DAOContact.LireContactCSV(c_DicEntreprise.Values.ToList());

            // Permet d'ajouter les entreprises générées à la liste de l'application
            lst_Contacts.Items.AddRange(c_DicContact.Values.ToArray());

            // Renvoie sur le bon onglet
            tab_Control.SelectedIndex = 0;
        }

        /// <summary>
        /// Procédure pour exporter les contacts
        /// </summary>
        public void ExporterContacts()
        {
            // Permet de récupérer la liste des entreprises sous forme d'un tableau
            lst_Entreprises.Items.CopyTo(c_DicEntreprise.Values.ToArray(), 0);
            lst_Contacts.Items.CopyTo(c_DicContact.Values.ToArray(), 0);

            // Enregistre les contacts dans un fichier CSV
            c_DAOContact.EnregistreContactCSV(c_DicContact.Values.ToList());

            // Renvoie sur le bon onglet
            tab_Control.SelectedIndex = 0;
        }
    }
}