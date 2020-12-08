using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblio
{
    /// <summary>
    /// Un exemplaire d'un livre.
    /// </summary>
    public class Exemplaire
    {
        public class OusineExemplaire : Ousine<Exemplaire>
        {
            public override Exemplaire Creer(DataRow row)
            {
                int numeroExemplaire = (int)row["numExemplaire"];
                string codeExemplaire = row["codExemplaire"] as string;
                string commentaire = row["commentExemplaire"] as string;

                Exemplaire exemplaire = new Exemplaire(numeroExemplaire, codeExemplaire);
                Bibliotheque bibliotheque = Bibliotheque.Rechercher(row["codBibliotheque"] as string);
                exemplaire.Bibliotheque = Bibliotheque.ousine.Creer(row);
                exemplaire.Emplacement = Emplacement.ousine.Creer(row);
                exemplaire.Disponible = (bool)row["disponible"];
                exemplaire.Livre = Livre.ousine.Creer(row);

                return exemplaire;
            }
        }

        public static OusineExemplaire ousine = new OusineExemplaire();

        private const string sqlGeneral = @"SELECT Theme.codTheme, libelTheme, descripTheme,
                                                Livre.IsbnLivre, titreLivre,
                                                Exemplaire.numExemplaire, Exemplaire.codExemplaire, commentExemplaire, disponible,
                                                Emplacement.codEmplacement, libelEmplacement,
                                                Bibliotheque.codBibliotheque, libelBibliotheque, adrBibliotheque
                                             FROM Theme
                                                JOIN Livre ON Theme.codTheme = Livre.codTheme
                                                JOIN Exemplaire ON Livre.IsbnLivre = Exemplaire.IsbnLivre
                                                JOIN Emplacement ON Exemplaire.codEmplacement = Emplacement.codEmplacement AND Exemplaire.codBibliotheque = Emplacement.codBibliotheque
                                                JOIN Bibliotheque ON Emplacement.codBibliotheque = Bibliotheque.codBibliotheque ";

        public static Exemplaire Obtenir(int numeroExemplaire)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();
            Utilitaires.RajouterParametre(parametres, "@NumExemplaire", numeroExemplaire);
            string sql = sqlGeneral + "WHERE numExemplaire = @NumExemplaire;";


            return ousine.Obtenir(parametres, sql);
        }

        public static Exemplaire Obtenir(Exemplaire exemplaire)
        {
            return Obtenir(exemplaire.Numero);
        }

        public static Exemplaire Obtenir(Bibliotheque bibliotheque, string codeExemplaire)

        {
            List<SqlParameter> parametres = new List<SqlParameter>();

            Utilitaires.RajouterParametre(parametres, "@codBibliotheque", bibliotheque.Code);
            Utilitaires.RajouterParametre(parametres, "@CodExemplaire", codeExemplaire);
            string sql = sqlGeneral + "WHERE Bibliotheque.codBibliotheque = @CodBibliotheque AND Exemplaire.codExemplaire = @CodExemplaire;";

            return ousine.Obtenir(parametres, sql);

        }

        public static List<Exemplaire> ObtenirListe(Livre livre)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();

            Utilitaires.RajouterParametre(parametres, "@Isbn", livre.Isbn);

            string sql = sqlGeneral + "WHERE Livre.IsbnLivre = @Isbn;";

            return ousine.ObtenirListe(parametres, sql);
        }

        public static Exemplaire MettreAJour(Exemplaire exemplaire)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();
            Utilitaires.RajouterParametre(parametres, "@NumExemplaire", exemplaire.Numero);
            Utilitaires.RajouterParametre(parametres, "@Disponible", exemplaire.Disponible);
            Utilitaires.RajouterParametre(parametres, "@IsbnLivre", exemplaire.Livre.Isbn);
            Utilitaires.RajouterParametre(parametres, "@CodBibliotheque", exemplaire.Bibliotheque.Code);
            Utilitaires.RajouterParametre(parametres, "@CodEmplacement", exemplaire.Emplacement.Code);
            string sql = @"UPDATE Exemplaire
                               SET Disponible = Disponible, codBibliotheque = @CodBibliotheque, codEmplacement = @CodEmplacement
                               WHERE numExemplaire = @NumExemplaire;";

            BaseDeDonnees.Executer(parametres, sql);

            return Obtenir(exemplaire);
        }

        /// <summary>
        /// Identifiant de l'exemplaire dans le système.
        /// </summary>
        public int Numero { get; private set; }

        /// <summary>
        /// Identifiant de l'exemplaire dans la bibliothèque.
        /// </summary>
        public string Code { get; private set; }

        public string Commentaire { get; set; }

        /// <summary>
        /// Bibliothèque d'appartenance.
        /// </summary>
        public Bibliotheque Bibliotheque { get; set; }

        /// <summary>
        /// Livre.
        /// </summary>
        public Livre Livre { get; set; }

        public Emplacement Emplacement { get; set; }

        /// <summary>
        /// Vrai si l'exemplaire est disponible.
        /// </summary>
        public bool Disponible { get; set; }

        /// <summary>
        /// Crée un exemplaire avec le numéro et le code données.
        /// </summary>
        /// <param name="numero">Numéro.</param>
        /// <param name="code">Code.</param>
        public Exemplaire(int numero, string code)
        {
            Numero = numero;
            Code = code;
        }

        public Exemplaire(Exemplaire exemplaire) : this(exemplaire.Numero, exemplaire.Code)
        {
            Bibliotheque = exemplaire.Bibliotheque;
            Livre = exemplaire.Livre;
            Disponible = exemplaire.Disponible;
            Emplacement = exemplaire.Emplacement;
        }

        public static bool operator ==(Exemplaire unExemplaire, Exemplaire autreExemplaire)
        {
            return unExemplaire.Equals(autreExemplaire);
        }

        public static bool operator !=(Exemplaire unExemplaire, Exemplaire autreExemplaire)
        {
            return !unExemplaire.Equals(autreExemplaire);
        }

        public override bool Equals(object obj)
        {
            return obj is Exemplaire autre && Numero == autre.Numero;
        }

        public override int GetHashCode()
        {
            return Numero.GetHashCode();
        }

        /// <summary>
        /// Chaîne qui représente l'exemplaire.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Code;
    }
}
