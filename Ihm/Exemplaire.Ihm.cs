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
    public partial class ExemplaireIhm : Form
    {
 

        private Exemplaire exemplaire;

        private List<Bibliotheque> bibliotheques = new List<Bibliotheque>();

        private List<Emplacement> emplacements = new List<Emplacement>();

        public ExemplaireIhm(Exemplaire exemplaire)
        {
         
            this.exemplaire = new Exemplaire(exemplaire);
            InitializeComponent();
        }

        private void ExemplaireIhm_Load(object sender, EventArgs e)
        {
            txtAuteur.Text = exemplaire.Livre.NomAuteurs;
            txtTitre.Text = exemplaire.Livre.Titre;
            txtIsbn.Text = exemplaire.Livre.Isbn;
            txtTheme.Text = exemplaire.Livre.Theme.Libelle;
            txtNumero.Text = exemplaire.Numero.ToString();
            txtCode.Text = exemplaire.Code;

            
            try
            {
                bibliotheques.AddRange(Bibliotheque.ListerToutes());
            }
            catch(SqlException)
            {
                MessageBox.Show("Erreur de connexion!");
            }

            foreach(Bibliotheque bibliotheque in bibliotheques)
            {
                comboBoxBibliotheque.Items.Add(bibliotheque);
            }

            comboBoxBibliotheque.SelectedItem = exemplaire.Bibliotheque;

            MettreAJourListeEmplacements();
            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            ActiverModifications();
        }

        private void ActiverModifications()
        {
            txtCode.ReadOnly = false;
            comboBoxBibliotheque.Enabled = true;
            comboBoxEmplacement.Enabled = true;
        }

        private void DesactiverModifications()
        {
            txtCode.ReadOnly = true;
            comboBoxBibliotheque.Enabled = false;
            comboBoxEmplacement.Enabled = false;
        }

        private void MettreAJourListeEmplacements()
        {
            emplacements.Clear();
            if (comboBoxBibliotheque.SelectedItem != null && exemplaire != null)
            {
                emplacements = Emplacement.ObtenirListe(comboBoxBibliotheque.SelectedItem as Bibliotheque, exemplaire.Livre.Theme);
            }
            emplacements.ForEach(e => comboBoxEmplacement.Items.Add(e));
            comboBoxEmplacement.SelectedItem = exemplaire.Emplacement;        
        }

        private void comboBoxEmplacement_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Êtes vous sûrs de vouloir changer l'emplacement de cet exemplaire ?",
                                                        "Confirmation",
                                                        MessageBoxButtons.YesNo);
            DesactiverModifications();
            if (resultat == DialogResult.Yes)
            {
                exemplaire.Emplacement = comboBoxEmplacement.SelectedItem as Emplacement;
                exemplaire = Exemplaire.MettreAJour(exemplaire);            
            }
            MettreAJourListeEmplacements();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void comboBoxBibliotheque_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Êtes vous sûrs de vouloir assigner cet exemplaire  ?",
                                            "Confirmation",
                                            MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                
                List<Emplacement> emplacements = Emplacement.ObtenirListe(comboBoxBibliotheque.SelectedItem as Bibliotheque, exemplaire.Livre.Theme);
                if(emplacements.Count == 0)
                {
                    comboBoxEmplacement.SelectedItem = exemplaire.Bibliotheque;
                    return;
                }
                this.emplacements = emplacements;
                this.exemplaire.Bibliotheque = comboBoxBibliotheque.SelectedItem as Bibliotheque;
                this.exemplaire.Emplacement = emplacements[0];

                exemplaire = Exemplaire.MettreAJour(exemplaire);
            }
            MettreAJourListeEmplacements();
        }
    }
}
