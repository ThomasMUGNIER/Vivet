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
using From;

namespace From.Vue
{

    public partial class detail_entreprise : Form
    {
        cls_entreprise? c_entreprise;
        readonly Index c_from;

        /// <summary>
        /// Initialise les entreprises
        /// </summary>
        /// <param name="pentreprise"></param>
        /// <param name="p_from"></param>
        public detail_entreprise(cls_entreprise? pentreprise, Index p_from)
        {
            InitializeComponent();
            cls_DAO_BD.Connecter();
            c_entreprise = pentreprise;
            c_from = p_from;
            if (c_entreprise != null)
            {
                info_entreprise_1.Text = c_entreprise.Raisonsociale;
                info_entreprise_2.Text = c_entreprise.codepostale;
                info_entreprise_3.Text = c_entreprise.Commune;
                info_entreprise_4.Text = c_entreprise.mail;
                info_entreprise_5.Text = c_entreprise.URL;
            }
        }

        /// <summary>
        /// Ferme la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterSansSauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Enregistrer les modifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enregistrerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string raisonsociale = info_entreprise_1.Text;
            string codepostale = info_entreprise_2.Text;
            string commune = info_entreprise_4.Text;
            string mail = info_entreprise_3.Text;
            string URL = info_entreprise_5.Text;

            if (c_entreprise == null)
            {
                c_entreprise = new cls_entreprise(cls_ID.NouvelID(), raisonsociale, codepostale, commune, mail, URL);

                List<cls_entreprise> l_ListEntreprises = c_from.list_entreprises;
                l_ListEntreprises.Add(c_entreprise);
            }
            else
            {
                c_entreprise.Raisonsociale = raisonsociale;
                c_entreprise.Codepostale = codepostale;
                c_entreprise.Commune = commune;
                c_entreprise.Mail = mail;
                c_entreprise.URLl = URL;
            }
            Close();
        }
    }
}
