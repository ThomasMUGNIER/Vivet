namespace Frm_TP4
{
    partial class Frm_DetailContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DetailContact));
            this.btn_DetailContactAnnulation = new System.Windows.Forms.Button();
            this.btn_DetailContactValidation = new System.Windows.Forms.Button();
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.txb_Telephone = new System.Windows.Forms.TextBox();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.txb_Mail = new System.Windows.Forms.TextBox();
            this.txb_Adresse = new System.Windows.Forms.TextBox();
            this.lbl_Adresse = new System.Windows.Forms.Label();
            this.lbl_DateDeNaissance = new System.Windows.Forms.Label();
            this.lbl_Prenom = new System.Windows.Forms.Label();
            this.txb_Prenom = new System.Windows.Forms.TextBox();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.txb_Nom = new System.Windows.Forms.TextBox();
            this.dtp_DateDeNaissance = new System.Windows.Forms.DateTimePicker();
            this.cbx_Entreprise = new System.Windows.Forms.ComboBox();
            this.lbl_Entreprise = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_DetailContactAnnulation
            // 
            this.btn_DetailContactAnnulation.Location = new System.Drawing.Point(658, 398);
            this.btn_DetailContactAnnulation.Name = "btn_DetailContactAnnulation";
            this.btn_DetailContactAnnulation.Size = new System.Drawing.Size(130, 39);
            this.btn_DetailContactAnnulation.TabIndex = 9;
            this.btn_DetailContactAnnulation.Text = "Annuler";
            this.btn_DetailContactAnnulation.UseVisualStyleBackColor = true;
            this.btn_DetailContactAnnulation.Click += new System.EventHandler(this.Btn_DetailContactAnnulation_Click_1);
            // 
            // btn_DetailContactValidation
            // 
            this.btn_DetailContactValidation.Location = new System.Drawing.Point(534, 398);
            this.btn_DetailContactValidation.Name = "btn_DetailContactValidation";
            this.btn_DetailContactValidation.Size = new System.Drawing.Size(118, 39);
            this.btn_DetailContactValidation.TabIndex = 8;
            this.btn_DetailContactValidation.Text = "Enregistrer";
            this.btn_DetailContactValidation.UseVisualStyleBackColor = true;
            this.btn_DetailContactValidation.Click += new System.EventHandler(this.Btn_DetailContactValidation_Click_1);
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Location = new System.Drawing.Point(12, 301);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(78, 20);
            this.lbl_Telephone.TabIndex = 21;
            this.lbl_Telephone.Text = "Téléphone";
            // 
            // txb_Telephone
            // 
            this.txb_Telephone.Location = new System.Drawing.Point(123, 298);
            this.txb_Telephone.Name = "txb_Telephone";
            this.txb_Telephone.Size = new System.Drawing.Size(665, 27);
            this.txb_Telephone.TabIndex = 6;
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(12, 243);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(94, 20);
            this.lbl_Mail.TabIndex = 19;
            this.lbl_Mail.Text = "Adresse Mail";
            // 
            // txb_Mail
            // 
            this.txb_Mail.Location = new System.Drawing.Point(123, 240);
            this.txb_Mail.Name = "txb_Mail";
            this.txb_Mail.Size = new System.Drawing.Size(665, 27);
            this.txb_Mail.TabIndex = 5;
            // 
            // txb_Adresse
            // 
            this.txb_Adresse.Location = new System.Drawing.Point(123, 184);
            this.txb_Adresse.Name = "txb_Adresse";
            this.txb_Adresse.Size = new System.Drawing.Size(665, 27);
            this.txb_Adresse.TabIndex = 4;
            // 
            // lbl_Adresse
            // 
            this.lbl_Adresse.AutoSize = true;
            this.lbl_Adresse.Location = new System.Drawing.Point(12, 187);
            this.lbl_Adresse.Name = "lbl_Adresse";
            this.lbl_Adresse.Size = new System.Drawing.Size(61, 20);
            this.lbl_Adresse.TabIndex = 16;
            this.lbl_Adresse.Text = "Adresse";
            // 
            // lbl_DateDeNaissance
            // 
            this.lbl_DateDeNaissance.AutoSize = true;
            this.lbl_DateDeNaissance.Location = new System.Drawing.Point(12, 129);
            this.lbl_DateDeNaissance.Name = "lbl_DateDeNaissance";
            this.lbl_DateDeNaissance.Size = new System.Drawing.Size(75, 20);
            this.lbl_DateDeNaissance.TabIndex = 14;
            this.lbl_DateDeNaissance.Text = "Naissance";
            // 
            // lbl_Prenom
            // 
            this.lbl_Prenom.AutoSize = true;
            this.lbl_Prenom.Location = new System.Drawing.Point(12, 71);
            this.lbl_Prenom.Name = "lbl_Prenom";
            this.lbl_Prenom.Size = new System.Drawing.Size(60, 20);
            this.lbl_Prenom.TabIndex = 13;
            this.lbl_Prenom.Text = "Prénom";
            // 
            // txb_Prenom
            // 
            this.txb_Prenom.Location = new System.Drawing.Point(123, 68);
            this.txb_Prenom.Name = "txb_Prenom";
            this.txb_Prenom.Size = new System.Drawing.Size(665, 27);
            this.txb_Prenom.TabIndex = 2;
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Location = new System.Drawing.Point(12, 15);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(42, 20);
            this.lbl_Nom.TabIndex = 25;
            this.lbl_Nom.Text = "Nom";
            // 
            // txb_Nom
            // 
            this.txb_Nom.Location = new System.Drawing.Point(123, 12);
            this.txb_Nom.Name = "txb_Nom";
            this.txb_Nom.Size = new System.Drawing.Size(665, 27);
            this.txb_Nom.TabIndex = 1;
            // 
            // dtp_DateDeNaissance
            // 
            this.dtp_DateDeNaissance.Location = new System.Drawing.Point(123, 124);
            this.dtp_DateDeNaissance.Name = "dtp_DateDeNaissance";
            this.dtp_DateDeNaissance.Size = new System.Drawing.Size(665, 27);
            this.dtp_DateDeNaissance.TabIndex = 3;
            // 
            // cbx_Entreprise
            // 
            this.cbx_Entreprise.FormattingEnabled = true;
            this.cbx_Entreprise.Location = new System.Drawing.Point(123, 364);
            this.cbx_Entreprise.Name = "cbx_Entreprise";
            this.cbx_Entreprise.Size = new System.Drawing.Size(665, 28);
            this.cbx_Entreprise.TabIndex = 7;
            // 
            // lbl_Entreprise
            // 
            this.lbl_Entreprise.AutoSize = true;
            this.lbl_Entreprise.Location = new System.Drawing.Point(12, 367);
            this.lbl_Entreprise.Name = "lbl_Entreprise";
            this.lbl_Entreprise.Size = new System.Drawing.Size(75, 20);
            this.lbl_Entreprise.TabIndex = 27;
            this.lbl_Entreprise.Text = "Entreprise";
            // 
            // Frm_DetailContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Entreprise);
            this.Controls.Add(this.cbx_Entreprise);
            this.Controls.Add(this.dtp_DateDeNaissance);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.txb_Nom);
            this.Controls.Add(this.btn_DetailContactAnnulation);
            this.Controls.Add(this.btn_DetailContactValidation);
            this.Controls.Add(this.lbl_Telephone);
            this.Controls.Add(this.txb_Telephone);
            this.Controls.Add(this.lbl_Mail);
            this.Controls.Add(this.txb_Mail);
            this.Controls.Add(this.txb_Adresse);
            this.Controls.Add(this.lbl_Adresse);
            this.Controls.Add(this.lbl_DateDeNaissance);
            this.Controls.Add(this.lbl_Prenom);
            this.Controls.Add(this.txb_Prenom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_DetailContact";
            this.Text = "Kontakt - Ajouter ou modifier un contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_DetailContactAnnulation;
        private Button btn_DetailContactValidation;
        private Label lbl_Telephone;
        private TextBox txb_Telephone;
        private Label lbl_Mail;
        private TextBox txb_Mail;
        private TextBox txb_Adresse;
        private Label lbl_Adresse;
        private Label lbl_DateDeNaissance;
        private Label lbl_Prenom;
        private TextBox txb_Prenom;
        private Label lbl_Nom;
        private TextBox txb_Nom;
        private DateTimePicker dtp_DateDeNaissance;
        private ComboBox cbx_Entreprise;
        private Label lbl_Entreprise;
    }
}