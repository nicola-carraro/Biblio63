using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblio
{
    public static class BaseDeDonnees
    {
        /// <summary>
        /// Renvoie un data set avec le résultat de la recherche dans la base.
        /// </summary>
        /// <param name="cmd">Commande SQL SELECT.</param>
        /// <param name="table">Nom de la table du data set.</param>
        /// <returns>Data set avec les résultats.</returns>
        public static DataTable Rechercher(SqlCommand cmd)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.chaineUtilisateurBiblio);

            cmd.Connection = conn;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);

            return ds.Tables[0];
        }

        public static DataTable Rechercher(List<SqlParameter> parametres, string sql)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.chaineUtilisateurBiblio);
            SqlCommand cmd = conn.CreateCommand();
            parametres.ForEach(p => cmd.Parameters.Add(p));
            cmd.CommandText = sql;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);

            return ds.Tables[0];
        }

        public static DataTable Rechercher(string sql)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();
            return Rechercher(parametres, sql);
        }

        public static int Executer(List<SqlParameter> parametres, string sql)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.chaineUtilisateurBiblio);
            SqlCommand cmd = conn.CreateCommand();
            parametres.ForEach(p => cmd.Parameters.Add(p));
            cmd.CommandText = sql;
 
            using (conn)
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }



        public static int Executer(SqlCommand cmd)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.chaineUtilisateurBiblio);

            cmd.Connection = conn;
            using (conn)
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
