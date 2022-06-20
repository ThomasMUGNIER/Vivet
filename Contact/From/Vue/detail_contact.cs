using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.A;
using Library.B;
using From.Vue;
using From;

namespace From.Vue
{
    public partial class detail_contact : Form
    {
        cls_contact? c_contact;
        readonly Index c_from;

        /// <summary>
        /// Initialise le contact
        /// </summary>
        /// <param name="pcontact"></param>
        /// <param name="p_from"></param>
        public detail_contact(cls_contact? pcontact, Index p_from)
        {
            InitializeComponent();
            cls_DAO_BD.Connecter();
            c_contact = pcontact;
            c_from = p_from;

            List<cls_entreprise> l_list_entreprise = c_from.list_entreprises;

            info_contact_6.Items.AddRange(l_list_entreprise.ToArray());
            
            if (c_contact != null)
            {
                info_contact_1.Text = c_contact.nom;
                info_contact_2.Text = c_contact.prenom;
                info_contact_3.Text = Convert.ToString(c_contact.datedenaissance);
                info_contact_4.Text = c_contact.adresse;
                info_contact_5.Text = Convert.ToString(c_contact.phone);
                if (c_contact.entreprise != null)
                {
                    info_contact_6.Text = c_contact.entreprise.ToString();
                }
            }
        }

        /// <summary>
        /// Enregistrer les modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nom = info_contact_1.Text;
            string prenom = info_contact_2.Text;
            DateTime datedenaissance = Convert.ToDateTime(info_contact_3.Text);
            string Adresse = info_contact_4.Text;
            string phone = info_contact_5.Text;

            cls_entreprise Entreprise = (cls_entreprise)info_contact_6.SelectedItem;

            if (c_contact == null)
            {
                c_contact = new cls_contact(nom, prenom, datedenaissance, Adresse, null, phone, cls_ID.NouvelID(), Entreprise);

                List<cls_contact> l_ListContacts = c_from.list_contacts;
                l_ListContacts.Add(c_contact);
            }
            else
            {
                c_contact.Nom = nom;
                c_contact.Prenom = prenom;
                c_contact.datedenaissance = datedenaissance;
                c_contact.adresse = Adresse;
                c_contact.Phone = phone;
                if (info_contact_6.SelectedItem != null)
                {
                    c_contact.entreprise = (cls_entreprise)info_contact_6.SelectedItem;
                }
            }
            Close();
        }

        /// <summary>
        /// Permet de fermer la fenêtrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterSansSauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ajouterNouveauContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void info_contact_2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

