
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio
{
    public partial class StatistiquesIhm : Form
    {

        List<Emprunt> emprunts = new List<Emprunt>();

        List<Theme> themes = new List<Theme>();

        string chaineAImprimer = "";

        public StatistiquesIhm()
        {
            InitializeComponent();
        }

        private void StatistiquesIhm_Load(object sender, EventArgs e)
        {
            chaineAImprimer = CalculerChaineAImprimer();
            try
            {
                foreach (Bibliotheque bibliotheque in Bibliotheque.ListerToutes())
                {
                    cbBibliotheque.Items.Add(bibliotheque);
                }
                foreach (int annee in Emprunt.ListerAnnees())
                {
                    cbAnnee.Items.Add(annee);
                }
                foreach (Theme theme in Theme.Tous())
                {
                    themes.Add(theme);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbBibliotheque_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourSelection();
        }

        private void cbAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourSelection();
        }

        private void MettreAJourSelection()
        {
            if (cbBibliotheque.SelectedItem != null && cbAnnee.SelectedItem != null)
            {
                int annee = (int)cbAnnee.SelectedItem;
                if (cbBibliotheque.SelectedItem.Equals("Toutes"))
                {
                    emprunts = Emprunt.ObtenirListe(annee);
                }
                else
                {
                    Bibliotheque bibliotheque = (Bibliotheque)cbBibliotheque.SelectedItem;
                    emprunts = Emprunt.Rechercher(bibliotheque, annee);
                }
                chaineAImprimer = CalculerChaineAImprimer();
            }
        }


        private void btnImprimer_Click(object sender, EventArgs e)
        {
            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }          
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            e.Graphics.MeasureString(chaineAImprimer, this.Font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            e.Graphics.DrawString(chaineAImprimer, this.Font, Brushes.Black,
                e.MarginBounds, StringFormat.GenericTypographic);

            chaineAImprimer = chaineAImprimer.Substring(charactersOnPage);

            e.HasMorePages = (chaineAImprimer.Length > 0);
        }

        private string CalculerChaineAImprimer()
        {
            string impression = EnteteDocument();
            foreach (Theme theme in themes)
            {
                List<Emprunt> empruntsTheme = ((List<Emprunt>)emprunts).FindAll(emp => emp.Exemplaire.Livre.Theme.Equals(theme));
                IList<Livre> livres = Livre.Obtenir(theme);
                IDictionary<Livre, int> empruntsParLivre = new Dictionary<Livre, int>();

                foreach (Livre livre in livres)
                {
                    empruntsParLivre[livre] = empruntsTheme.Count(emp => emp.Exemplaire.Livre.Equals(livre));
                }

                //impression += $"\n\r\n\r{theme.Libelle} ({empruntsTheme.Count}) : \n\r";
                //impression += FormatterLigne(theme.Libelle, empruntsTheme.Count.ToString());
                impression += $"\n\r\n\r\n\r\n\r{theme.Libelle}({empruntsTheme.Count.ToString()})\n\r\n\r";
                foreach (Livre livre in empruntsParLivre.Keys)
                {
                    //string titre = Utilitaires.EgaliserLongeur(livre.Titre, 30);
                    impression += $"{livre.Titre} ({empruntsParLivre[livre]})\n\r\n\r";
                    //impression += FormatterLigne(livre.Titre, empruntsParLivre[livre].ToString());
                }
            }
            return impression;

        }


        private string EnteteDocument()
        {
            string entete = "Bibliothèque : ";


            if (cbBibliotheque.SelectedItem != null)
            {
                if (cbBibliotheque.SelectedItem.Equals("Toutes"))
                {
                    entete += "Toutes\n\r\n\r";
                }
                else
                {
                    Bibliotheque bibliotheque = cbBibliotheque.SelectedItem as Bibliotheque;
                    entete += $"{bibliotheque.Libelle} ({bibliotheque.Code})\n\r\n\r";
                }
            }

            //entete += $"\r\n\r\n{"Titre"}\t\t{"Emprunts"}\r\n";
            //entete+= FormatterLigne("Titre", "Emprunts");

            return entete;
        }

        private string FormatterLigne(string titre, string emprunts)
        {
            return string.Format("{0,-50}{1,-5}\n\r", titre, emprunts);
        }

        private void printDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            chaineAImprimer = CalculerChaineAImprimer();
        }

        private void btnAppercu_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
               if(printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }
    }
}
