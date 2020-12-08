using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblio
{
    public class Bibliotheque
    {
        public class OusineBibliotheque : Ousine<Bibliotheque>
        {
            public override Bibliotheque Creer(DataRow row)
            {
                Bibliotheque bibliotheque = new Bibliotheque(row["codBibliotheque"] as string);
                bibliotheque.Libelle = row["libelBibliotheque"] as string;
                bibliotheque.Adresse = row["adrBibliotheque"] as string;

                return bibliotheque;
            }
        }

        public static OusineBibliotheque ousine = new OusineBibliotheque();

        /// <summary>
        /// Renvoie la bibliothèque avec le code spécifié.
        /// </summary>
        /// <param name="code">Identifiant.</param>
        /// <returns>Bibliothèque avec le code spécifié. Null si la bibliothèque n'existe pas.</returns>
        public static Bibliotheque Rechercher(string code)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();
            Utilitaires.RajouterParametre(parametres, "@CodBibliotheque", code);

            string sql = @"SELECT codBibliotheque, libelBibliotheque, adrBibliotheque
                           FROM Bibliotheque
                           WHERE codBibliotheque = @CodBibliotheque";

            return ousine.Obtenir(parametres, sql);
        }

        /// <summary>
        /// Renvoie la liste de toutes le bibliothèques du système.
        /// </summary>
        /// <returns>Liste de toutes le bibliothèques du système</returns>
        public static List<Bibliotheque> ListerToutes()
        {
            string sql = @"SELECT codBibliotheque, libelBibliotheque, adrBibliotheque
                           FROM Bibliotheque";

            return ousine.ObtenirListe(sql);
        }

        /// <summary>
        /// Identifiant de la bibliothèque.
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// Nom de la bibliothèque.
        /// </summary>
        public string Libelle { get; set; }

        /// <summary>
        /// Adresse de la bibliothèque.
        /// </summary>
        public string Adresse { get; set; }

        /// <summary>
        /// Crée une bibliothèque avec le code spécifié.
        /// </summary>
        /// <param name="code"></param>
        public Bibliotheque(string code) => Code = code;

        public static bool operator == (Bibliotheque uneBibliotheque, Bibliotheque autreBibliotheque)
        {
            return uneBibliotheque.Equals(autreBibliotheque);
        }

        public static bool operator !=(Bibliotheque uneBibliotheque, Bibliotheque autreBibliotheque)
        {
            return ! uneBibliotheque.Equals(autreBibliotheque);
        }


        public override bool Equals(object obj)
        {
            return obj is Bibliotheque autre && Code == autre.Code;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        /// <summary>
        /// Renvoie une chaîne qui représente la bibliothèque.
        /// </summary>
        /// <returns>Chaîne qui représente la bibliothèque.</returns>
        public override string ToString() => Libelle;
    }
}
