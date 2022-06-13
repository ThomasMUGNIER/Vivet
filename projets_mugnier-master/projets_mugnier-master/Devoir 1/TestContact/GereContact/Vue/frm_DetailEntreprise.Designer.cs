namespace GereContact.Vue
{
    partial class frm_DetailEntreprise
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
            this.tbx_RaisonSociale = new System.Windows.Forms.TextBox();
            this.btn_Enregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_RaisonSociale
            // 
            this.tbx_RaisonSociale.Location = new System.Drawing.Point(185, 73);
            this.tbx_RaisonSociale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_RaisonSociale.Name = "tbx_RaisonSociale";
            this.tbx_RaisonSociale.Size = new System.Drawing.Size(222, 27);
            this.tbx_RaisonSociale.TabIndex = 0;
            // 
            // btn_Enregistrer
            // 
            this.btn_Enregistrer.Location = new System.Drawing.Point(143, 344);
            this.btn_Enregistrer.Name = "btn_Enregistrer";
            this.btn_Enregistrer.Size = new System.Drawing.Size(152, 55);
            this.btn_Enregistrer.TabIndex = 1;
            this.btn_Enregistrer.Text = "Enregistrer";
            this.btn_Enregistrer.UseVisualStyleBackColor = true;
            this.btn_Enregistrer.Click += new System.EventHandler(this.btn_Enregistrer_Click);
            // 
            // frm_DetailEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btn_Enregistrer);
            this.Controls.Add(this.tbx_RaisonSociale);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_DetailEntreprise";
            this.Text = "frm_DetailEntreprise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbx_RaisonSociale;
        private Button btn_Enregistrer;
    }
}