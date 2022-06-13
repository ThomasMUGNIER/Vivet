namespace From
{
    partial class Index
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
            this.components = new System.ComponentModel.Container();
            this.lsb_ListeContact = new System.Windows.Forms.ListBox();
            this.btn_AfficheEntreprise = new System.Windows.Forms.Button();
            this.Page1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.delete_contact = new System.Windows.Forms.Button();
            this.add_contact = new System.Windows.Forms.Button();
            this.list_contact = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.delete_entreprise = new System.Windows.Forms.Button();
            this.add_entreprise = new System.Windows.Forms.Button();
            this.list_entreprise = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nouveauToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Import = new System.Windows.Forms.ToolStripMenuItem();
            this.entrepriseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Export = new System.Windows.Forms.ToolStripMenuItem();
            this.entrepriseToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Page1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsb_ListeContact
            // 
            this.lsb_ListeContact.Location = new System.Drawing.Point(0, 0);
            this.lsb_ListeContact.Name = "lsb_ListeContact";
            this.lsb_ListeContact.Size = new System.Drawing.Size(120, 96);
            this.lsb_ListeContact.TabIndex = 0;
            // 
            // btn_AfficheEntreprise
            // 
            this.btn_AfficheEntreprise.Location = new System.Drawing.Point(0, 0);
            this.btn_AfficheEntreprise.Name = "btn_AfficheEntreprise";
            this.btn_AfficheEntreprise.Size = new System.Drawing.Size(75, 23);
            this.btn_AfficheEntreprise.TabIndex = 0;
            // 
            // Page1
            // 
            this.Page1.AccessibleName = "list_entreprise";
            this.Page1.Controls.Add(this.tabPage1);
            this.Page1.Controls.Add(this.tabPage2);
            this.Page1.Location = new System.Drawing.Point(12, 46);
            this.Page1.Name = "Page1";
            this.Page1.SelectedIndex = 0;
            this.Page1.Size = new System.Drawing.Size(1328, 386);
            this.Page1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleName = "Tab1";
            this.tabPage1.Controls.Add(this.delete_contact);
            this.tabPage1.Controls.Add(this.add_contact);
            this.tabPage1.Controls.Add(this.list_contact);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1320, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contact";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // delete_contact
            // 
            this.delete_contact.Location = new System.Drawing.Point(1161, 175);
            this.delete_contact.Name = "delete_contact";
            this.delete_contact.Size = new System.Drawing.Size(159, 180);
            this.delete_contact.TabIndex = 5;
            this.delete_contact.Text = "Supprimer un contact";
            this.delete_contact.UseVisualStyleBackColor = true;
            this.delete_contact.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_contact
            // 
            this.add_contact.Location = new System.Drawing.Point(1161, 0);
            this.add_contact.Name = "add_contact";
            this.add_contact.Size = new System.Drawing.Size(159, 184);
            this.add_contact.TabIndex = 4;
            this.add_contact.Text = "Ajouter un contact";
            this.add_contact.UseVisualStyleBackColor = true;
            this.add_contact.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_contact
            // 
            this.list_contact.FormattingEnabled = true;
            this.list_contact.ItemHeight = 15;
            this.list_contact.Location = new System.Drawing.Point(6, 3);
            this.list_contact.Name = "list_contact";
            this.list_contact.Size = new System.Drawing.Size(1158, 349);
            this.list_contact.TabIndex = 3;
            this.list_contact.DoubleClick += new System.EventHandler(this.list_contact_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.AccessibleName = "Tab2";
            this.tabPage2.Controls.Add(this.delete_entreprise);
            this.tabPage2.Controls.Add(this.add_entreprise);
            this.tabPage2.Controls.Add(this.list_entreprise);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1320, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Entreprise";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // delete_entreprise
            // 
            this.delete_entreprise.Location = new System.Drawing.Point(1161, 171);
            this.delete_entreprise.Name = "delete_entreprise";
            this.delete_entreprise.Size = new System.Drawing.Size(153, 172);
            this.delete_entreprise.TabIndex = 6;
            this.delete_entreprise.Text = "Supprimer une entreprise";
            this.delete_entreprise.UseVisualStyleBackColor = true;
            this.delete_entreprise.Click += new System.EventHandler(this.button4_Click);
            // 
            // add_entreprise
            // 
            this.add_entreprise.Location = new System.Drawing.Point(1161, 9);
            this.add_entreprise.Name = "add_entreprise";
            this.add_entreprise.Size = new System.Drawing.Size(153, 163);
            this.add_entreprise.TabIndex = 5;
            this.add_entreprise.Text = "Ajouter une entreprise";
            this.add_entreprise.UseVisualStyleBackColor = true;
            this.add_entreprise.Click += new System.EventHandler(this.button3_Click);
            // 
            // list_entreprise
            // 
            this.list_entreprise.FormattingEnabled = true;
            this.list_entreprise.ItemHeight = 15;
            this.list_entreprise.Location = new System.Drawing.Point(6, 9);
            this.list_entreprise.Name = "list_entreprise";
            this.list_entreprise.Size = new System.Drawing.Size(1159, 334);
            this.list_entreprise.TabIndex = 2;
            this.list_entreprise.DoubleClick += new System.EventHandler(this.list_entreprise_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // nouveauToolStripMenuItem1
            // 
            this.nouveauToolStripMenuItem1.Name = "nouveauToolStripMenuItem1";
            this.nouveauToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fichier,
            this.Import,
            this.Export});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Fichier
            // 
            this.Fichier.AccessibleName = "Fichier";
            this.Fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.Fichier.Name = "Fichier";
            this.Fichier.Size = new System.Drawing.Size(54, 20);
            this.Fichier.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Import
            // 
            this.Import.AccessibleName = "Import";
            this.Import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrepriseToolStripMenuItem1,
            this.contactToolStripMenuItem1});
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(55, 20);
            this.Import.Text = "Import";
            // 
            // entrepriseToolStripMenuItem1
            // 
            this.entrepriseToolStripMenuItem1.Name = "entrepriseToolStripMenuItem1";
            this.entrepriseToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.entrepriseToolStripMenuItem1.Text = "Entreprise";
            this.entrepriseToolStripMenuItem1.Click += new System.EventHandler(this.entrepriseToolStripMenuItem1_Click);
            // 
            // contactToolStripMenuItem1
            // 
            this.contactToolStripMenuItem1.Name = "contactToolStripMenuItem1";
            this.contactToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.contactToolStripMenuItem1.Text = "Contact";
            this.contactToolStripMenuItem1.Click += new System.EventHandler(this.contactToolStripMenuItem1_Click);
            // 
            // Export
            // 
            this.Export.AccessibleName = "Export";
            this.Export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrepriseToolStripMenuItem2,
            this.contactToolStripMenuItem2});
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(53, 20);
            this.Export.Text = "Export";
            // 
            // entrepriseToolStripMenuItem2
            // 
            this.entrepriseToolStripMenuItem2.Name = "entrepriseToolStripMenuItem2";
            this.entrepriseToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.entrepriseToolStripMenuItem2.Text = "Entreprise";
            this.entrepriseToolStripMenuItem2.Click += new System.EventHandler(this.entrepriseToolStripMenuItem2_Click);
            // 
            // contactToolStripMenuItem2
            // 
            this.contactToolStripMenuItem2.Name = "contactToolStripMenuItem2";
            this.contactToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.contactToolStripMenuItem2.Text = "Contact";
            this.contactToolStripMenuItem2.Click += new System.EventHandler(this.contactToolStripMenuItem2_Click);
            // 
            // Index
            // 
            this.ClientSize = new System.Drawing.Size(1366, 466);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Page1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Index";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Page1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox lsb_ListeContact;
        private Button btn_AfficheEntreprise;
        private TabControl Page1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem nouveauToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem nouveauToolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Fichier;
        private ToolStripMenuItem Import;
        private ToolStripMenuItem Export;
        private ListBox list_contact;
        public ListBox list_entreprise;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem entrepriseToolStripMenuItem1;
        private ToolStripMenuItem contactToolStripMenuItem1;
        private ToolStripMenuItem entrepriseToolStripMenuItem2;
        private ToolStripMenuItem contactToolStripMenuItem2;
        private Button add_contact;
        private Button delete_contact;
        private Button delete_entreprise;
        private Button add_entreprise;
    }
}
