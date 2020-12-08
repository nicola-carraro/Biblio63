using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblio
{
    public partial class ListeLivresIhm : Form
    {
        private IList<Livre> livres;

        public ListeLivresIhm(IList<Livre> livres)
        {
            InitializeComponent();
            this.livres = livres;
        }

        private void ResultatRechercheIHM_Load(object sender, EventArgs e)
        {
            foreach (Livre livre in livres)
            {
                livreBindingSource.Add(livre);
            }
        }

        private void dataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Livre livre = dataGridView.Rows[e.RowIndex].DataBoundItem as Livre;
            new LivreIhm(livre).ShowDialog();
        }
    }
}
