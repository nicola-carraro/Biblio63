using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblio
{
    public partial class ListeThemesIhm : Form
    {
        private List<Theme> themes;

        public ListeThemesIhm(List<Theme> themes)
        {
            InitializeComponent();
            this.themes = themes;
        }

        private void ListeThemesIhm_Load(object sender, EventArgs e)
        {
            foreach (Theme theme in themes)
            {
                themeBindingSource.Add(theme);
            }
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Theme theme = dataGridView.Rows[e.RowIndex].DataBoundItem as Theme;
            new ListeLivresIhm(Livre.Obtenir(theme)).ShowDialog();
        }
    }
}
