namespace Biblio
{
    partial class RechercherLivresIhm
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
            this.grpIsbn = new System.Windows.Forms.GroupBox();
            this.btnIsbnEffacer = new System.Windows.Forms.Button();
            this.btnIsbnOk = new System.Windows.Forms.Button();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.grpCriteres = new System.Windows.Forms.GroupBox();
            this.btnListeThemes = new System.Windows.Forms.Button();
            this.btnCriteresEffacer = new System.Windows.Forms.Button();
            this.btnCriteresOK = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtAuteur = new System.Windows.Forms.TextBox();
            this.grpIsbn.SuspendLayout();
            this.grpCriteres.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIsbn
            // 
            this.grpIsbn.Controls.Add(this.btnIsbnEffacer);
            this.grpIsbn.Controls.Add(this.btnIsbnOk);
            this.grpIsbn.Controls.Add(this.txtIsbn);
            this.grpIsbn.Location = new System.Drawing.Point(31, 12);
            this.grpIsbn.Name = "grpIsbn";
            this.grpIsbn.Size = new System.Drawing.Size(456, 108);
            this.grpIsbn.TabIndex = 0;
            this.grpIsbn.TabStop = false;
            this.grpIsbn.Text = "ISBN : ";
            // 
            // btnIsbnEffacer
            // 
            this.btnIsbnEffacer.Location = new System.Drawing.Point(326, 66);
            this.btnIsbnEffacer.Name = "btnIsbnEffacer";
            this.btnIsbnEffacer.Size = new System.Drawing.Size(75, 23);
            this.btnIsbnEffacer.TabIndex = 3;
            this.btnIsbnEffacer.Text = "Effacer";
            this.btnIsbnEffacer.UseVisualStyleBackColor = true;
            // 
            // btnIsbnOk
            // 
            this.btnIsbnOk.Location = new System.Drawing.Point(52, 66);
            this.btnIsbnOk.Name = "btnIsbnOk";
            this.btnIsbnOk.Size = new System.Drawing.Size(75, 23);
            this.btnIsbnOk.TabIndex = 2;
            this.btnIsbnOk.Text = "OK";
            this.btnIsbnOk.UseVisualStyleBackColor = true;
            this.btnIsbnOk.Click += new System.EventHandler(this.btnIsbnOk_Click);
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(80, 29);
            this.txtIsbn.MaxLength = 13;
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(268, 20);
            this.txtIsbn.TabIndex = 1;
            // 
            // grpCriteres
            // 
            this.grpCriteres.Controls.Add(this.btnListeThemes);
            this.grpCriteres.Controls.Add(this.btnCriteresEffacer);
            this.grpCriteres.Controls.Add(this.btnCriteresOK);
            this.grpCriteres.Controls.Add(this.lblTitre);
            this.grpCriteres.Controls.Add(this.lblAuteur);
            this.grpCriteres.Controls.Add(this.txtTitre);
            this.grpCriteres.Controls.Add(this.txtAuteur);
            this.grpCriteres.Location = new System.Drawing.Point(31, 139);
            this.grpCriteres.Name = "grpCriteres";
            this.grpCriteres.Size = new System.Drawing.Size(456, 235);
            this.grpCriteres.TabIndex = 1;
            this.grpCriteres.TabStop = false;
            this.grpCriteres.Text = "Critères de recherche : ";
            // 
            // btnListeThemes
            // 
            this.btnListeThemes.Location = new System.Drawing.Point(306, 150);
            this.btnListeThemes.Name = "btnListeThemes";
            this.btnListeThemes.Size = new System.Drawing.Size(95, 23);
            this.btnListeThemes.TabIndex = 11;
            this.btnListeThemes.Text = "Liste des thèmes";
            this.btnListeThemes.UseVisualStyleBackColor = true;
            this.btnListeThemes.Click += new System.EventHandler(this.btnListeThemes_Click);
            // 
            // btnCriteresEffacer
            // 
            this.btnCriteresEffacer.Location = new System.Drawing.Point(176, 150);
            this.btnCriteresEffacer.Name = "btnCriteresEffacer";
            this.btnCriteresEffacer.Size = new System.Drawing.Size(75, 23);
            this.btnCriteresEffacer.TabIndex = 7;
            this.btnCriteresEffacer.Text = "Effacer";
            this.btnCriteresEffacer.UseVisualStyleBackColor = true;
            // 
            // btnCriteresOK
            // 
            this.btnCriteresOK.Location = new System.Drawing.Point(28, 150);
            this.btnCriteresOK.Name = "btnCriteresOK";
            this.btnCriteresOK.Size = new System.Drawing.Size(75, 23);
            this.btnCriteresOK.TabIndex = 6;
            this.btnCriteresOK.Text = "OK";
            this.btnCriteresOK.UseVisualStyleBackColor = true;
            this.btnCriteresOK.Click += new System.EventHandler(this.btnCriteresOK_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(25, 72);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(37, 13);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "Titre : ";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(25, 30);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(47, 13);
            this.lblAuteur.TabIndex = 3;
            this.lblAuteur.Text = "Auteur : ";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(90, 72);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(258, 20);
            this.txtTitre.TabIndex = 1;
            // 
            // txtAuteur
            // 
            this.txtAuteur.Location = new System.Drawing.Point(90, 30);
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.Size = new System.Drawing.Size(258, 20);
            this.txtAuteur.TabIndex = 0;
            // 
            // RechercherLivresIhm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.grpCriteres);
            this.Controls.Add(this.grpIsbn);
            this.Name = "RechercherLivresIhm";
            this.Text = "Biblio 63 - Rechercher Livres";
            this.grpIsbn.ResumeLayout(false);
            this.grpIsbn.PerformLayout();
            this.grpCriteres.ResumeLayout(false);
            this.grpCriteres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIsbn;
        private System.Windows.Forms.Button btnIsbnOk;
        private System.Windows.Forms.GroupBox grpCriteres;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtAuteur;
        private System.Windows.Forms.Button btnCriteresOK;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Button btnCriteresEffacer;
        private System.Windows.Forms.Button btnIsbnEffacer;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Button btnListeThemes;
    }
}