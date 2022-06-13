namespace GereContact
{
    partial class frm_GereContact
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsb_ListeEntreprises = new System.Windows.Forms.ListBox();
            this.btn_AfficheEntreprise = new System.Windows.Forms.Button();
            this.lsb_ListeContacts = new System.Windows.Forms.ListBox();
            this.btn_AjoutContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsb_ListeEntreprises
            // 
            this.lsb_ListeEntreprises.FormattingEnabled = true;
            this.lsb_ListeEntreprises.ItemHeight = 20;
            this.lsb_ListeEntreprises.Location = new System.Drawing.Point(35, 61);
            this.lsb_ListeEntreprises.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsb_ListeEntreprises.Name = "lsb_ListeEntreprises";
            this.lsb_ListeEntreprises.Size = new System.Drawing.Size(361, 464);
            this.lsb_ListeEntreprises.TabIndex = 0;
            this.lsb_ListeEntreprises.DoubleClick += new System.EventHandler(this.lsb_ListeEntreprises_DoubleClick);
            // 
            // btn_AfficheEntreprise
            // 
            this.btn_AfficheEntreprise.Location = new System.Drawing.Point(126, 556);
            this.btn_AfficheEntreprise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AfficheEntreprise.Name = "btn_AfficheEntreprise";
            this.btn_AfficheEntreprise.Size = new System.Drawing.Size(183, 69);
            this.btn_AfficheEntreprise.TabIndex = 1;
            this.btn_AfficheEntreprise.Text = "Afficher entreprises";
            this.btn_AfficheEntreprise.UseVisualStyleBackColor = true;
            this.btn_AfficheEntreprise.Click += new System.EventHandler(this.btn_AfficheEntreprise_Click);
            // 
            // lsb_ListeContacts
            // 
            this.lsb_ListeContacts.FormattingEnabled = true;
            this.lsb_ListeContacts.ItemHeight = 20;
            this.lsb_ListeContacts.Location = new System.Drawing.Point(496, 61);
            this.lsb_ListeContacts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsb_ListeContacts.Name = "lsb_ListeContacts";
            this.lsb_ListeContacts.Size = new System.Drawing.Size(361, 464);
            this.lsb_ListeContacts.TabIndex = 2;
            // 
            // btn_AjoutContact
            // 
            this.btn_AjoutContact.Location = new System.Drawing.Point(612, 575);
            this.btn_AjoutContact.Name = "btn_AjoutContact";
            this.btn_AjoutContact.Size = new System.Drawing.Size(197, 51);
            this.btn_AjoutContact.TabIndex = 3;
            this.btn_AjoutContact.Text = "Ajouter un contact";
            this.btn_AjoutContact.UseVisualStyleBackColor = true;
            this.btn_AjoutContact.Click += new System.EventHandler(this.btn_AjoutContact_Click);
            // 
            // frm_GereContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 664);
            this.Controls.Add(this.btn_AjoutContact);
            this.Controls.Add(this.lsb_ListeContacts);
            this.Controls.Add(this.btn_AfficheEntreprise);
            this.Controls.Add(this.lsb_ListeEntreprises);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_GereContact";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.lsb_ListeEntreprise_Load);
            this.DoubleClick += new System.EventHandler(this.frm_GereContact_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lsb_ListeEntreprises;
        private Button btn_AfficheEntreprise;
        private ListBox lsb_ListeContacts;
        private Button btn_AjoutContact;
    }
}