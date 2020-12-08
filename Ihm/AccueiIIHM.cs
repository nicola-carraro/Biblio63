using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Biblio
{
    public partial class AccueilIhm : Form
    {
        public AccueilIhm()
        {
            InitializeComponent();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtRecherche.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtRecherche.Text))
            {
                MessageBox.Show("Saisissez des mots clés!");
                return;
            }
            List<string> mots = Utilitaires.Mots(txtRecherche.Text);
            for (int i = 0; i < mots.Count; i++)
            {
                mots[i] = mots[i].ToLower();
            }

            List<Livre> livres = null;
            try
            {
                livres = Livre.ObtenirParTitre(mots);
                new ListeLivresIhm(livres).ShowDialog();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show("Erreur de connexion !");
                MessageBox.Show(ex.ToString());
            }      
        }

        private void btnAvance_Click(object sender, EventArgs e)
        {
            new RechercherLivresIhm().ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection suggestions = new AutoCompleteStringCollection();

            txtRecherche.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtRecherche.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRecherche.AutoCompleteCustomSource = suggestions;
        }

        private void pretEmpruntMenuItem_Click(object sender, EventArgs e)
        {
            new EmpruntIhm().ShowDialog();
        }

        private void pretStatistiquesMenuItem_Click(object sender, EventArgs e)
        {
            new StatistiquesIhm().ShowDialog();
        }

        private void pretRetourMenuItem_Click(object sender, EventArgs e)
        {
            new RetourIhm().ShowDialog();
        }
    }
}
