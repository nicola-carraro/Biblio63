using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblio
{
    /// <summary>
    /// L'emprunt d'un exemplaire par un adhérent, effectué à une date donnée.
    /// </summary>
    public class Emprunt
    {

        public class OusineEmprunt : Ousine<Emprunt>
        {
            public override Emprunt Creer(DataRow row)
            {
                Exemplaire exemplaire = Exemplaire.ousine.Creer(row);
                Adherent adherent = Adherent.ousine.Creer(row);
                DateTime dateEmprunt = (DateTime)row["datEmprunt"];
                Emprunt emprunt = new Emprunt(adherent, exemplaire, dateEmprunt);
                emprunt.DateRestitutionPrevue = (DateTime?)Utilitaires.RenvoyerValeurOuNull(row["datRestitutionPrev"]);
                emprunt.DateRestitutionEffective = (DateTime?)Utilitaires.RenvoyerValeurOuNull(row["datRestitutionEff"]);

                return emprunt;
            }
        }

        public static OusineEmprunt ousine = new OusineEmprunt();


        /// <summary>
        /// Renvoie la liste des emprunts pour tous les système dans l'année spécifiée.
        /// </summary>
        /// <param name="annee">Année</param>
        /// <returns>Liste des emprunts.</returns>
        public static List<Emprunt> ObtenirListe(int annee)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();

            Utilitaires.RajouterParametre(parametres, "@Annee", annee);

            string sql = @"SELECT Adherent.numAdherent, nomAdherent, prenomAdherent, adrAdherent, teleAdherent, perimeLe,
                                datEmprunt, datRestitutionPrev, datRestitutionEff,                             
                                Exemplaire.numExemplaire, Exemplaire.codExemplaire,  commentExemplaire, disponible,
                                Emplacement.codEmplacement, libelEmplacement,                            
                                Bibliotheque.codBibliotheque, libelBibliotheque, adrBibliotheque,
                                Livre.IsbnLivre, titreLivre,
                                Theme.codTheme, libelTheme, descripTheme
                           FROM Adherent
                                JOIN Emprunt ON Adherent.numAdherent = Emprunt.numAdherent
                                JOIN Exemplaire ON Emprunt.numExemplaire = Exemplaire.numExemplaire
                                JOIN Exemplaire ON Exemplaire.codBibliotheque = Emplacement.codBibliotheque AND Exemplaire.codEmplacement = Emplacement.codEmplacement
                                JOIN Bibliotheque ON Emplacement.codBibliotheque = Bibliotheque.codBibliotheque
                                JOIN Livre ON Exemplaire.IsbnLivre = Livre.IsbnLivre
                                JOIN Theme ON Livre.codTheme = Theme.codTheme
                          WHERE YEAR(Emprunt.datEmprunt) = @Annee;";

            return ousine.ObtenirListe(parametres, sql);
        }

        /// <summary>
        /// Renvoie la liste des emprunts pour la bibliothèque spécifiée dans l'année spécifiée.
        /// </summary>
        /// <param name="bibliotheque"></param>
        /// <param name="annee"></param>
        /// <returns></returns>
        public static List<Emprunt> Rechercher(Bibliotheque bibliotheque, int annee)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();
            Utilitaires.RajouterParametre(parametres, "@CodBibliotheque", bibliotheque.Code);
            Utilitaires.RajouterParametre(parametres, "@Annee", annee);

            string sql = @"SELECT Adherent.numAdherent, nomAdherent, prenomAdherent, adrAdherent, teleAdherent, perimeLe,
                               datEmprunt, datRestitutionPrev, datRestitutionEff,                             
                               Exemplaire.numExemplaire, Exemplaire.codExemplaire,  commentExemplaire, disponible,
                               Emplacement.codEmplacement, libelEmplacement,                            
                               Bibliotheque.codBibliotheque, libelBibliotheque, adrBibliotheque,
                               Livre.IsbnLivre, titreLivre,
                               Theme.codTheme, libelTheme, descripTheme
                           FROM Adherent
                               JOIN Emprunt ON Adherent.numAdherent = Emprunt.numAdherent
                               JOIN Exemplaire ON Emprunt.numExemplaire = Exemplaire.numExemplaire
                               JOIN Emplacement ON Exemplaire.codBibliotheque = Emplacement.codBibliotheque AND Exemplaire.codEmplacement = Emplacement.codEmplacement
                               JOIN Bibliotheque ON Emplacement.codBibliotheque = Bibliotheque.codBibliotheque
                               JOIN Livre ON Exemplaire.IsbnLivre = Livre.IsbnLivre
                               JOIN Theme ON Livre.codTheme = Theme.codTheme
                           WHERE Bibliotheque.codBibliotheque = @CodBibliotheque AND YEAR(Emprunt.datEmprunt) = @Annee;";

            return ousine.ObtenirListe(parametres, sql);
        }

        public static Emprunt EmpruntEnCours(Exemplaire exemplaire)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();
            Utilitaires.RajouterParametre(parametres, "@NumExemplaire", exemplaire.Numero);

            string sql = @"SELECT Adherent.numAdherent, nomAdherent, prenomAdherent, adrAdherent, teleAdherent, perimeLe,
                               datEmprunt, datRestitutionPrev, datRestitutionEff,                             
                               Exemplaire.numExemplaire, Exemplaire.codExemplaire,  commentExemplaire, disponible,
                               Emplacement.codEmplacement, libelEmplacement,                            
                               Bibliotheque.codBibliotheque, libelBibliotheque, adrBibliotheque,
                               Livre.IsbnLivre, titreLivre,
                               Theme.codTheme, libelTheme, descripTheme
                           FROM Adherent
                               JOIN Emprunt ON Adherent.numAdherent = Emprunt.numAdherent
                               JOIN Exemplaire ON Emprunt.numExemplaire = Exemplaire.numExemplaire
                               JOIN Emplacement ON Exemplaire.codBibliotheque = Emplacement.codBibliotheque AND Exemplaire.codEmplacement = Emplacement.codEmplacement
                               JOIN Bibliotheque ON Emplacement.codBibliotheque = Bibliotheque.codBibliotheque
                               JOIN Livre ON Exemplaire.IsbnLivre = Livre.IsbnLivre
                               JOIN Theme ON Livre.codTheme = Theme.codTheme
                           WHERE Exemplaire.numExemplaire = @NumExemplaire AND datRestitutionEff IS NULL;";

            return ousine.Obtenir(parametres, sql);

        }

        /// <summary>
        /// Renvoie la liste des emprunts non rendus par l'adhérent.
        /// </summary>
        /// <param name="adherent">Un utilisateur du système.</param>
        /// <returns>Emprunts non rendus.</returns>
        public static List<Emprunt> ObtenirEmpruntsEnCours(Adherent adherent)
        {
            List<SqlParameter> parametres = new List<SqlParameter>();
            Utilitaires.RajouterParametre(parametres, "@NumAdherent", adherent.Numero);
            string sql = @"SELECT Adherent.numAdherent, nomAdherent, prenomAdherent, adrAdherent, teleAdherent, perimeLe,
                               datEmprunt, datRestitutionPrev, datRestitutionEff,                             
                               Exemplaire.numExemplaire, Exemplaire.codExemplaire,  commentExemplaire, disponible,
                               Emplacement.codEmplacement, libelEmplacement,                            
                               Bibliotheque.codBibliotheque, libelBibliotheque, adrBibliotheque,
                               Livre.IsbnLivre, titreLivre,
                               Theme.codTheme, libelTheme, descripTheme
                           FROM Adherent
                               JOIN Emprunt ON Adherent.numAdherent = Emprunt.numAdherent
                               JOIN Exemplaire ON Emprunt.numExemplaire = Exemplaire.numExemplaire
                               JOIN Emplacement ON Exemplaire.codBibliotheque = Emplacement.codBibliotheque AND Exemplaire.codEmplacement = Emplacement.codEmplacement
                               JOIN Bibliotheque ON Emplacement.codBibliotheque = Bibliotheque.codBibliotheque
                               JOIN Livre ON Exemplaire.IsbnLivre = Livre.IsbnLivre
                               JOIN Theme ON Livre.codTheme = Theme.codTheme
                           WHERE Adherent.numAdherent = @NumAdherent AND datRestitutionEff IS NULL";

            return ousine.ObtenirListe(parametres, sql);
        }



        /// <summary>
        /// Renvoie la liste des années avec au moins un emprunt répertorié.
        /// </summary>
        /// <returns>Liste des années.</returns>
        public static List<int> ListerAnnees()
        {
            List<int> annees = new List<int>();


            string sql = @"SELECT DISTINCT YEAR(datEmprunt)
                                FROM Emprunt;";
      

            foreach (DataRow row in BaseDeDonnees.Rechercher(sql).Rows)
            {
                annees.Add((int)row[0]);
            }

            return annees;
        }

        /// <summary>
        /// Insère dans la base un emprunt pour l'exemplaire et l'adhérent spécifiés à la date d'aujourd'hui.
        /// </summary>
        /// <param name="adherent"></param>
        /// <param name="exemplaire"></param>
        public static void Inserer(Adherent adherent, Exemplaire exemplaire)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@NumAdherent", adherent.Numero);
            cmd.Parameters.AddWithValue("@NumExemplaire", exemplaire.Numero);
            //cmd.Parameters.AddWithValue("@DatEmprunt", DateTime.Now);
            cmd.Parameters.AddWithValue("@DatRestitutionPrev", DateTime.Now + Emprunt.DUREE_MAXIMALE);
            cmd.CommandText = @"INSERT INTO Emprunt (numAdherent, numExemplaire, datEmprunt, datRestitutionPrev, datRestitutionEff)
                                VALUES(@NumAdherent, @NumExemplaire, GETDATE(), @DatRestitutionPrev, NULL);";
            BaseDeDonnees.Executer(cmd);
            exemplaire.Disponible = false;
            Exemplaire.MettreAJour(exemplaire);
        }


        public static void MettreAJour(Emprunt emprunt)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@NumAdherent", emprunt.Adherent.Numero);
            cmd.Parameters.AddWithValue("@NumExemplaire", emprunt.Exemplaire.Numero);
            cmd.Parameters.AddWithValue("@DatEmprunt", emprunt.DateEmprunt);
            cmd.Parameters.AddWithValue("@DatRestitutionPrev", DateTime.Now + Emprunt.DUREE_MAXIMALE);
            cmd.CommandText = @"UPDATE Emprunt
                                SET datRestitutionPrev =  @DatRestitutionPrev, datRestitutionEff = GETDATE()
                                WHERE numAdherent = @NumAdherent AND numExemplaire = @NumExemplaire AND datEmprunt = @DatEmprunt;";
            BaseDeDonnees.Executer(cmd);
            emprunt.Exemplaire.Disponible = true;
            Exemplaire.MettreAJour(emprunt.Exemplaire);
        }
        /// <summary>
        /// Durée maximale d'un emprunt.
        /// </summary>
        public static readonly TimeSpan DUREE_MAXIMALE = TimeSpan.FromDays(15);

        /// <summary>
        /// Un utilisateur du système
        /// </summary>
        public Adherent Adherent { get; private set; }

        /// <summary>
        /// Un exemplaire d'un livre.
        /// </summary>
        public Exemplaire Exemplaire { get; private set; }

        /// <summary>
        /// Date de l'emprunt.
        /// </summary>
        public DateTime DateEmprunt { get; private set; }

        /// <summary>
        /// Date de restitution prévue.
        /// </summary>
        public DateTime? DateRestitutionPrevue { get; set; }

        /// <summary>
        /// Date de restitution effective.
        /// </summary>
        public DateTime? DateRestitutionEffective { get; set; }

        /// <summary>
        /// Vrais si l'exemplaire a été restitué.
        /// </summary>
        public bool EstRestitue { get => DateRestitutionEffective != null; }

        /// <summary>
        /// Vrais si la date limite est dépassé sans restitution de l'exemplaire.
        /// </summary>
        public bool EstEnRetard
        {
            get
            {
                return DateRestitutionPrevue != null &&
                !EstRestitue &&
                Utilitaires.TronquerJour((DateTime)DateRestitutionPrevue) < Utilitaires.TronquerJour(DateTime.Now);
            }
        }

        /// <summary>
        /// Crée un emprunt pour l'exemplaire et l'adhérent spécifiés à la date spécifiée.
        /// </summary>
        /// <param name="adherent">Adhérent.</param>
        /// <param name="exemplaire">Exemplaire.</param>
        /// <param name="dateEmprunt">Date d'emprunt.</param>
        public Emprunt(Adherent adherent, Exemplaire exemplaire, DateTime dateEmprunt)
        {
            Adherent = adherent;
            Exemplaire = exemplaire;
            DateEmprunt = dateEmprunt;
        }

        /// <summary>
        /// Chaîne qui représente l'emprunt.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Exemplaire.Code}, {Exemplaire.Livre.Titre}, Emprunt : {DateEmprunt}, Jusqu'à : {DateRestitutionPrevue}, Restitué : {EstRestitue}";
    }
}
