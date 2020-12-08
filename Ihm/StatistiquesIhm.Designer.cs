namespace Biblio
{
    partial class StatistiquesIhm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatistiquesIhm));
            this.grpCriteresImpression = new System.Windows.Forms.GroupBox();
            this.cbBibliotheque = new System.Windows.Forms.ComboBox();
            this.cbAnnee = new System.Windows.Forms.ComboBox();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.lblBibliotheque = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.btnAppercu = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.grpCriteresImpression.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCriteresImpression
            // 
            this.grpCriteresImpression.Controls.Add(this.cbBibliotheque);
            this.grpCriteresImpression.Controls.Add(this.cbAnnee);
            this.grpCriteresImpression.Controls.Add(this.lblAnnee);
            this.grpCriteresImpression.Controls.Add(this.lblBibliotheque);
            this.grpCriteresImpression.Location = new System.Drawing.Point(12, 12);
            this.grpCriteresImpression.Name = "grpCriteresImpression";
            this.grpCriteresImpression.Size = new System.Drawing.Size(472, 84);
            this.grpCriteresImpression.TabIndex = 0;
            this.grpCriteresImpression.TabStop = false;
            this.grpCriteresImpression.Text = "Critères d\'impression : ";
            // 
            // cbBibliotheque
            // 
            this.cbBibliotheque.FormattingEnabled = true;
            this.cbBibliotheque.Items.AddRange(new object[] {
            "Toutes"});
            this.cbBibliotheque.Location = new System.Drawing.Point(113, 31);
            this.cbBibliotheque.Name = "cbBibliotheque";
            this.cbBibliotheque.Size = new System.Drawing.Size(121, 21);
            this.cbBibliotheque.TabIndex = 5;
            this.cbBibliotheque.SelectedIndexChanged += new System.EventHandler(this.cbBibliotheque_SelectedIndexChanged);
            // 
            // cbAnnee
            // 
            this.cbAnnee.FormattingEnabled = true;
            this.cbAnnee.Location = new System.Drawing.Point(331, 34);
            this.cbAnnee.Name = "cbAnnee";
            this.cbAnnee.Size = new System.Drawing.Size(121, 21);
            this.cbAnnee.TabIndex = 4;
            this.cbAnnee.SelectedIndexChanged += new System.EventHandler(this.cbAnnee_SelectedIndexChanged);
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Location = new System.Drawing.Point(264, 34);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(47, 13);
            this.lblAnnee.TabIndex = 3;
            this.lblAnnee.Text = "Année : ";
            // 
            // lblBibliotheque
            // 
            this.lblBibliotheque.AutoSize = true;
            this.lblBibliotheque.Location = new System.Drawing.Point(22, 31);
            this.lblBibliotheque.Name = "lblBibliotheque";
            this.lblBibliotheque.Size = new System.Drawing.Size(74, 13);
            this.lblBibliotheque.TabIndex = 2;
            this.lblBibliotheque.Text = "Bibliotheque : ";
            // 
            // printDocument
            // 
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(297, 132);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(75, 23);
            this.btnImprimer.TabIndex = 2;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // btnAppercu
            // 
            this.btnAppercu.Location = new System.Drawing.Point(114, 132);
            this.btnAppercu.Name = "btnAppercu";
            this.btnAppercu.Size = new System.Drawing.Size(75, 23);
            this.btnAppercu.TabIndex = 3;
            this.btnAppercu.Text = "Aperçu";
            this.btnAppercu.UseVisualStyleBackColor = true;
            this.btnAppercu.Click += new System.EventHandler(this.btnAppercu_Click);
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
            // StatistiquesIhm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 197);
            this.Controls.Add(this.btnAppercu);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.grpCriteresImpression);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StatistiquesIhm";
            this.Text = "Biblio 63 - Statistiques";
            this.Load += new System.EventHandler(this.StatistiquesIhm_Load);
            this.grpCriteresImpression.ResumeLayout(false);
            this.grpCriteresImpression.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCriteresImpression;
        private System.Windows.Forms.ComboBox cbBibliotheque;
        private System.Windows.Forms.ComboBox cbAnnee;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblBibliotheque;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button btnAppercu;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}