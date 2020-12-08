namespace Biblio
{
    partial class RetourIhm
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
            this.txtCodeExemplaire = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAuteurs = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtAuteurs = new System.Windows.Forms.TextBox();
            this.lblCodeExemplaire = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.grpRetour = new System.Windows.Forms.GroupBox();
            this.lblDateEmprunt = new System.Windows.Forms.Label();
            this.lblAdherent = new System.Windows.Forms.Label();
            this.txtDateEmprunt = new System.Windows.Forms.TextBox();
            this.txtAdherent = new System.Windows.Forms.TextBox();
            this.lblBibliotheque = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.grpRetour.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodeExemplaire
            // 
            this.txtCodeExemplaire.Location = new System.Drawing.Point(85, 33);
            this.txtCodeExemplaire.Name = "txtCodeExemplaire";
            this.txtCodeExemplaire.Size = new System.Drawing.Size(100, 20);
            this.txtCodeExemplaire.TabIndex = 0;
            this.txtCodeExemplaire.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodeExemplaire_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAuteurs);
            this.groupBox2.Controls.Add(this.lblTitre);
            this.groupBox2.Controls.Add(this.txtTitre);
            this.groupBox2.Controls.Add(this.txtAuteurs);
            this.groupBox2.Controls.Add(this.lblCodeExemplaire);
            this.groupBox2.Controls.Add(this.txtCodeExemplaire);
            this.groupBox2.Location = new System.Drawing.Point(21, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 176);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exemplaire : ";
            // 
            // lblAuteurs
            // 
            this.lblAuteurs.AutoSize = true;
            this.lblAuteurs.Location = new System.Drawing.Point(15, 111);
            this.lblAuteurs.Name = "lblAuteurs";
            this.lblAuteurs.Size = new System.Drawing.Size(58, 13);
            this.lblAuteurs.TabIndex = 5;
            this.lblAuteurs.Text = "Auteur(s) : ";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(15, 70);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(37, 13);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "Titre : ";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(85, 70);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.ReadOnly = true;
            this.txtTitre.Size = new System.Drawing.Size(158, 20);
            this.txtTitre.TabIndex = 3;
            // 
            // txtAuteurs
            // 
            this.txtAuteurs.Location = new System.Drawing.Point(85, 111);
            this.txtAuteurs.Name = "txtAuteurs";
            this.txtAuteurs.ReadOnly = true;
            this.txtAuteurs.Size = new System.Drawing.Size(158, 20);
            this.txtAuteurs.TabIndex = 2;
            // 
            // lblCodeExemplaire
            // 
            this.lblCodeExemplaire.AutoSize = true;
            this.lblCodeExemplaire.Location = new System.Drawing.Point(15, 33);
            this.lblCodeExemplaire.Name = "lblCodeExemplaire";
            this.lblCodeExemplaire.Size = new System.Drawing.Size(41, 13);
            this.lblCodeExemplaire.TabIndex = 1;
            this.lblCodeExemplaire.Text = "Code : ";
            // 
            // btnValider
            // 
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(121, 128);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // grpRetour
            // 
            this.grpRetour.Controls.Add(this.lblDateEmprunt);
            this.grpRetour.Controls.Add(this.lblAdherent);
            this.grpRetour.Controls.Add(this.txtDateEmprunt);
            this.grpRetour.Controls.Add(this.btnValider);
            this.grpRetour.Controls.Add(this.txtAdherent);
            this.grpRetour.Location = new System.Drawing.Point(388, 69);
            this.grpRetour.Name = "grpRetour";
            this.grpRetour.Size = new System.Drawing.Size(331, 176);
            this.grpRetour.TabIndex = 7;
            this.grpRetour.TabStop = false;
            this.grpRetour.Text = "Retour : ";
            // 
            // lblDateEmprunt
            // 
            this.lblDateEmprunt.AutoSize = true;
            this.lblDateEmprunt.Location = new System.Drawing.Point(28, 70);
            this.lblDateEmprunt.Name = "lblDateEmprunt";
            this.lblDateEmprunt.Size = new System.Drawing.Size(80, 13);
            this.lblDateEmprunt.TabIndex = 9;
            this.lblDateEmprunt.Text = "Date emprunt : ";
            // 
            // lblAdherent
            // 
            this.lblAdherent.AutoSize = true;
            this.lblAdherent.Location = new System.Drawing.Point(28, 30);
            this.lblAdherent.Name = "lblAdherent";
            this.lblAdherent.Size = new System.Drawing.Size(59, 13);
            this.lblAdherent.TabIndex = 8;
            this.lblAdherent.Text = "Adhérent : ";
            // 
            // txtDateEmprunt
            // 
            this.txtDateEmprunt.Location = new System.Drawing.Point(108, 70);
            this.txtDateEmprunt.Name = "txtDateEmprunt";
            this.txtDateEmprunt.ReadOnly = true;
            this.txtDateEmprunt.Size = new System.Drawing.Size(193, 20);
            this.txtDateEmprunt.TabIndex = 1;
            // 
            // txtAdherent
            // 
            this.txtAdherent.Location = new System.Drawing.Point(108, 30);
            this.txtAdherent.Name = "txtAdherent";
            this.txtAdherent.ReadOnly = true;
            this.txtAdherent.Size = new System.Drawing.Size(193, 20);
            this.txtAdherent.TabIndex = 0;
            // 
            // lblBibliotheque
            // 
            this.lblBibliotheque.AutoSize = true;
            this.lblBibliotheque.Location = new System.Drawing.Point(19, 24);
            this.lblBibliotheque.Name = "lblBibliotheque";
            this.lblBibliotheque.Size = new System.Drawing.Size(75, 13);
            this.lblBibliotheque.TabIndex = 8;
            this.lblBibliotheque.Text = "lblBibliotheque";
            // 
            // RetourIhm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 272);
            this.Controls.Add(this.lblBibliotheque);
            this.Controls.Add(this.grpRetour);
            this.Controls.Add(this.groupBox2);
            this.Name = "RetourIhm";
            this.Text = "Biblio 63 - Retour";
            this.Load += new System.EventHandler(this.RetourIhm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpRetour.ResumeLayout(false);
            this.grpRetour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodeExemplaire;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAuteurs;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtAuteurs;
        private System.Windows.Forms.Label lblCodeExemplaire;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox grpRetour;
        private System.Windows.Forms.Label lblDateEmprunt;
        private System.Windows.Forms.Label lblAdherent;
        private System.Windows.Forms.TextBox txtDateEmprunt;
        private System.Windows.Forms.TextBox txtAdherent;
        private System.Windows.Forms.Label lblBibliotheque;
    }
}