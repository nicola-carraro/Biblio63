using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Biblio
{
    public partial class EmpruntIhm : Form
    {
        private Adherent adherent;

        private List<Emprunt> empruntsEnCours = new List<Emprunt>();

        private Exemplaire exemplaire;

        private Bibliotheque bibliotheque;

        private string numeroAdherent;

        private string codeExemplaire;


        public EmpruntIhm() => InitializeComponent();

        private void EmpruntIhm_Load(object sender, EventArgs e)
        {
            try
            {
                bibliotheque = Bibliotheque.Rechercher(Properties.Settings.Default.codBibliotheque);
            }
            catch (SqlException)
            {
                MessageBox.Show("Erreur de connexion !");
            }

            if (bibliotheque != null)
            {
                txtBibliotheque.Text = bibliotheque.Libelle;
            }
        }

        private void btnRechercherAdherent_Click(object sender, EventArgs e)
        {
            if (numeroAdherent == null)
            {
                MessageBox.Show("Saisir le numéro de l'adhérent!");
                return;
            }

            Adherent adherent = null;
            try
            {
                adherent = Adherent.Rechercher(numeroAdherent);
            }
            catch (SqlException)
            {
                MessageBox.Show("Erreur de connexion !");
            }

            if (adherent == null)
            {
                MessageBox.Show("Adherent non trouvé!");
            }
            else
            {
                this.adherent = adherent;
            }

            if (this.adherent != null)
            {
                txtNumeroAdherent.Text = this.adherent.Numero;
                txtNom.Text = this.adherent.Nom;
                txtPrenom.Text = this.adherent.Prenom;
                txtAdresse.Text = this.adherent.Adresse;
            }
            else
            {               
                txtNumeroAdherent.Text = string.Empty;
                txtNom.Text = string.Empty;
                txtPrenom.Text = string.Empty;
                txtAdresse.Text = string.Empty;             
            }

            MettreAJourEmpruntsEnCours();
            lblBloque.Visible = CompteEstBloque();
            MettreAJourBtnEmprunter();
        }

        private void btnRechercherExemplaire_Click(object sender, EventArgs e)
        {
            if (codeExemplaire == null)
            {
                MessageBox.Show("Saisir numéro exemplaire!");
            }
            else
            {
                try
                {
                    exemplaire = Exemplaire.Obtenir(bibliotheque, codeExemplaire);
                }
                catch(SqlException)
                {
                    MessageBox.Show("Erreur de connexion");
                }

                if (exemplaire != null)
                {
                    txtCodeExemplaire.Text = exemplaire.Code;
                    txtTitre.Text = exemplaire.Livre.Titre;
                    txtAuteur.Text = exemplaire.Livre.NomAuteurs;
                    if (exemplaire.Disponible)
                    {
                        txtDisponible.Text = "Disponible";
                    }
                    else
                    {
                        txtDisponible.Text = "Non disponible";
                    }
                }
                else
                {
                    MessageBox.Show("Exemplaire non trouvé!");
                    txtCodeExemplaire.Text = string.Empty;
                    txtTitre.Text = string.Empty;
                    txtAuteur.Text = string.Empty;
                    txtDisponible.Text = string.Empty;
                }
            }
            MettreAJourBtnEmprunter();
        }

        private void btnEmprunter_Click(object sender, EventArgs e)
        {
            if (!EmpruntEstPossible())
            {
                throw new InvalidOperationException("Le bouton emprunter devrait être désactivé.");
            }


            txtDisponible.Text = "Non disponible";

            try
            {
                Emprunt.Inserer(adherent, exemplaire);
                this.exemplaire.Disponible = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Erreur de connexion !");
            }

            MettreAJourEmpruntsEnCours();
            MettreAJourBtnEmprunter();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            if (lstEmprunts.Items.Count == 0)
            {
                throw new InvalidOperationException("btnImprimer devrait être désactivé");
            }

            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void txtNumeroAdherent_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNumeroAdherent.Text))
            {
                MessageBox.Show("Saisir numéro adherent!");
            }
            else
            {
                numeroAdherent = txtNumeroAdherent.Text.Trim();
            }


            if (numeroAdherent != null)
            {
                txtNumeroAdherent.Text = numeroAdherent;
            }
        }

        private void txtCodeExemplaire_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodeExemplaire.Text))
            {
                MessageBox.Show("Saisir code exemplaire !");
                e.Cancel = true;
            }
            else
            {
                codeExemplaire = txtCodeExemplaire.Text.Trim().ToUpper();
                txtCodeExemplaire.Text = codeExemplaire;
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string impression = "";
            if (bibliotheque != null)
            {
                impression += $"{bibliotheque.Code} - {bibliotheque.Libelle} - {bibliotheque.Adresse}\n\r";
            }
            impression += $"Impression : {DateTime.Now}\n\r\n\r";
            impression += $"Adherent : \r\n";
            impression += $"{adherent.Prenom} {adherent.Nom}\r\n";
            impression += $"{adherent.Adresse}\n\r\r\n";


            foreach (Emprunt emprunt in Emprunt.ObtenirEmpruntsEnCours(adherent))
            {
                impression += $"{emprunt.Exemplaire.Bibliotheque.Code} {emprunt.Exemplaire.Code}\n\r";
                impression += $"{emprunt.Exemplaire.Livre.NomAuteurs}\n\r";
                impression += $"{emprunt.Exemplaire.Livre.Titre}\n\r";
                impression += $"Date emprunt : {emprunt.DateEmprunt}\n\r";
                impression += $"À rendre : {emprunt.DateRestitutionPrevue}\n\r\n\r";
            }
            e.Graphics.DrawString(impression, this.Font, Brushes.Black,
                e.MarginBounds, StringFormat.GenericTypographic);
        }

        private bool CompteEstBloque()
        {
            return adherent != null &&
                (adherent.Perime || !RestitutionsEstEnRegle());
        }

        private bool RestitutionsEstEnRegle()
        {
            return empruntsEnCours == null || !empruntsEnCours.Any(e => e.EstEnRetard);
        }

        public void MettreAJourEmpruntsEnCours()
        {
            lstEmprunts.Items.Clear();
            try
            {
                empruntsEnCours = Emprunt.ObtenirEmpruntsEnCours(adherent);
            }
            catch (SqlException ex)
            {
                //MessageBox.Show("Erreur de connexion !");
                MessageBox.Show(ex.ToString());
            }

            txtEmpruntsTotal.Text = empruntsEnCours.Count.ToString();

            int empruntsEnRetard = 0;
            foreach (Emprunt emprunt in empruntsEnCours)
            {
                if (emprunt.EstEnRetard)
                {
                    empruntsEnRetard++;
                }
                lstEmprunts.Items.Add(emprunt);
            }

            txtEmpruntsEnRetard.Text = empruntsEnRetard.ToString();

            MettreAJourBtnImprimer();
        }

        public void MettreAJourBtnImprimer() => btnImprimer.Enabled = lstEmprunts.Items.Count > 0;

        public void MettreAJourBtnEmprunter() => btnEmprunter.Enabled = EmpruntEstPossible();

        public bool EmpruntEstPossible()
        {
            return adherent != null &&
                exemplaire != null &&
                empruntsEnCours != null &&
                exemplaire.Disponible &&
                empruntsEnCours.Count < Adherent.MAX_EMPRUNTS &&
                !CompteEstBloque();
        }     
    }
}
