using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblio
{
    /// <summary>
    /// Un utilisateur du système.
    /// </summary>
    public class Adherent
    {
        private class OusineAdherent : Ousine<Adherent>
        {
            public override Adherent Creer(DataRow row)
            {
                Adherent adherent = new Adherent(row["numAdherent"] as string);
                adherent.Nom = row["nomAdherent"] as string;
                adherent.Prenom = row["prenomAdherent"] as string;
                adherent.Adresse = row["adrAdherent"] as string;
                adherent.Telephone = row["teleAdherent"] as string;
                adherent.Peremption = (DateTime)row["perimeLe"];

                return adherent;
            }
        }

        public static Ousine<Adherent> ousine = new OusineAdherent();

        /// <summary>
        /// Renvoie l'adhérent identifié par numéro à partir de données de la base. 
        /// </summary>
        /// <param name="numero">Identifiant de l'adhérent</param>
        /// <returns>Adhérent identifié par le numéro. Null si l'adhérent n'existe pas.</returns>
        public static Adherent Rechercher(string numero)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();
            parametres.Add(new SqlParameter("@NumAdherent", numero));
            string sql  = @"SELECT numAdherent, nomAdherent, prenomAdherent, adrAdherent, teleAdherent, perimeLe 
                            FROM Adherent
                            WHERE numAdherent = @NumAdherent";

            return ousine.Obtenir(parametres, sql);
        }

        /// <summary>
        /// Nombre maximale d'emprunts.
        /// </summary>
        public static readonly int MAX_EMPRUNTS = 3;

        /// <summary>
        /// Identifiant l'adhérent.
        /// </summary>
        public string Numero { get; private set; }

        /// <summary>
        /// Nom de l'adhérent.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom de l'adhérent.
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Adresse de l'adhérent.
        /// </summary>
        public string Adresse { get; set; }

        /// <summary>
        /// Numéro de téléphone de l'adhérent.
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Date d'échéance pour le règlement de la cotisation.
        /// </summary>
        public DateTime Peremption { get; set; }

        public bool Perime
        {
            get => Utilitaires.TronquerJour(Peremption) < Utilitaires.TronquerJour(DateTime.Now);
        }

        /// <summary>
        /// Crée un adhérent avec le numéro sélectionné.
        /// </summary>
        /// <param name="numero">Numéro de l'adhérent.</param>
        public Adherent(string numero) => Numero = numero;
    }
}
