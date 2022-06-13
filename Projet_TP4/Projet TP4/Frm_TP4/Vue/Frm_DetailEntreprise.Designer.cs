namespace Frm_TP4
{
    partial class Frm_DetailEntreprise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DetailEntreprise));
            this.txb_RaisonSociale = new System.Windows.Forms.TextBox();
            this.lbl_RaisonSociale = new System.Windows.Forms.Label();
            this.lbl_CodePostal = new System.Windows.Forms.Label();
            this.txb_CodePostal = new System.Windows.Forms.TextBox();
            this.lbl_Commune = new System.Windows.Forms.Label();
            this.txb_Commune = new System.Windows.Forms.TextBox();
            this.txb_Mail = new System.Windows.Forms.TextBox();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.txb_URL = new System.Windows.Forms.TextBox();
            this.lbl_URL = new System.Windows.Forms.Label();
            this.btn_DetailEntrepriseValidation = new System.Windows.Forms.Button();
            this.btn_DetailEntrepriseAnnulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_RaisonSociale
            // 
            this.txb_RaisonSociale.Location = new System.Drawing.Point(123, 90);
            this.txb_RaisonSociale.Name = "txb_RaisonSociale";
            this.txb_RaisonSociale.Size = new System.Drawing.Size(665, 27);
            this.txb_RaisonSociale.TabIndex = 0;
            // 
            // lbl_RaisonSociale
            // 
            this.lbl_RaisonSociale.AutoSize = true;
            this.lbl_RaisonSociale.Location = new System.Drawing.Point(12, 93);
            this.lbl_RaisonSociale.Name = "lbl_RaisonSociale";
            this.lbl_RaisonSociale.Size = new System.Drawing.Size(105, 20);
            this.lbl_RaisonSociale.TabIndex = 1;
            this.lbl_RaisonSociale.Text = "Raison Sociale";
            // 
            // lbl_CodePostal
            // 
            this.lbl_CodePostal.AutoSize = true;
            this.lbl_CodePostal.Location = new System.Drawing.Point(12, 151);
            this.lbl_CodePostal.Name = "lbl_CodePostal";
            this.lbl_CodePostal.Size = new System.Drawing.Size(87, 20);
            this.lbl_CodePostal.TabIndex = 2;
            this.lbl_CodePostal.Text = "Code Postal";
            // 
            // txb_CodePostal
            // 
            this.txb_CodePostal.Location = new System.Drawing.Point(123, 148);
            this.txb_CodePostal.Name = "txb_CodePostal";
            this.txb_CodePostal.Size = new System.Drawing.Size(665, 27);
            this.txb_CodePostal.TabIndex = 3;
            // 
            // lbl_Commune
            // 
            this.lbl_Commune.AutoSize = true;
            this.lbl_Commune.Location = new System.Drawing.Point(12, 209);
            this.lbl_Commune.Name = "lbl_Commune";
            this.lbl_Commune.Size = new System.Drawing.Size(77, 20);
            this.lbl_Commune.TabIndex = 4;
            this.lbl_Commune.Text = "Commune";
            // 
            // txb_Commune
            // 
            this.txb_Commune.Location = new System.Drawing.Point(123, 206);
            this.txb_Commune.Name = "txb_Commune";
            this.txb_Commune.Size = new System.Drawing.Size(665, 27);
            this.txb_Commune.TabIndex = 5;
            // 
            // txb_Mail
            // 
            this.txb_Mail.Location = new System.Drawing.Point(123, 262);
            this.txb_Mail.Name = "txb_Mail";
            this.txb_Mail.Size = new System.Drawing.Size(665, 27);
            this.txb_Mail.TabIndex = 6;
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(12, 265);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(94, 20);
            this.lbl_Mail.TabIndex = 7;
            this.lbl_Mail.Text = "Adresse Mail";
            // 
            // txb_URL
            // 
            this.txb_URL.Location = new System.Drawing.Point(123, 320);
            this.txb_URL.Name = "txb_URL";
            this.txb_URL.Size = new System.Drawing.Size(665, 27);
            this.txb_URL.TabIndex = 8;
            // 
            // lbl_URL
            // 
            this.lbl_URL.AutoSize = true;
            this.lbl_URL.Location = new System.Drawing.Point(12, 323);
            this.lbl_URL.Name = "lbl_URL";
            this.lbl_URL.Size = new System.Drawing.Size(89, 20);
            this.lbl_URL.TabIndex = 9;
            this.lbl_URL.Text = "Site Internet";
            // 
            // btn_DetailEntrepriseValidation
            // 
            this.btn_DetailEntrepriseValidation.Location = new System.Drawing.Point(534, 399);
            this.btn_DetailEntrepriseValidation.Name = "btn_DetailEntrepriseValidation";
            this.btn_DetailEntrepriseValidation.Size = new System.Drawing.Size(118, 39);
            this.btn_DetailEntrepriseValidation.TabIndex = 10;
            this.btn_DetailEntrepriseValidation.Text = "Enregistrer";
            this.btn_DetailEntrepriseValidation.UseVisualStyleBackColor = true;
            this.btn_DetailEntrepriseValidation.Click += new System.EventHandler(this.Btn_DetailEntrepriseValidation_Click);
            // 
            // btn_DetailEntrepriseAnnulation
            // 
            this.btn_DetailEntrepriseAnnulation.Location = new System.Drawing.Point(658, 399);
            this.btn_DetailEntrepriseAnnulation.Name = "btn_DetailEntrepriseAnnulation";
            this.btn_DetailEntrepriseAnnulation.Size = new System.Drawing.Size(130, 39);
            this.btn_DetailEntrepriseAnnulation.TabIndex = 11;
            this.btn_DetailEntrepriseAnnulation.Text = "Annuler";
            this.btn_DetailEntrepriseAnnulation.UseVisualStyleBackColor = true;
            this.btn_DetailEntrepriseAnnulation.Click += new System.EventHandler(this.Btn_DetailEntrepriseAnnulation_Click);
            // 
            // Frm_DetailEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_DetailEntrepriseAnnulation);
            this.Controls.Add(this.btn_DetailEntrepriseValidation);
            this.Controls.Add(this.lbl_URL);
            this.Controls.Add(this.txb_URL);
            this.Controls.Add(this.lbl_Mail);
            this.Controls.Add(this.txb_Mail);
            this.Controls.Add(this.txb_Commune);
            this.Controls.Add(this.lbl_Commune);
            this.Controls.Add(this.txb_CodePostal);
            this.Controls.Add(this.lbl_CodePostal);
            this.Controls.Add(this.lbl_RaisonSociale);
            this.Controls.Add(this.txb_RaisonSociale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_DetailEntreprise";
            this.Text = "Kontakt - Ajouter ou modifier une entreprise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txb_RaisonSociale;
        private Label lbl_RaisonSociale;
        private Label lbl_CodePostal;
        private TextBox txb_CodePostal;
        private Label lbl_Commune;
        private TextBox txb_Commune;
        private TextBox txb_Mail;
        private Label lbl_Mail;
        private TextBox txb_URL;
        private Label lbl_URL;
        private Button btn_DetailEntrepriseValidation;
        private Button btn_DetailEntrepriseAnnulation;
    }
}