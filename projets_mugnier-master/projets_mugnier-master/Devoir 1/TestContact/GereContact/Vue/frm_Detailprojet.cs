using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dll_Contacts.Modele;
using dll_Contacts.DAO;
using dll_Contacts;

namespace GereContact.Vue
{
    public partial class frm_Detailprojet : Form
    {
            cls_Projet? c_Projet;
            

            public frm_Detailprojet(cls_Projet? pProjet)
            {
                InitializeComponent();
                c_Projet = pProjet;
                listBox1.Text = c_Projet.sociale;

            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c_Projet.sociale = listBox1.Text;
            this.Close();
        }
    }
}