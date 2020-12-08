using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblio
{
    /// <summary>
    /// L'emplacement d'un exemplaire dans une bibliothèque.
    /// </summary>
    public class Emplacement
    {
        public class OusineEmplacement : Ousine<Emplacement>
        {
            public override Emplacement Creer(DataRow row)
            {
                Emplacement emplacement = new Emplacement(row["codEmplacement"] as string);
                emplacement.Bibliotheque = Bibliotheque.ousine.Creer(row);
                emplacement.Libelle = row["libelEmplacement"] as string;
                emplacement.Theme = Theme.ousine.Creer(row);

                return emplacement;
            }
        }

        private const string sqlGeneral = @"SELECT Bibliotheque.codBibliotheque, libelBibliotheque, adrBibliotheque,
                                                Emplacement.codEmplacement, libelEmplacement,
                                                Theme.codTheme, libelTheme, descripTheme
                                            FROM Bibliotheque
                                                JOIN Emplacement ON Bibliotheque.codBibliotheque = Emplacement.codBibliotheque
                                                JOIN Theme ON Emplacement.codTheme = Theme.codTheme ";

        public static OusineEmplacement ousine = new OusineEmplacement();

        public static List<Emplacement> ObtenirListe(Bibliotheque bibliotheque, Theme theme)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();

            parametres.Add(new SqlParameter("@codBibliotheque", bibliotheque.Code));
            parametres.Add(new SqlParameter("@CodTheme", theme.Code));

            string sql = sqlGeneral + "WHERE Bibliotheque.codBibliotheque = @codBibliotheque AND Theme.codTheme = @CodTheme;";

            return ousine.ObtenirListe(parametres, sql);
        }

        public static Emplacement Obtenir(Livre livre)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();

            parametres.Add(new SqlParameter("@IsbnLivre", livre.Isbn));
            string sql = sqlGeneral + "WHERE Livre.IsbnLivre = @IsbnLivre;";

            return ousine.Obtenir(parametres, sql);
        }

        /// <summary>
        /// Identifiant de l'emplacement.
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// Décrit le contenu de l'emplacement.
        /// </summary>
        public string Libelle { get; set; }

        /// <summary>
        /// Bibliothèque où se trouve l'emplacement.
        /// </summary>
        public Bibliotheque Bibliotheque { get; set; }

        /// <summary>
        /// Thème qui correspond à l'emplacement.
        /// </summary>
        public Theme Theme { get; set; }

        /// <summary>
        /// Crée un emplacement avec le code spécifié.
        /// </summary>
        /// <param name="code">Code.</param>
        public Emplacement(string code) => Code = code;


        public override bool Equals(object obj)
        {
            return obj is Emplacement autre && Code == autre.Code && Bibliotheque == autre.Bibliotheque;
        }

        public override int GetHashCode() => Code.GetHashCode();

        /// <summary>
        /// Chaîne qui représente l'emplacement.
        /// </summary>
        /// <param name="code">Code.</param>
        public override string ToString() => Code;
    }
}
