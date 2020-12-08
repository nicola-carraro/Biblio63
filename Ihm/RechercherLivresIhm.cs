
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Biblio
{
    public partial class RechercherLivresIhm : Form
    {
        private Livre livre;

        public RechercherLivresIhm() : this(false, false)
        {
        }

        public RechercherLivresIhm(bool modificationLivres, bool modificationExemplaires)
        {
            InitializeComponent();
        }

        private void btnListeThemes_Click(object sender, EventArgs e)
        {
            new ListeThemesIhm(Theme.Tous()).ShowDialog();
        }

        private void btnIsbnOk_Click(object sender, EventArgs e)
        {
            if((livre = Livre.Obtenir(txtIsbn.Text)) == null)
            {
                MessageBox.Show("Livre non trouvé !");
            }
            else
            {
                new LivreIhm(livre).ShowDialog();
            }
        }

        private void btnCriteresOK_Click(object sender, EventArgs e)
        {
            List<Livre> livresAuteur = new List<Livre>();
            List<Livre> livresTitre = new List<Livre>();
            List<Livre> livres = new List<Livre>();


            if (string.IsNullOrWhiteSpace(txtAuteur.Text) && string.IsNullOrWhiteSpace(txtTitre.Text))
            {
                MessageBox.Show("Renseigner titre ou auteur !");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtAuteur.Text))
            {
                string mot = Utilitaires.Mots(txtAuteur.Text)[0];
                List<Auteur> auteurs = Auteur.RechercherParMotCleNom(mot);
                foreach(Auteur auteur in auteurs)
                {
                    livresAuteur.AddRange(Livre.ObtenirListe(auteur));
                }
            }

            if(!string.IsNullOrWhiteSpace(txtTitre.Text))
            {
               livresTitre.AddRange(Livre.ObtenirParTitre(Utilitaires.Mots(txtTitre.Text)));
            }
     
            if(livresAuteur.Count == 0)
            {
                livres = livresTitre;
            }
            else if(livresTitre.Count==0)
            {
                livres = livresAuteur;
            }
            else
            {
                livres = livresAuteur.Intersect(livresTitre).ToList();
            }

            new ListeLivresIhm(livres).ShowDialog();
        }
    }
}
