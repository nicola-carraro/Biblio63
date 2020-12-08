using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblio
{
    public class Theme
    {
        public class OusineTheme : Ousine<Theme>
        {
            public override Theme Creer(DataRow row)
            {
                Theme theme = new Theme(row["codTheme"] as string);
                theme.Libelle = row["libelTheme"] as string;
                theme.Description = row["descripTheme"] as string;

                return theme;
            }
        }

        public static OusineTheme ousine = new OusineTheme();

        public static List<Theme> Tous()
        {
            
            string sql = @"SELECT *
                           FROM Theme;";

            return ousine.ObtenirListe(sql);
        }

        public static Theme Obtenir(string code)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();
            parametres.Add(new SqlParameter("@CodTheme", code));
            string sql = @"SELECT * FROM Theme
                           WHERE codTheme = @CodTheme";
            return ousine.Obtenir(parametres, sql);
        }

        public string Code { get; private set; }

        public string Libelle { get; set; }

        public string Description { get; set; }

        public Theme(string code)
        {
            Code = code;
        }

        public Theme (Theme theme) : this(theme.Code)
        {
            Libelle = theme.Libelle;
            Description = theme.Description;
        }

        public static bool operator==(Theme unTheme, Theme autreTheme)
        {
            return unTheme.Equals(autreTheme);
        }

        public static bool operator !=(Theme unTheme, Theme autreTheme)
        {
            return !unTheme.Equals(autreTheme);
        }

        public override bool Equals(object obj)
        {
            return obj is Theme autre && autre.Code == Code;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override string ToString()
        {
            return Libelle;
        }
    }
}
