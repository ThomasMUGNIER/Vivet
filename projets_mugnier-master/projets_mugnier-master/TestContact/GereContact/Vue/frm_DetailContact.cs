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

namespace GereContact
{
    public partial class frm_DetailContact : Form
    {
        cls_Contact? c_Contact;
        frm_GereContact c_frm_GereContact;
        public frm_DetailContact(cls_Contact? pContact, frm_GereContact pfrm_GereContact)
        {
            InitializeComponent();
            c_Contact = pContact;
            c_frm_GereContact = pfrm_GereContact;
            cbx_ListeEntreprise.Items.AddRange(c_frm_GereContact.ListeEntreprise);
            if(c_Contact!=null)
            {
                cbx_ListeEntreprise.SelectedItem = c_Contact.Entreprise ;
            }


        }

        private void frm_DetailContact_Load(object sender, EventArgs e)
        {

        }

        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {
            if(c_Contact==null)
            {
                c_Contact = new cls_Contact(cls_ID.NouvelID(), "gfdhqkf", "hjlkh",(cls_Entreprise) cbx_ListeEntreprise.SelectedItem);
            }
            else
            {
                
            }
        }
    }
}
