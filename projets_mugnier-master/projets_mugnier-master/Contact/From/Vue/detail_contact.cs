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
        readonly Form c_from;

        /// <summary>
        /// Initialise le contact
        /// </summary>
        /// <param name="pcontact"></param>
        /// <param name="p_from"></param>
        public detail_contact(cls_contact? pContact, Form p_from)
        {
            InitializeComponent();

            c_contact = pContact;
            c_from = p_from;

            List<cls_entreprise> l_list_entreprise = c_from.list_entreprise;

            info_contact_6.Items.AddRange(list_entreprise.ToArray());

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
        /// Permet d'enregistrer les changements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Nom = info_contact_1.Text;
            string Prenom = info_contact_2.Text;
            DateTime DateDeNaissance = Convert.ToDateTime(info_contact_3.Text);
            string Adresse = info_contact_4.Text;
            string Mail = info_contact_5.Text;
            string Telephone = info_contact_6.Text;

            cls_entreprise Entreprise = (cls_entreprise)info_contact_6.SelectedItem;

            if (c_contact == null)
            {
                c_contact = new cls_contact(cls_ID.NouvelID(), Nom, Prenom, DateDeNaissance, Adresse, Mail, Telephone, Entreprise);

                List<cls_contact> l_ListContacts = c_from.list_contact;
                l_ListContacts.Add(c_contact);
            }
            else
            {
                c_contact.nom = Nom;
                c_contact.prenom = Prenom;
                c_contact.datedenaissance = DateDeNaissance;
                c_contact.adresse = info_contact_3.Text;
                c_contact.mail = info_contact_4.Text;
                c_contact.phone = info_contact_5.Text;
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

