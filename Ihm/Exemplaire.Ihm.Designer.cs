namespace Biblio
{
    partial class ExemplaireIhm
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
            this.grpLivre = new System.Windows.Forms.GroupBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.txtAuteur = new System.Windows.Forms.TextBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblAuteurs = new System.Windows.Forms.Label();
            this.grpExemplaire = new System.Windows.Forms.GroupBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.comboBoxEmplacement = new System.Windows.Forms.ComboBox();
            this.comboBoxBibliotheque = new System.Windows.Forms.ComboBox();
            this.lblEmplacement = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblBibliotheque = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpLivre.SuspendLayout();
            this.grpExemplaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLivre
            // 
            this.grpLivre.Controls.Add(this.txtTheme);
            this.grpLivre.Controls.Add(this.label1);
            this.grpLivre.Controls.Add(this.txtIsbn);
            this.grpLivre.Controls.Add(this.lblIsbn);
            this.grpLivre.Controls.Add(this.txtAuteur);
            this.grpLivre.Controls.Add(this.txtTitre);
            this.grpLivre.Controls.Add(this.lblTitre);
            this.grpLivre.Controls.Add(this.lblAuteurs);
            this.grpLivre.Location = new System.Drawing.Point(31, 38);
            this.grpLivre.Name = "grpLivre";
            this.grpLivre.Size = new System.Drawing.Size(678, 160);
            this.grpLivre.TabIndex = 0;
            this.grpLivre.TabStop = false;
            this.grpLivre.Text = "Livre : ";
            // 
            // txtTheme
            // 
            this.txtTheme.Location = new System.Drawing.Point(88, 115);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.ReadOnly = true;
            this.txtTheme.Size = new System.Drawing.Size(553, 20);
            this.txtTheme.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thème : ";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(88, 89);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.ReadOnly = true;
            this.txtIsbn.Size = new System.Drawing.Size(553, 20);
            this.txtIsbn.TabIndex = 5;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(23, 82);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(41, 13);
            this.lblIsbn.TabIndex = 4;
            this.lblIsbn.Text = "ISBN : ";
            // 
            // txtAuteur
            // 
            this.txtAuteur.Location = new System.Drawing.Point(88, 23);
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.ReadOnly = true;
            this.txtAuteur.Size = new System.Drawing.Size(553, 20);
            this.txtAuteur.TabIndex = 3;
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(88, 56);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.ReadOnly = true;
            this.txtTitre.Size = new System.Drawing.Size(553, 20);
            this.txtTitre.TabIndex = 2;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(21, 54);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(37, 13);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Titre : ";
            // 
            // lblAuteurs
            // 
            this.lblAuteurs.AutoSize = true;
            this.lblAuteurs.Location = new System.Drawing.Point(21, 26);
            this.lblAuteurs.Name = "lblAuteurs";
            this.lblAuteurs.Size = new System.Drawing.Size(58, 13);
            this.lblAuteurs.TabIndex = 0;
            this.lblAuteurs.Text = "Auteur(s) : ";
            // 
            // grpExemplaire
            // 
            this.grpExemplaire.Controls.Add(this.btnModifier);
            this.grpExemplaire.Controls.Add(this.comboBoxEmplacement);
            this.grpExemplaire.Controls.Add(this.comboBoxBibliotheque);
            this.grpExemplaire.Controls.Add(this.lblEmplacement);
            this.grpExemplaire.Controls.Add(this.lblCode);
            this.grpExemplaire.Controls.Add(this.lblBibliotheque);
            this.grpExemplaire.Controls.Add(this.lblNumero);
            this.grpExemplaire.Controls.Add(this.txtCode);
            this.grpExemplaire.Controls.Add(this.txtNumero);
            this.grpExemplaire.Location = new System.Drawing.Point(31, 218);
            this.grpExemplaire.Name = "grpExemplaire";
            this.grpExemplaire.Size = new System.Drawing.Size(666, 183);
            this.grpExemplaire.TabIndex = 1;
            this.grpExemplaire.TabStop = false;
            this.grpExemplaire.Text = "Exemplaire";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(293, 134);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // comboBoxEmplacement
            // 
            this.comboBoxEmplacement.Enabled = false;
            this.comboBoxEmplacement.FormattingEnabled = true;
            this.comboBoxEmplacement.Location = new System.Drawing.Point(465, 60);
            this.comboBoxEmplacement.Name = "comboBoxEmplacement";
            this.comboBoxEmplacement.Size = new System.Drawing.Size(176, 21);
            this.comboBoxEmplacement.TabIndex = 8;
            this.comboBoxEmplacement.SelectionChangeCommitted += new System.EventHandler(this.comboBoxEmplacement_SelectionChangeCommitted);
            // 
            // comboBoxBibliotheque
            // 
            this.comboBoxBibliotheque.Enabled = false;
            this.comboBoxBibliotheque.FormattingEnabled = true;
            this.comboBoxBibliotheque.Location = new System.Drawing.Point(110, 60);
            this.comboBoxBibliotheque.Name = "comboBoxBibliotheque";
            this.comboBoxBibliotheque.Size = new System.Drawing.Size(176, 21);
            this.comboBoxBibliotheque.TabIndex = 7;
            this.comboBoxBibliotheque.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBibliotheque_SelectionChangeCommitted);
            // 
            // lblEmplacement
            // 
            this.lblEmplacement.AutoSize = true;
            this.lblEmplacement.Location = new System.Drawing.Point(349, 63);
            this.lblEmplacement.Name = "lblEmplacement";
            this.lblEmplacement.Size = new System.Drawing.Size(80, 13);
            this.lblEmplacement.TabIndex = 6;
            this.lblEmplacement.Text = "Emplacement : ";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(349, 22);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(41, 13);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Code : ";
            // 
            // lblBibliotheque
            // 
            this.lblBibliotheque.AutoSize = true;
            this.lblBibliotheque.Location = new System.Drawing.Point(11, 60);
            this.lblBibliotheque.Name = "lblBibliotheque";
            this.lblBibliotheque.Size = new System.Drawing.Size(74, 13);
            this.lblBibliotheque.TabIndex = 4;
            this.lblBibliotheque.Text = "Bibliothèque : ";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(11, 22);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(53, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numéro : ";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(465, 22);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(176, 20);
            this.txtCode.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(110, 22);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(123, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(324, 445);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ExemplaireIhm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 512);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpExemplaire);
            this.Controls.Add(this.grpLivre);
            this.Name = "ExemplaireIhm";
            this.Text = "Biblio 63 - Exemplaire";
            this.Load += new System.EventHandler(this.ExemplaireIhm_Load);
            this.grpLivre.ResumeLayout(false);
            this.grpLivre.PerformLayout();
            this.grpExemplaire.ResumeLayout(false);
            this.grpExemplaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLivre;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.TextBox txtAuteur;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblAuteurs;
        private System.Windows.Forms.TextBox txtTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpExemplaire;
        private System.Windows.Forms.ComboBox comboBoxEmplacement;
        private System.Windows.Forms.ComboBox comboBoxBibliotheque;
        private System.Windows.Forms.Label lblEmplacement;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblBibliotheque;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnModifier;
    }
}