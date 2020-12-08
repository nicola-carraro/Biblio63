namespace Biblio
{
    partial class LivreIhm
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
            this.components = new System.ComponentModel.Container();
            this.grpLivre = new System.Windows.Forms.GroupBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtAuteurs = new System.Windows.Forms.TextBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblAuteurs = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibliothequeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.exemplaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpExemplaires = new System.Windows.Forms.GroupBox();
            this.grpLivre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exemplaireBindingSource)).BeginInit();
            this.grpExemplaires.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLivre
            // 
            this.grpLivre.Controls.Add(this.txtTheme);
            this.grpLivre.Controls.Add(this.label1);
            this.grpLivre.Controls.Add(this.txtIsbn);
            this.grpLivre.Controls.Add(this.txtAuteurs);
            this.grpLivre.Controls.Add(this.txtTitre);
            this.grpLivre.Controls.Add(this.lblIsbn);
            this.grpLivre.Controls.Add(this.lblAuteurs);
            this.grpLivre.Controls.Add(this.lblTitre);
            this.grpLivre.Location = new System.Drawing.Point(30, 24);
            this.grpLivre.Name = "grpLivre";
            this.grpLivre.Size = new System.Drawing.Size(637, 257);
            this.grpLivre.TabIndex = 0;
            this.grpLivre.TabStop = false;
            this.grpLivre.Text = "Livre : ";
            this.grpLivre.Enter += new System.EventHandler(this.grpLivre_Enter);
            // 
            // txtTheme
            // 
            this.txtTheme.Location = new System.Drawing.Point(93, 147);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.ReadOnly = true;
            this.txtTheme.Size = new System.Drawing.Size(497, 20);
            this.txtTheme.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thème : ";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(93, 111);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.ReadOnly = true;
            this.txtIsbn.Size = new System.Drawing.Size(497, 20);
            this.txtIsbn.TabIndex = 5;
            // 
            // txtAuteurs
            // 
            this.txtAuteurs.Location = new System.Drawing.Point(93, 68);
            this.txtAuteurs.Name = "txtAuteurs";
            this.txtAuteurs.ReadOnly = true;
            this.txtAuteurs.Size = new System.Drawing.Size(497, 20);
            this.txtAuteurs.TabIndex = 4;
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(93, 28);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.ReadOnly = true;
            this.txtTitre.Size = new System.Drawing.Size(497, 20);
            this.txtTitre.TabIndex = 3;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(11, 111);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(41, 13);
            this.lblIsbn.TabIndex = 2;
            this.lblIsbn.Text = "ISBN : ";
            // 
            // lblAuteurs
            // 
            this.lblAuteurs.AutoSize = true;
            this.lblAuteurs.Location = new System.Drawing.Point(11, 75);
            this.lblAuteurs.Name = "lblAuteurs";
            this.lblAuteurs.Size = new System.Drawing.Size(58, 13);
            this.lblAuteurs.TabIndex = 1;
            this.lblAuteurs.Text = "Auteur(s) : ";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(11, 28);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(37, 13);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Titre : ";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.bibliothequeDataGridViewTextBoxColumn,
            this.disponibleDataGridViewCheckBoxColumn});
            this.dataGridView.DataSource = this.exemplaireBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(18, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.Size = new System.Drawing.Size(637, 109);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseDoubleClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.FillWeight = 150F;
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bibliothequeDataGridViewTextBoxColumn
            // 
            this.bibliothequeDataGridViewTextBoxColumn.DataPropertyName = "Bibliotheque";
            this.bibliothequeDataGridViewTextBoxColumn.HeaderText = "Bibliotheque";
            this.bibliothequeDataGridViewTextBoxColumn.Name = "bibliothequeDataGridViewTextBoxColumn";
            this.bibliothequeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bibliothequeDataGridViewTextBoxColumn.Width = 400;
            // 
            // disponibleDataGridViewCheckBoxColumn
            // 
            this.disponibleDataGridViewCheckBoxColumn.DataPropertyName = "Disponible";
            this.disponibleDataGridViewCheckBoxColumn.HeaderText = "Disponible";
            this.disponibleDataGridViewCheckBoxColumn.Name = "disponibleDataGridViewCheckBoxColumn";
            this.disponibleDataGridViewCheckBoxColumn.ReadOnly = true;
            this.disponibleDataGridViewCheckBoxColumn.Width = 105;
            // 
            // exemplaireBindingSource
            // 
            this.exemplaireBindingSource.DataSource = typeof(Biblio.Exemplaire);
            // 
            // grpExemplaires
            // 
            this.grpExemplaires.Controls.Add(this.dataGridView);
            this.grpExemplaires.Location = new System.Drawing.Point(12, 287);
            this.grpExemplaires.Name = "grpExemplaires";
            this.grpExemplaires.Size = new System.Drawing.Size(679, 128);
            this.grpExemplaires.TabIndex = 7;
            this.grpExemplaires.TabStop = false;
            this.grpExemplaires.Text = "Exemplaires : ";
            // 
            // LivreIhm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.grpExemplaires);
            this.Controls.Add(this.grpLivre);
            this.Name = "LivreIhm";
            this.Text = "Biblio 63 - Livre";
            this.Load += new System.EventHandler(this.ListeExemplairesIhm_Load);
            this.grpLivre.ResumeLayout(false);
            this.grpLivre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exemplaireBindingSource)).EndInit();
            this.grpExemplaires.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLivre;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtAuteurs;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblAuteurs;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.BindingSource exemplaireBindingSource;
        private System.Windows.Forms.GroupBox grpExemplaires;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bibliothequeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn disponibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTheme;
    }
}