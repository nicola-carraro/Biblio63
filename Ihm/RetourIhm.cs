using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Biblio
{
    public partial class RetourIhm : Form
    {
        private Exemplaire exemplaire;
        private Bibliotheque bibliotheque;
        private Emprunt empruntEnCours;
        public RetourIhm()
        {
            InitializeComponent();
        }


        private void txtCodeExemplaire_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodeExemplaire.Text))
            {
                txtCodeExemplaire.Clear();
                return;
            }

            try
            {
                exemplaire = Exemplaire.Obtenir(bibliotheque, txtCodeExemplaire.Text);
            }
            catch(SqlException ex)
            {
                //MessageBox.Show("Erreur de connexion!");
                MessageBox.Show(ex.ToString());
            }

            MettreAJourExemplaire();
        }

        private void MettreAJourExemplaire()
        {
            if (exemplaire == null)
            {
                MessageBox.Show("Exemplaire non trouvé !");
                txtCodeExemplaire.Clear();
                txtAuteurs.Clear();
                txtTitre.Clear();
                txtAdherent.Clear();
                txtDateEmprunt.Clear();
            }
            else
            {
                txtAuteurs.Text = exemplaire.Livre.NomAuteurs;
                txtTitre.Text = exemplaire.Livre.Titre;
                try
                {

                    empruntEnCours = Emprunt.EmpruntEnCours(exemplaire);
                }
                catch(SqlException ex)
                {
                    //MessageBox.Show("Erreur de connexion !");
                    MessageBox.Show(ex.ToString());
                }

                btnValider.Enabled = (empruntEnCours != null);

                if (empruntEnCours == null)
                {
                    txtAdherent.Clear();
                    txtDateEmprunt.Clear();
                }
                else
                {
                    txtAdherent.Text = $"{empruntEnCours.Adherent.Prenom} {empruntEnCours.Adherent.Nom}";
                    txtDateEmprunt.Text = $"{empruntEnCours.DateEmprunt}";
                }
            }
        }

        private void RetourIhm_Load(object sender, EventArgs e)
        {
            try
            {
                bibliotheque = Bibliotheque.Rechercher(Properties.Settings.Default.codBibliotheque);
            }
            catch (SqlException)
            {
                MessageBox.Show("Erreur de connexion !");
            }

            if (bibliotheque == null)
            {
                lblBibliotheque.Text = string.Empty;
            }
            else
            {
                lblBibliotheque.Text = bibliotheque.Libelle;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(empruntEnCours != null)
            {
                Emprunt.MettreAJour(empruntEnCours);
            }

            MettreAJourExemplaire();
        }
    }
}
