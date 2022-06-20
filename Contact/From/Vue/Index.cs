using Library.B;
using Library.A;
using From.Vue;


namespace From
{
    public partial class Index : Form
    {

        private Dictionary<int, cls_entreprise> c_dic_entreprise;
        private Dictionary<int, cls_contact> c_dic_contact;
        private cls_DAO_Entreprise_BD c_DAO_entreprise;
        private cls_DAO_Contact_BD c_DAO_contact;
        public Index()
        { 
        InitializeComponent();
        c_DAO_entreprise = new cls_DAO_Entreprise_BD();
        c_DAO_contact = new cls_DAO_Contact_BD();

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
        /// Charge en mémoire des entreprises et des contacts, puis les affiche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

            // Permet de gerer les actions import, sauvegarder d'entreprise
            c_dic_entreprise = c_DAO_entreprise.cree_entreprise();
            c_DAO_entreprise.save_entreprise_CSV(c_dic_entreprise.Values.ToList());
            c_dic_contact = c_DAO_contact.cree_contact(c_dic_entreprise.Values.ToList());
            c_DAO_contact.save_contact_CSV(c_dic_contact.Values.ToList());
            c_dic_entreprise = c_DAO_entreprise.lire_entreprise_CSV();
            list_entreprise.Items.AddRange(c_dic_entreprise.Values.ToArray());
            c_dic_contact = c_DAO_contact.lire_contact_CSV(c_dic_entreprise.Values.ToList());
            list_contact.Items.AddRange(c_dic_contact.Values.ToArray());
        }
        /// <summary>
        /// Permet d'ouvrir detail_entreprise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void list_entreprise_DoubleClick(object sender, EventArgs e)
        {
            cls_entreprise l_entreprise_select = (cls_entreprise)list_entreprise.SelectedItem;
            detail_entreprise l_detail_entreprise = new(l_entreprise_select, this);
            l_detail_entreprise.ShowDialog();


        }

        /// <summary>
        /// Permet d'ajouter une entreprise à la liste des entreprises
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void entrepriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cls_entreprise Entreprise = new cls_entreprise((list_entreprise.Items.Count + 1), "Raison Sociale " + (list_entreprise.Items.Count + 1), Cls_DAO_Entreprise.codepostalealeatoire(), "Commune " + (list_entreprise.Items.Count + 1), "mail." + (list_contact.Items.Count + 1) + "@gmail.com", "www.URL" + (list_entreprise.Items.Count + 1) + ".fr");
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

        /// <summary>
        /// Permet de crée un nouveau contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            detail_contact l_detail_contact = new(null, this);
        }

        /// <summary>
        /// Permet de supprimer un contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulait vous supprimer le contact sélectionné ?", "Supprimer contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result.Equals(DialogResult.Yes))
            {
                list_contact.Items.Remove(list_contact.SelectedItem);
            }
        }

        /// <summary>
        /// Permet d'ajouter une nouvelle entreprise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            detail_entreprise l_FrmDetailEntreprise = new(null, this);

            l_FrmDetailEntreprise.ShowDialog();
        }

        /// <summary>
        /// Permet de supprimer une entreprise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulais vous supprimer l'entreprise sélectionnée ?", "Supprimer entreprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            list_entreprise.Items.Clear();
            c_dic_entreprise = c_DAO_entreprise.lire_entreprise_CSV();
            list_entreprise.Items.AddRange(c_dic_entreprise.Values.ToArray());
            Page1.SelectedIndex = 1;
        }

        /// <summary>
        /// Procédure pour exporter les entreprises
        /// </summary>
        public void ExporterEntreprises()
        {
            list_entreprise.Items.CopyTo(c_dic_entreprise.Values.ToArray(), 0);
            c_DAO_entreprise.save_entreprise_CSV(c_dic_entreprise.Values.ToList());
            Page1.SelectedIndex = 1;
        }

        /// <summary>
        /// Procédure pour importer les contacts
        /// </summary>
        public void ImporterContacts()
        {
            list_contact.Items.Clear();
            c_dic_entreprise = c_DAO_entreprise.lire_entreprise_CSV();
            c_dic_contact = c_DAO_contact.lire_contact_CSV(c_dic_entreprise.Values.ToList());
            list_contact.Items.AddRange(c_dic_contact.Values.ToArray());
            Page1.SelectedIndex = 0;
        }

        /// <summary>
        /// Procédure pour exporter les contacts
        /// </summary>
        public void ExporterContacts()
        {
            list_entreprise.Items.CopyTo(c_dic_entreprise.Values.ToArray(), 0);
            list_contact.Items.CopyTo(c_dic_contact.Values.ToArray(), 0);
            c_DAO_contact.save_contact_CSV(c_dic_contact.Values.ToList());
            Page1.SelectedIndex = 0;
        }

        private void list_entreprise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
