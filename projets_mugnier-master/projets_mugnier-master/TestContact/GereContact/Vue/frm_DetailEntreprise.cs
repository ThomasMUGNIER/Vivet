using dll_Contacts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GereContact.Vue
{
    public partial class frm_DetailEntreprise : Form
    {
        cls_Entreprise c_Entreprise;
        public frm_DetailEntreprise(cls_Entreprise pEntreprise)
        {
            InitializeComponent();
            c_Entreprise = pEntreprise;
            tbx_RaisonSociale.Text=c_Entreprise.RaisonSociale;

        }

        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {
            c_Entreprise.RaisonSociale = tbx_RaisonSociale.Text;
            this.Close();
        }
    }
}
