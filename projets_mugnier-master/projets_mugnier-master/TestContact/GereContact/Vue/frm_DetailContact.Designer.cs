namespace GereContact
{
    partial class frm_DetailContact
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
            this.cbx_ListeEntreprise = new System.Windows.Forms.ComboBox();
            this.btn_Enregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_ListeEntreprise
            // 
            this.cbx_ListeEntreprise.FormattingEnabled = true;
            this.cbx_ListeEntreprise.Location = new System.Drawing.Point(449, 146);
            this.cbx_ListeEntreprise.Name = "cbx_ListeEntreprise";
            this.cbx_ListeEntreprise.Size = new System.Drawing.Size(220, 23);
            this.cbx_ListeEntreprise.TabIndex = 0;
            // 
            // btn_Enregistrer
            // 
            this.btn_Enregistrer.Location = new System.Drawing.Point(388, 398);
            this.btn_Enregistrer.Name = "btn_Enregistrer";
            this.btn_Enregistrer.Size = new System.Drawing.Size(88, 39);
            this.btn_Enregistrer.TabIndex = 1;
            this.btn_Enregistrer.Text = "button1";
            this.btn_Enregistrer.UseVisualStyleBackColor = true;
            this.btn_Enregistrer.Click += new System.EventHandler(this.btn_Enregistrer_Click);
            // 
            // frm_DetailContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Enregistrer);
            this.Controls.Add(this.cbx_ListeEntreprise);
            this.Name = "frm_DetailContact";
            this.Text = "frm_DetailContact";
            this.Load += new System.EventHandler(this.frm_DetailContact_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbx_ListeEntreprise;
        private Button btn_Enregistrer;
    }
}