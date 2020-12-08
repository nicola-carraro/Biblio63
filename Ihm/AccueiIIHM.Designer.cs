namespace Biblio
{
    partial class AccueilIhm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.connexionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnexionAdherentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionAgentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretEmpruntMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretRetourMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretStatistiquesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretRetardsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRechercher = new System.Windows.Forms.GroupBox();
            this.btnAvance = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.exemplaireMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplaireGererMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.grpRechercher.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionMenuItem,
            this.pretMenuItem,
            this.exemplaireMenuItem,
            this.livreToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(457, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // connexionMenuItem
            // 
            this.connexionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnexionAdherentMenuItem,
            this.connexionAgentMenuItem});
            this.connexionMenuItem.Name = "connexionMenuItem";
            this.connexionMenuItem.Size = new System.Drawing.Size(77, 20);
            this.connexionMenuItem.Text = "Connexion";
            // 
            // ConnexionAdherentMenuItem
            // 
            this.ConnexionAdherentMenuItem.Name = "ConnexionAdherentMenuItem";
            this.ConnexionAdherentMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ConnexionAdherentMenuItem.Text = "Adherent";
            // 
            // connexionAgentMenuItem
            // 
            this.connexionAgentMenuItem.Name = "connexionAgentMenuItem";
            this.connexionAgentMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connexionAgentMenuItem.Text = "Agent";
            // 
            // pretMenuItem
            // 
            this.pretMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretEmpruntMenuItem,
            this.pretRetourMenuItem,
            this.pretStatistiquesMenuItem,
            this.pretRetardsMenuItem});
            this.pretMenuItem.Name = "pretMenuItem";
            this.pretMenuItem.Size = new System.Drawing.Size(40, 20);
            this.pretMenuItem.Text = "Prêt";
            // 
            // pretEmpruntMenuItem
            // 
            this.pretEmpruntMenuItem.Name = "pretEmpruntMenuItem";
            this.pretEmpruntMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretEmpruntMenuItem.Text = "Emprunt";
            this.pretEmpruntMenuItem.Click += new System.EventHandler(this.pretEmpruntMenuItem_Click);
            // 
            // pretRetourMenuItem
            // 
            this.pretRetourMenuItem.Name = "pretRetourMenuItem";
            this.pretRetourMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretRetourMenuItem.Text = "Retour";
            this.pretRetourMenuItem.Click += new System.EventHandler(this.pretRetourMenuItem_Click);
            // 
            // pretStatistiquesMenuItem
            // 
            this.pretStatistiquesMenuItem.Name = "pretStatistiquesMenuItem";
            this.pretStatistiquesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretStatistiquesMenuItem.Text = "Statistiques";
            this.pretStatistiquesMenuItem.Click += new System.EventHandler(this.pretStatistiquesMenuItem_Click);
            // 
            // pretRetardsMenuItem
            // 
            this.pretRetardsMenuItem.Name = "pretRetardsMenuItem";
            this.pretRetardsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretRetardsMenuItem.Text = "Retards";
            // 
            // grpRechercher
            // 
            this.grpRechercher.Controls.Add(this.btnAvance);
            this.grpRechercher.Controls.Add(this.btnEffacer);
            this.grpRechercher.Controls.Add(this.txtRecherche);
            this.grpRechercher.Controls.Add(this.btnRechercher);
            this.grpRechercher.Location = new System.Drawing.Point(26, 43);
            this.grpRechercher.Name = "grpRechercher";
            this.grpRechercher.Size = new System.Drawing.Size(397, 145);
            this.grpRechercher.TabIndex = 1;
            this.grpRechercher.TabStop = false;
            this.grpRechercher.Text = "Insérez quelques mots du titre : ";
            // 
            // btnAvance
            // 
            this.btnAvance.Location = new System.Drawing.Point(282, 90);
            this.btnAvance.Name = "btnAvance";
            this.btnAvance.Size = new System.Drawing.Size(75, 23);
            this.btnAvance.TabIndex = 3;
            this.btnAvance.Text = "Avancé";
            this.btnAvance.UseVisualStyleBackColor = true;
            this.btnAvance.Click += new System.EventHandler(this.btnAvance_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEffacer.Location = new System.Drawing.Point(163, 90);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(75, 23);
            this.btnEffacer.TabIndex = 2;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(40, 38);
            this.txtRecherche.MaxLength = 30;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(317, 20);
            this.txtRecherche.TabIndex = 0;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(40, 90);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 1;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // exemplaireMenuItem
            // 
            this.exemplaireMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exemplaireGererMenuItem});
            this.exemplaireMenuItem.Name = "exemplaireMenuItem";
            this.exemplaireMenuItem.Size = new System.Drawing.Size(77, 20);
            this.exemplaireMenuItem.Text = "Exemplaire";
            // 
            // livreToolStripMenuItem
            // 
            this.livreToolStripMenuItem.Name = "livreToolStripMenuItem";
            this.livreToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.livreToolStripMenuItem.Text = "Livre";
            // 
            // exemplaireGererMenuItem
            // 
            this.exemplaireGererMenuItem.Name = "exemplaireGererMenuItem";
            this.exemplaireGererMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exemplaireGererMenuItem.Text = "Gérer";
            // 
            // AccueilIhm
            // 
            this.AcceptButton = this.btnRechercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnEffacer;
            this.ClientSize = new System.Drawing.Size(457, 225);
            this.Controls.Add(this.grpRechercher);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "AccueilIhm";
            this.Text = "Biblio 63";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpRechercher.ResumeLayout(false);
            this.grpRechercher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem connexionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnexionAdherentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionAgentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretEmpruntMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretRetourMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretStatistiquesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretRetardsMenuItem;
        private System.Windows.Forms.GroupBox grpRechercher;
        private System.Windows.Forms.Button btnAvance;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.ToolStripMenuItem exemplaireMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exemplaireGererMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livreToolStripMenuItem;
    }
}

