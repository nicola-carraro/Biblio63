using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Biblio
{
    public partial class LivreIhm : Form
    {
        private Livre livre;

        public LivreIhm(Livre livre)
        {
            InitializeComponent();
            this.livre = livre;
        }

        private void ListeExemplairesIhm_Load(object sender, EventArgs e)
        {
            txtTitre.Text = livre.Titre;
            txtAuteurs.Text = livre.NomAuteurs;
            txtIsbn.Text = livre.Isbn;

            foreach (Exemplaire exemplaire in Exemplaire.ObtenirListe(livre))
            {
                exemplaireBindingSource.Add(exemplaire);
            }
              
        }

        private void grpLivre_Enter(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            ActiverModifications();
        }

        private void ActiverModifications()
        {
            txtTitre.ReadOnly = false;
            txtAuteurs.ReadOnly = false;
        }

        private void DesactiverModifications()
        {
            txtTitre.ReadOnly = true;
            txtAuteurs.ReadOnly = true;
        }

        private void dataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new ExemplaireIhm(dataGridView.Rows[e.RowIndex].DataBoundItem as Exemplaire).ShowDialog();
        }



    }
}
