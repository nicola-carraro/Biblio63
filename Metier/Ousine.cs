using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblio
{
    public abstract class Ousine<T>
    {
        public abstract T Creer(DataRow row);


        public List<T> ObtenirListe(List<SqlParameter> parametres, string sql)
        {
            List<T> resultats = new List<T>();
            DataTable dataTable = BaseDeDonnees.Rechercher(parametres, sql);

            foreach(DataRow row in dataTable.Rows)
            {
                resultats.Add(Creer(row));
            }
            return resultats;
        }

        public List<T> ObtenirListe(string sql)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();
            return ObtenirListe(parametres, sql);
        }

        public T Obtenir(List<SqlParameter> parametres, string sql)
        {
            List<T> resultats = ObtenirListe(parametres, sql);

            if(resultats.Count == 0)
            {
                return default(T);
            }
            else
            {
                return resultats[0];
            }
        }
    }
}
