using Library.B;
using Library.A;
using From.Vue;


namespace From
{
    public partial class Index : Form
    {

        private Dictionary<int, cls_entreprise> c_dic_entreprise;
        private Dictionary<int, cls_contact> c_dic_contact;
        Cls_DAO_Entreprise c_DAO_entreprise = new Cls_DAO_Entreprise();
        Cls_DAO_Contact c_DAO_contact = new Cls_DAO_Contact();
        public Index()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permet de récupérer la liste des entreprises
        /// </summary>
        public List<cls_entreprise> list_entreprises
        {
            get { return c_dic_entreprise.Values.ToList(); }
        }

        /// <summary>
        /// Permet de récupérer la liste des contacts
        /// </summary>
        public List<cls_contact> list_contacts
        {
            get { return c_dic_contact.Values.ToList(); }
        }

        /// <summary>
        /// Gère le chargement en mémoire des entreprises et des contacts, puis les affiche dans leurs listBox respectives
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

            cls_entreprise[] l_tab_entreprise = cls_DAO_entreprise.lire_entreprise_CSV();
            list_entreprise.Items.AddRange(l_tab_entreprise);
            cls_contact[] l_tab_contact = cls_DAO_contact.lire_contact_CSV(l_tab_entreprise);
            list_contact.Items.AddRange(l_tab_contact);
        }
        /// <summary>
        /// Permet d'ouvrir detail_entreprise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void list_entreprise_DoubleClick(object sender, EventArgs e)
        {
            cls_entreprise l_entreprise_select = (cls_entreprise)list_entreprise.SelectedItem;
            detail_entreprise l_detail_entreprise = new detail_entreprise(l_entreprise_select);
            l_detail_entreprise.ShowDialog();


        }

        /// <summary>
        /// Permet d'ajouter une entreprise à la liste des entreprises
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void entrepriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cls_entreprise Entreprise = new cls_entreprise((list_entreprise.Items.Count + 1), "Raison Sociale " + (list_entreprise.Items.Count + 1), cls_DAO_entreprise.codepostalealeatoire(), "Commune " + (list_entreprise.Items.Count + 1), "mail." + (list_contact.Items.Count + 1) + "@gmail.com", "www.URL" + (list_entreprise.Items.Count + 1) + ".fr");
            list_entreprise.Items.Add(Entreprise);
        }

        /// <summary>
        /// Permet d'importer la liste des entreprises à partir d'un fichier CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void entrepriseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ImporterEntreprises();

            // Affiche une alerte
            MessageBox.Show("Entreprises importées avec succès");
        }
        /// <summary>
        /// Permet sauvegarder une entreprise à la liste des entreprises
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void entrepriseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ExporterEntreprises();

            // Affiche une alerte
            MessageBox.Show("Contacts exportés avec succès");

        }

        /// <summary>
        /// Permet de quitter la fênetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Permet d'ajouter un nouveau contact à la liste des contacts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detail_contact l_FrmDetailContact = new(null, this);

            l_FrmDetailContact.ShowDialog();
        }

        /// <summary>
        /// Permet de retourner le c-tab_entreprise
        /// </summary>
        public cls_entreprise[]? List_entreprise
        {
            get { return l_tab_entreprise; }
        }

        /// <summary>
        /// Permet d'ouvrir detail contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void list_contact_DoubleClick(object sender, EventArgs e)
        {
            cls_contact l_contact_select = (cls_contact)list_contact.SelectedItem;
            detail_contact l_detail_contact = new(l_contact_select, this);
            l_detail_contact.ShowDialog();

        }

        /// <summary>
        /// Permet d'importer a partir d'un fichier CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contactToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ImporterContacts();

            // Affiche une alerte
            MessageBox.Show("Contacts importés avec succès");
        }

        /// <summary>
        /// Permet de savegarder les contacts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contactToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ExporterContacts();

            // Affiche une alerte
            MessageBox.Show("Contacts exportés avec succès");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detail_contact l_detail_contact = new(null, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer le contact sélectionné ?", "Supprimer contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result.Equals(DialogResult.Yes))
            {
                list_contact.Items.Remove(list_contact.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            detail_entreprise l_FrmDetailEntreprise = new(null, this);

            l_FrmDetailEntreprise.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer l'entreprise sélectionnée ?", "Supprimer entreprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result.Equals(DialogResult.Yes))
            {
                cls_entreprise l_Entreprise = (cls_entreprise)list_entreprise.SelectedItem;

                for (int i = 0; i < list_contact.Items.Count; i++)
                {
                    list_contact.SetSelected(i, true);
                    cls_contact l_Contact = (cls_contact)list_contact.SelectedItem;
                    if (l_Contact.entreprise != null)
                    {
                        if (l_Contact.entreprise.ID == l_Entreprise.ID)
                        {
                            l_Contact.entreprise = null;
                        }
                    }
                }

                list_entreprise.Items.Remove(list_entreprise.SelectedItem);
            }
        }

        /// <summary>
        /// Procédure pour importer les entreprises
        /// </summary>
        public void ImporterEntreprises()
        {
            // Permet de supprimer la liste précédente des entreprises
            list_entreprise.Items.Clear();

            // Permet de générer les entreprises à partir d'un fichier au format CSV
            c_dic_entreprise = c_DAO_entreprise.lire_entreprise_CSV();

            // Permet d'ajouter les entreprises générées à la liste de l'application
            list_entreprise.Items.AddRange(c_dic_entreprise.Values.ToArray());

            // Renvoie sur le bon onglet
            Page1.SelectedIndex = 1;
        }

        /// <summary>
        /// Procédure pour exporter les entreprises
        /// </summary>
        public void ExporterEntreprises()
        {
            // Permet de récupérer la liste des entreprises sous forme d'un tableau
            list_entreprise.Items.CopyTo(c_dic_entreprise.Values.ToArray(), 0);

            // Enregistre les entreprises dans un fichier CSV
            c_DAO_entreprise.save_entreprise_CSV(c_dic_entreprise.Values.ToList());

            // Renvoie sur le bon onglet
            Page1.SelectedIndex = 1;
        }

        /// <summary>
        /// Procédure pour importer les contacts
        /// </summary>
        public void ImporterContacts()
        {
            // Permet de supprimer la liste précédente des contacts
            list_contact.Items.Clear();

            // Permet de générer les contact à partir d'un fichier au format CSV
            c_dic_entreprise = c_DAO_entreprise.lire_entreprise_CSV();
            c_dic_contact = c_DAO_contact.lire_contact_CSV(c_dic_entreprise.Values.ToList());

            // Permet d'ajouter les entreprises générées à la liste de l'application
            list_contact.Items.AddRange(c_dic_contact.Values.ToArray());

            // Renvoie sur le bon onglet
            Page1.SelectedIndex = 0;
        }

        /// <summary>
        /// Procédure pour exporter les contacts
        /// </summary>
        public void ExporterContacts()
        {
            // Permet de récupérer la liste des entreprises sous forme d'un tableau
            list_entreprise.Items.CopyTo(c_dic_entreprise.Values.ToArray(), 0);
            list_contact.Items.CopyTo(c_dic_contact.Values.ToArray(), 0);

            // Enregistre les contacts dans un fichier CSV
            c_DAO_contact.save_contact_CSV(c_dic_contact.Values.ToList());

            // Renvoie sur le bon onglet
            Page1.SelectedIndex = 0;
        }
    }
}
