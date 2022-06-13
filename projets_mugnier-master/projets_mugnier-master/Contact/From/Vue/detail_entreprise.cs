﻿using System;
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
        readonly Form c_from;

        /// <summary>
        /// Initialise les entreprises
        /// </summary>
        /// <param name="pContact"></param>
        /// <param name="p_Frm_TP4"></param>
        public detail_entreprise(cls_entreprise? pentreprise, Form p_from)
        {
            InitializeComponent();
            c_entreprise = pentreprise;
            c_from = p_from;
            if (c_entreprise != null)
            {
                info_entreprise_1.Text = c_entreprise.Raisonsociale;
                info_entreprise_2.Text = c_entreprise.Codepostale;
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
            string Raisonsociale = info_entreprise_1.Text;
            string Codepostale = info_entreprise_2.Text;
            string Commune = info_entreprise_3.Text;
            string mail = info_entreprise_4.Text;
            string URL = info_entreprise_5.Text;

            if (c_entreprise == null)
            {
                c_entreprise = new cls_entreprise(cls_ID.NouvelID(), Raisonsociale, Codepostale, Commune, mail, URL);

                List<cls_entreprise> l_ListEntreprises = c_from.list_entreprise;
                l_ListEntreprises.Add(c_entreprise);
            }
            else
            {
                c_entreprise.Raisonsociale = Raisonsociale;
                c_entreprise.Codepostale = Codepostale;
                c_entreprise.Commune = Commune;
                c_entreprise.mail = mail;
                c_entreprise.URL = URL;
            }
            Close();
        }
    }
}
