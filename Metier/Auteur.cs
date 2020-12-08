using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblio
{
    /// <summary>
    /// L'auteur d'un livre.
    /// </summary>
    public class Auteur
    {
        public class OusineAuteur : Ousine<Auteur>
        {
            public override Auteur Creer(DataRow row)
            {
                Auteur auteur = new Auteur(row["codAuteur"] as string);
                auteur.Nom = row["nomAuteur"] as string;
                auteur.Prenom = row["prenomAuteur"] as string;

                return auteur;
            }
        }

        public static OusineAuteur ousine = new OusineAuteur();

        /// <summary>
        /// Renvoie la liste des auteur du livre spécifié.
        /// </summary>
        /// <param name="livre">Un livre.</param>
        /// <returns>Liste des auteurs.</returns>
        public static List<Auteur> ObtenirListe(Livre livre)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();
            Utilitaires.RajouterParametre(parametres, "@Isbn", livre.Isbn);
            string sql = @"SELECT Auteur.codAuteur, nomAuteur, prenomAuteur
                           FROM Auteur
                           JOIN Redaction ON Auteur.codAuteur = Redaction.codAuteur
                           WHERE IsbnLivre = @Isbn;";
            return ousine.ObtenirListe(parametres, sql);
        }

        public static List<Auteur> RechercherParMotCleNom(string mot)
        {
            string like = $"{mot}%";
            List<SqlParameter> parametres = new List<SqlParameter>();
            Utilitaires.RajouterParametre(parametres, "@Like", like);
            string sql = @"SELECT codAuteur, nomAuteur, prenomAuteur
                           FROM Auteur
                           WHERE nomAuteur LIKE @Like;";

            return ousine.ObtenirListe(parametres, sql);
        }

        /// <summary>
        /// Identifiant de l'auteur.
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// Nom de l'auteur.
        /// </summary>
        public string Nom { get; set; } = "";

        /// <summary>
        /// Prénom de l'auteur.
        /// </summary>
        public string Prenom { get; set; } = "";

        /// <summary>
        /// Crée un auteur avec le code spécifié.
        /// </summary>
        /// <param name="code"></param>
        public Auteur(string code) => Code = code;

        public Auteur(Auteur auteur) : this(auteur.Code)
        {
            Nom = auteur.Nom;
            Prenom = auteur.Prenom;
        }

        public static bool operator==(Auteur unAuteur, Auteur autreAuteur)
        {
            return unAuteur.Equals(autreAuteur);
        }

        public static bool operator !=(Auteur unAuteur, Auteur autreAuteur)
        {
            return !unAuteur.Equals(autreAuteur);
        }

        public override bool Equals(object obj)
        {
            return obj is Auteur autre && Code == autre.Code;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        /// <summary>
        /// Chaîne qui représente l'auteur.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Prenom} {Nom}";
    }
}
