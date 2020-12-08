using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Biblio
{
    static class Utilitaires
    {
        public static DateTime TronquerJour(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
        }

        public static string EgaliserLongeur(string str, int longeur)
        {
            if (str.Length >= longeur)
            {
                str = str.Substring(0, longeur - 3) + "...";
            }
            else 
            { 
                while(str.Length < longeur)
                {
                    str += " ";
                }
            } 

            return str;
        }

        public static List<string> Mots(string phrase)
        {
            return new List<string>(phrase.Trim().Split(' '));
        }

        public static object RenvoyerValeurOuNull(object valeur)
        {
            if (valeur != DBNull.Value)
            {
                return valeur;
            }
            else
            {
                return null;
            }
        }

        public static void RajouterParametre(List<SqlParameter> parametres, string nom, object valeur)
        {
            parametres.Add(new SqlParameter(nom, valeur));
        }
    }
}
