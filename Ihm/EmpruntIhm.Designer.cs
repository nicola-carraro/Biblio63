namespace Biblio
{
    partial class EmpruntIhm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpruntIhm));
            this.grpAdherent = new System.Windows.Forms.GroupBox();
            this.lblBloque = new System.Windows.Forms.Label();
            this.grpInfoAdherent = new System.Windows.Forms.GroupBox();
            this.grpAdresse = new System.Windows.Forms.GroupBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.grpNom = new System.Windows.Forms.GroupBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.grpPrenom = new System.Windows.Forms.GroupBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.grpNumAdherent = new System.Windows.Forms.GroupBox();
            this.txtNumeroAdherent = new System.Windows.Forms.TextBox();
            this.btnRechercherAdherent = new System.Windows.Forms.Button();
            this.grpEmprunts = new System.Windows.Forms.GroupBox();
            this.lblRetard = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtEmpruntsTotal = new System.Windows.Forms.TextBox();
            this.txtEmpruntsEnRetard = new System.Windows.Forms.TextBox();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.lstEmprunts = new System.Windows.Forms.ListBox();
            this.grpCodeExemplaire = new System.Windows.Forms.GroupBox();
            this.txtCodeExemplaire = new System.Windows.Forms.TextBox();
            this.btnRechercherExemplaire = new System.Windows.Forms.Button();
            this.grpExemplaire = new System.Windows.Forms.GroupBox();
            this.grpBibliotheque = new System.Windows.Forms.GroupBox();
            this.txtBibliotheque = new System.Windows.Forms.TextBox();
            this.grpInfoExemplaire = new System.Windows.Forms.GroupBox();
            this.grpEtat = new System.Windows.Forms.GroupBox();
            this.btnEmprunter = new System.Windows.Forms.Button();
            this.txtDisponible = new System.Windows.Forms.TextBox();
            this.grpAuteurs = new System.Windows.Forms.GroupBox();
            this.txtAuteur = new System.Windows.Forms.TextBox();
            this.grpTitre = new System.Windows.Forms.GroupBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpAdherent.SuspendLayout();
            this.grpInfoAdherent.SuspendLayout();
            this.grpAdresse.SuspendLayout();
            this.grpNom.SuspendLayout();
            this.grpPrenom.SuspendLayout();
            this.grpNumAdherent.SuspendLayout();
            this.grpEmprunts.SuspendLayout();
            this.grpCodeExemplaire.SuspendLayout();
            this.grpExemplaire.SuspendLayout();
            this.grpBibliotheque.SuspendLayout();
            this.grpInfoExemplaire.SuspendLayout();
            this.grpEtat.SuspendLayout();
            this.grpAuteurs.SuspendLayout();
            this.grpTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdherent
            // 
            this.grpAdherent.Controls.Add(this.lblBloque);
            this.grpAdherent.Controls.Add(this.grpInfoAdherent);
            this.grpAdherent.Controls.Add(this.grpNumAdherent);
            this.grpAdherent.Location = new System.Drawing.Point(12, 23);
            this.grpAdherent.Name = "grpAdherent";
            this.grpAdherent.Size = new System.Drawing.Size(520, 434);
            this.grpAdherent.TabIndex = 0;
            this.grpAdherent.TabStop = false;
            this.grpAdherent.Text = "Adhérent : ";
            // 
            // lblBloque
            // 
            this.lblBloque.AutoSize = true;
            this.lblBloque.ForeColor = System.Drawing.Color.Red;
            this.lblBloque.Location = new System.Drawing.Point(369, 52);
            this.lblBloque.Name = "lblBloque";
            this.lblBloque.Size = new System.Drawing.Size(105, 13);
            this.lblBloque.TabIndex = 2;
            this.lblBloque.Text = "COMPTE BLOQUÉ !";
            this.lblBloque.Visible = false;
            // 
            // grpInfoAdherent
            // 
            this.grpInfoAdherent.Controls.Add(this.grpAdresse);
            this.grpInfoAdherent.Controls.Add(this.grpNom);
            this.grpInfoAdherent.Controls.Add(this.grpPrenom);
            this.grpInfoAdherent.Location = new System.Drawing.Point(27, 108);
            this.grpInfoAdherent.Name = "grpInfoAdherent";
            this.grpInfoAdherent.Size = new System.Drawing.Size(464, 247);
            this.grpInfoAdherent.TabIndex = 1;
            this.grpInfoAdherent.TabStop = false;
            this.grpInfoAdherent.Text = "Informations : ";
            // 
            // grpAdresse
            // 
            this.grpAdresse.Controls.Add(this.txtAdresse);
            this.grpAdresse.Location = new System.Drawing.Point(15, 148);
            this.grpAdresse.Name = "grpAdresse";
            this.grpAdresse.Size = new System.Drawing.Size(432, 48);
            this.grpAdresse.TabIndex = 5;
            this.grpAdresse.TabStop = false;
            this.grpAdresse.Text = "Adresse : ";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(28, 19);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.ReadOnly = true;
            this.txtAdresse.Size = new System.Drawing.Size(398, 20);
            this.txtAdresse.TabIndex = 0;
            // 
            // grpNom
            // 
            this.grpNom.Controls.Add(this.txtNom);
            this.grpNom.Location = new System.Drawing.Point(15, 84);
            this.grpNom.Name = "grpNom";
            this.grpNom.Size = new System.Drawing.Size(432, 48);
            this.grpNom.TabIndex = 0;
            this.grpNom.TabStop = false;
            this.grpNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(28, 19);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(398, 20);
            this.txtNom.TabIndex = 0;
            // 
            // grpPrenom
            // 
            this.grpPrenom.Controls.Add(this.txtPrenom);
            this.grpPrenom.Location = new System.Drawing.Point(15, 16);
            this.grpPrenom.Name = "grpPrenom";
            this.grpPrenom.Size = new System.Drawing.Size(432, 53);
            this.grpPrenom.TabIndex = 4;
            this.grpPrenom.TabStop = false;
            this.grpPrenom.Text = "Prénom : ";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(30, 21);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(396, 20);
            this.txtPrenom.TabIndex = 1;
            // 
            // grpNumAdherent
            // 
            this.grpNumAdherent.Controls.Add(this.txtNumeroAdherent);
            this.grpNumAdherent.Controls.Add(this.btnRechercherAdherent);
            this.grpNumAdherent.Location = new System.Drawing.Point(27, 30);
            this.grpNumAdherent.Name = "grpNumAdherent";
            this.grpNumAdherent.Size = new System.Drawing.Size(303, 56);
            this.grpNumAdherent.TabIndex = 0;
            this.grpNumAdherent.TabStop = false;
            this.grpNumAdherent.Text = "Numéro d\'adhérent : ";
            // 
            // txtNumeroAdherent
            // 
            this.txtNumeroAdherent.Location = new System.Drawing.Point(15, 22);
            this.txtNumeroAdherent.Name = "txtNumeroAdherent";
            this.txtNumeroAdherent.Size = new System.Drawing.Size(149, 20);
            this.txtNumeroAdherent.TabIndex = 1;
            this.txtNumeroAdherent.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumeroAdherent_Validating);
            // 
            // btnRechercherAdherent
            // 
            this.btnRechercherAdherent.Location = new System.Drawing.Point(206, 19);
            this.btnRechercherAdherent.Name = "btnRechercherAdherent";
            this.btnRechercherAdherent.Size = new System.Drawing.Size(75, 23);
            this.btnRechercherAdherent.TabIndex = 0;
            this.btnRechercherAdherent.Text = "Rechercher";
            this.btnRechercherAdherent.UseVisualStyleBackColor = true;
            this.btnRechercherAdherent.Click += new System.EventHandler(this.btnRechercherAdherent_Click);
            // 
            // grpEmprunts
            // 
            this.grpEmprunts.Controls.Add(this.lblRetard);
            this.grpEmprunts.Controls.Add(this.lblTotal);
            this.grpEmprunts.Controls.Add(this.txtEmpruntsTotal);
            this.grpEmprunts.Controls.Add(this.txtEmpruntsEnRetard);
            this.grpEmprunts.Controls.Add(this.btnImprimer);
            this.grpEmprunts.Controls.Add(this.lstEmprunts);
            this.grpEmprunts.Location = new System.Drawing.Point(12, 463);
            this.grpEmprunts.Name = "grpEmprunts";
            this.grpEmprunts.Size = new System.Drawing.Size(1042, 192);
            this.grpEmprunts.TabIndex = 0;
            this.grpEmprunts.TabStop = false;
            this.grpEmprunts.Text = "Prêts en cours :";
            // 
            // lblRetard
            // 
            this.lblRetard.AutoSize = true;
            this.lblRetard.Location = new System.Drawing.Point(379, 42);
            this.lblRetard.Name = "lblRetard";
            this.lblRetard.Size = new System.Drawing.Size(59, 13);
            this.lblRetard.TabIndex = 8;
            this.lblRetard.Text = "En retard : ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(14, 39);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total : ";
            // 
            // txtEmpruntsTotal
            // 
            this.txtEmpruntsTotal.Location = new System.Drawing.Point(67, 39);
            this.txtEmpruntsTotal.Name = "txtEmpruntsTotal";
            this.txtEmpruntsTotal.ReadOnly = true;
            this.txtEmpruntsTotal.Size = new System.Drawing.Size(48, 20);
            this.txtEmpruntsTotal.TabIndex = 6;
            // 
            // txtEmpruntsEnRetard
            // 
            this.txtEmpruntsEnRetard.Location = new System.Drawing.Point(456, 42);
            this.txtEmpruntsEnRetard.Name = "txtEmpruntsEnRetard";
            this.txtEmpruntsEnRetard.ReadOnly = true;
            this.txtEmpruntsEnRetard.Size = new System.Drawing.Size(64, 20);
            this.txtEmpruntsEnRetard.TabIndex = 5;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Enabled = false;
            this.btnImprimer.Location = new System.Drawing.Point(853, 42);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(128, 23);
            this.btnImprimer.TabIndex = 4;
            this.btnImprimer.Text = "Imprimer ticket";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // lstEmprunts
            // 
            this.lstEmprunts.FormattingEnabled = true;
            this.lstEmprunts.HorizontalScrollbar = true;
            this.lstEmprunts.Location = new System.Drawing.Point(17, 89);
            this.lstEmprunts.Name = "lstEmprunts";
            this.lstEmprunts.Size = new System.Drawing.Size(980, 69);
            this.lstEmprunts.TabIndex = 3;
            // 
            // grpCodeExemplaire
            // 
            this.grpCodeExemplaire.Controls.Add(this.txtCodeExemplaire);
            this.grpCodeExemplaire.Controls.Add(this.btnRechercherExemplaire);
            this.grpCodeExemplaire.Location = new System.Drawing.Point(34, 83);
            this.grpCodeExemplaire.Name = "grpCodeExemplaire";
            this.grpCodeExemplaire.Size = new System.Drawing.Size(451, 51);
            this.grpCodeExemplaire.TabIndex = 0;
            this.grpCodeExemplaire.TabStop = false;
            this.grpCodeExemplaire.Text = "Code : ";
            // 
            // txtCodeExemplaire
            // 
            this.txtCodeExemplaire.Location = new System.Drawing.Point(43, 13);
            this.txtCodeExemplaire.MaxLength = 10;
            this.txtCodeExemplaire.Name = "txtCodeExemplaire";
            this.txtCodeExemplaire.Size = new System.Drawing.Size(171, 20);
            this.txtCodeExemplaire.TabIndex = 2;
            this.txtCodeExemplaire.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodeExemplaire_Validating);
            // 
            // btnRechercherExemplaire
            // 
            this.btnRechercherExemplaire.Location = new System.Drawing.Point(293, 13);
            this.btnRechercherExemplaire.Name = "btnRechercherExemplaire";
            this.btnRechercherExemplaire.Size = new System.Drawing.Size(75, 23);
            this.btnRechercherExemplaire.TabIndex = 1;
            this.btnRechercherExemplaire.Text = "Rechercher";
            this.btnRechercherExemplaire.UseVisualStyleBackColor = true;
            this.btnRechercherExemplaire.Click += new System.EventHandler(this.btnRechercherExemplaire_Click);
            // 
            // grpExemplaire
            // 
            this.grpExemplaire.Controls.Add(this.grpBibliotheque);
            this.grpExemplaire.Controls.Add(this.grpInfoExemplaire);
            this.grpExemplaire.Controls.Add(this.grpCodeExemplaire);
            this.grpExemplaire.Location = new System.Drawing.Point(569, 28);
            this.grpExemplaire.Name = "grpExemplaire";
            this.grpExemplaire.Size = new System.Drawing.Size(520, 429);
            this.grpExemplaire.TabIndex = 1;
            this.grpExemplaire.TabStop = false;
            this.grpExemplaire.Text = "Exemplaire";
            // 
            // grpBibliotheque
            // 
            this.grpBibliotheque.Controls.Add(this.txtBibliotheque);
            this.grpBibliotheque.Location = new System.Drawing.Point(34, 19);
            this.grpBibliotheque.Name = "grpBibliotheque";
            this.grpBibliotheque.Size = new System.Drawing.Size(451, 48);
            this.grpBibliotheque.TabIndex = 3;
            this.grpBibliotheque.TabStop = false;
            this.grpBibliotheque.Text = "Bibliothèque";
            // 
            // txtBibliotheque
            // 
            this.txtBibliotheque.Location = new System.Drawing.Point(45, 15);
            this.txtBibliotheque.Name = "txtBibliotheque";
            this.txtBibliotheque.ReadOnly = true;
            this.txtBibliotheque.Size = new System.Drawing.Size(332, 20);
            this.txtBibliotheque.TabIndex = 2;
            // 
            // grpInfoExemplaire
            // 
            this.grpInfoExemplaire.Controls.Add(this.grpEtat);
            this.grpInfoExemplaire.Controls.Add(this.grpAuteurs);
            this.grpInfoExemplaire.Controls.Add(this.grpTitre);
            this.grpInfoExemplaire.Location = new System.Drawing.Point(34, 140);
            this.grpInfoExemplaire.Name = "grpInfoExemplaire";
            this.grpInfoExemplaire.Size = new System.Drawing.Size(451, 267);
            this.grpInfoExemplaire.TabIndex = 2;
            this.grpInfoExemplaire.TabStop = false;
            this.grpInfoExemplaire.Text = "Informations : ";
            // 
            // grpEtat
            // 
            this.grpEtat.Controls.Add(this.btnEmprunter);
            this.grpEtat.Controls.Add(this.txtDisponible);
            this.grpEtat.Location = new System.Drawing.Point(15, 183);
            this.grpEtat.Name = "grpEtat";
            this.grpEtat.Size = new System.Drawing.Size(391, 67);
            this.grpEtat.TabIndex = 7;
            this.grpEtat.TabStop = false;
            this.grpEtat.Text = "État : ";
            // 
            // btnEmprunter
            // 
            this.btnEmprunter.Enabled = false;
            this.btnEmprunter.Location = new System.Drawing.Point(247, 32);
            this.btnEmprunter.Name = "btnEmprunter";
            this.btnEmprunter.Size = new System.Drawing.Size(75, 23);
            this.btnEmprunter.TabIndex = 7;
            this.btnEmprunter.Text = "Emprunter";
            this.btnEmprunter.UseVisualStyleBackColor = true;
            this.btnEmprunter.Click += new System.EventHandler(this.btnEmprunter_Click);
            // 
            // txtDisponible
            // 
            this.txtDisponible.Location = new System.Drawing.Point(23, 35);
            this.txtDisponible.Name = "txtDisponible";
            this.txtDisponible.ReadOnly = true;
            this.txtDisponible.Size = new System.Drawing.Size(100, 20);
            this.txtDisponible.TabIndex = 5;
            // 
            // grpAuteurs
            // 
            this.grpAuteurs.Controls.Add(this.txtAuteur);
            this.grpAuteurs.Location = new System.Drawing.Point(15, 111);
            this.grpAuteurs.Name = "grpAuteurs";
            this.grpAuteurs.Size = new System.Drawing.Size(391, 62);
            this.grpAuteurs.TabIndex = 0;
            this.grpAuteurs.TabStop = false;
            this.grpAuteurs.Text = "Auteur(s) : ";
            // 
            // txtAuteur
            // 
            this.txtAuteur.Location = new System.Drawing.Point(28, 19);
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.ReadOnly = true;
            this.txtAuteur.Size = new System.Drawing.Size(331, 20);
            this.txtAuteur.TabIndex = 0;
            // 
            // grpTitre
            // 
            this.grpTitre.Controls.Add(this.txtTitre);
            this.grpTitre.Location = new System.Drawing.Point(15, 16);
            this.grpTitre.Name = "grpTitre";
            this.grpTitre.Size = new System.Drawing.Size(391, 79);
            this.grpTitre.TabIndex = 4;
            this.grpTitre.TabStop = false;
            this.grpTitre.Text = "Titre : ";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(30, 21);
            this.txtTitre.Multiline = true;
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.ReadOnly = true;
            this.txtTitre.Size = new System.Drawing.Size(332, 35);
            this.txtTitre.TabIndex = 1;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // EmpruntIhm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 679);
            this.Controls.Add(this.grpExemplaire);
            this.Controls.Add(this.grpAdherent);
            this.Controls.Add(this.grpEmprunts);
            this.Name = "EmpruntIhm";
            this.Text = "Biblio 63 - Emprunt";
            this.Load += new System.EventHandler(this.EmpruntIhm_Load);
            this.grpAdherent.ResumeLayout(false);
            this.grpAdherent.PerformLayout();
            this.grpInfoAdherent.ResumeLayout(false);
            this.grpAdresse.ResumeLayout(false);
            this.grpAdresse.PerformLayout();
            this.grpNom.ResumeLayout(false);
            this.grpNom.PerformLayout();
            this.grpPrenom.ResumeLayout(false);
            this.grpPrenom.PerformLayout();
            this.grpNumAdherent.ResumeLayout(false);
            this.grpNumAdherent.PerformLayout();
            this.grpEmprunts.ResumeLayout(false);
            this.grpEmprunts.PerformLayout();
            this.grpCodeExemplaire.ResumeLayout(false);
            this.grpCodeExemplaire.PerformLayout();
            this.grpExemplaire.ResumeLayout(false);
            this.grpBibliotheque.ResumeLayout(false);
            this.grpBibliotheque.PerformLayout();
            this.grpInfoExemplaire.ResumeLayout(false);
            this.grpEtat.ResumeLayout(false);
            this.grpEtat.PerformLayout();
            this.grpAuteurs.ResumeLayout(false);
            this.grpAuteurs.PerformLayout();
            this.grpTitre.ResumeLayout(false);
            this.grpTitre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdherent;
        private System.Windows.Forms.Button btnRechercherAdherent;
        private System.Windows.Forms.Button btnRechercherExemplaire;
        private System.Windows.Forms.GroupBox grpCodeExemplaire;
        private System.Windows.Forms.GroupBox grpNumAdherent;
        private System.Windows.Forms.TextBox txtNumeroAdherent;
        private System.Windows.Forms.GroupBox grpExemplaire;
        private System.Windows.Forms.GroupBox grpInfoAdherent;
        private System.Windows.Forms.GroupBox grpNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox grpEmprunts;
        private System.Windows.Forms.GroupBox grpPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.ListBox lstEmprunts;
        private System.Windows.Forms.TextBox txtCodeExemplaire;
        private System.Windows.Forms.GroupBox grpInfoExemplaire;
        private System.Windows.Forms.GroupBox grpAuteurs;
        private System.Windows.Forms.TextBox txtAuteur;
        private System.Windows.Forms.GroupBox grpTitre;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Button btnEmprunter;
        private System.Windows.Forms.TextBox txtDisponible;
        private System.Windows.Forms.Button btnImprimer;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.GroupBox grpAdresse;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblRetard;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtEmpruntsTotal;
        private System.Windows.Forms.TextBox txtEmpruntsEnRetard;
        private System.Windows.Forms.Label lblBloque;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpBibliotheque;
        private System.Windows.Forms.TextBox txtBibliotheque;
        private System.Windows.Forms.GroupBox grpEtat;
    }
}