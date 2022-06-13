using dll_Contacts;
using TestContact;
using GereContact.Vue;
using dll_Contacts.Modele;
using dll_Contacts.DAO;

namespace GereContact
{
    public partial class frm_GereContact : Form
    {
        private cls_Entreprise[] c_tabEntreprises;
        private cls_Contact[] c_tabContacts;
        public frm_GereContact()
        {
            InitializeComponent();
        }

        public cls_Entreprise[] ListeEntreprise
        {
            get { return c_tabEntreprises; }   
        }

        private void lsb_ListeEntreprise_Load(object sender, EventArgs e)
        {
            //c_tabEntreprises=cls_Test.GenereEntreprises();
            //DAO_Entreprise.EnregistreEntreprise(c_tabEntreprises);
            c_tabEntreprises = DAO_Entreprise.ChargerEntreprise();
            lsb_ListeEntreprises.Items.AddRange(c_tabEntreprises);
            c_tabContacts = DAO_Contact.ChargerContact(c_tabEntreprises);
            lsb_ListeContacts.Items.AddRange(c_tabContacts);

        }

        private void btn_AfficheEntreprise_Click(object sender, EventArgs e)
        {
           
        }

        private void lsb_ListeEntreprises_DoubleClick(object sender, EventArgs e)
        {
            cls_Entreprise l_EntrepriseSelectionnee =(cls_Entreprise) lsb_ListeEntreprises.SelectedItem;

            frm_DetailEntreprise l_frm_DetailEntreprise = new frm_DetailEntreprise(l_EntrepriseSelectionnee);

            l_frm_DetailEntreprise.ShowDialog();
        }

        private void frm_GereContact_DoubleClick(object sender, EventArgs e)
        {
            frm_DetailContact l_frmDetailContact = new frm_DetailContact(null, this);
            l_frmDetailContact.ShowDialog();
        }

        private void btn_AjoutContact_Click(object sender, EventArgs e)
        {
            frm_DetailContact l_frmDetailContact = new frm_DetailContact(null, this);
            l_frmDetailContact.ShowDialog();
        }

        private void lsb_ListeEntreprises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls_Projet l_Projet_select = (cls_Projet)lsb_ListeEntreprises.SelectedItem;
            frm_Detailprojet l_detail_Projet = new frm_Detailprojet(null);
            l_detail_Projet.ShowDialog();
        }
    }
}