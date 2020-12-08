using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblio
{
    public class Livre
    {
        public class OusineLivre : Ousine<Livre>
        {
            public override Livre Creer(DataRow row)
            {
                string isbn = row["IsbnLivre"] as string;
                string titre = row["titreLivre"] as string;

                Livre livre = new Livre(isbn, titre);
                livre.Theme = Theme.ousine.Creer(row);
                livre.Auteurs = Auteur.ObtenirListe(livre);

                return livre;
            }
        }

        public static OusineLivre ousine = new OusineLivre();

        public const string sqlGeneral = @"SELECT DISTINCT Livre.IsbnLivre, titreLivre, 
                                                Theme.codTheme, libelTheme, descripTheme
                                                FROM Auteur
                                                JOIN Redaction ON Auteur.codAuteur = Redaction.codAuteur
                                                JOIN Livre ON Redaction.IsbnLivre = Livre.IsbnLivre
                                                JOIN Theme ON Livre.codTheme = Theme.codTheme ";

        public static Livre Obtenir(string isbn)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();
            Utilitaires.RajouterParametre(parametres, "@Isbn", isbn);
            string sql = sqlGeneral + "WHERE Livre.IsbnLivre = @Isbn";

            return ousine.Obtenir(parametres, sql);
        }

        public static List<Livre> Obtenir(Theme theme)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();
            Utilitaires.RajouterParametre(parametres, "@CodTheme", theme.Code);
            string sql = sqlGeneral + "WHERE Theme.codTheme = @CodTheme";
            
            return ousine.ObtenirListe(parametres, sql);
        }

        public static List<Livre> ObtenirParTitre(List<string> mots)
        {
            string like = "%";
            
            foreach (string mot in mots)
            {
                like += $"{mot}%";
            }
            List<SqlParameter> parametres = new List<SqlParameter>();
            Utilitaires.RajouterParametre(parametres, "@Like", like);

            string sql = sqlGeneral + "WHERE LOWER(titreLivre) LIKE @Like;";

            return ousine.ObtenirListe(parametres, sql);
        }

        public static List<Livre> ObtenirListe(Auteur auteur)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();
            Utilitaires.RajouterParametre(parametres, "@codAuteur", auteur.Code);

            string sql = sqlGeneral + "WHERE Auteur.codAuteur = @codAuteur";

            return ousine.ObtenirListe(parametres, sql);
        }

 

        public string Isbn { get; private set; }

        public string Titre { get; set; }

        public Theme Theme { get; set; }

        private List<Auteur> auteurs;
        public List<Auteur> Auteurs
        {
            get => new List<Auteur>(auteurs);

            set => this.auteurs = new List<Auteur>(value);
        }

        public string NomAuteurs
        {
            get
            {
                string nomAuteurs = "";

                for (int i = 0; i < auteurs.Count; i++)
                {
                    if (i == 0)
                    {
                        nomAuteurs += auteurs[i];
                    }
                    else
                    {
                        nomAuteurs += $", \n\r{auteurs[i]}";
                    }
                }

                return nomAuteurs;
            }
        }

        public Livre(string isbn, string titre)
        {
            this.Isbn = isbn;
            this.Titre = titre;
        }

        public override bool Equals(object obj)
        {
            return obj is Livre autre && autre.Isbn == Isbn;
        }

        public override int GetHashCode()
        {
            return Isbn.GetHashCode();
        }

        public void RajouterAuteur(Auteur auteur)
        {
            this.auteurs.Add(auteur);
        }
    }
}
