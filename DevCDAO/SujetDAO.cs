﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCDAO
{
    /// <summary>
    /// La classe SujetDAO, pemet la récupération de tous les sujets, l'ajout d'un sujet, la modéfication 
    /// ou la suppression dans la base de données
    /// </summary>
    public static class SujetDAO
    {
        #region "Property et attributs"
        private static SqlConnection con = SqlConnexion.GetConnexion();
        #endregion

        #region "Constructeurs"
        #endregion

        #region "Méthodes"
        /// <summary>
        /// La méthode GetSujetByID, permet de retourné un sujet dont l'identifiant est passé en parametre
        /// </summary>
        /// <param name="idsujet">L'identifiant du sujet</param>
        /// <returns>Le sujet</returns>
        public static DataTable GetSujetByID(int idsujet)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetSujetByID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@IdSujet";
            parm.Value = idsujet;
            cmd.Parameters.Add(parm);

            // on ajout un bloc try catch pour gérer l'exception 
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Sujet");
                da.Fill(dt);

                // si tout se passe bien on retourne le DataTable
                return dt;
            }

            // Si exception on récupere l'exception ou on affiche un message ou on retourne quelque chose
            catch (Exception)
            {
                // Si exception on retourne null
                return null;
            }

        }
        /// <summary>
        /// La méthode GetAllSujets, retourne tous les sujets
        /// </summary>
        /// <returns>DataTable de tous les sujets</returns>
        public static DataTable GetAllSujets()
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllSujets";
            cmd.CommandType = CommandType.StoredProcedure;

            // on ajout un bloc try catch pour gérer l'exception 
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("TousLesSujet");
                da.Fill(dt);

                // si tout se passe bien on retourne le DataTable
                return dt;
            }

            // Si exception on récupere l'exception ou on affiche un message ou on retourne quelque chose

            catch (Exception)
            {
                // Si exception on retourne null
                return null;
            }

        }

        /// <summary>
        /// La méthode GetSujetByCategorieID, permet de récupérer les sujet d'une catégorie
        /// Dont l'id est passé en parametre
        /// </summary>
        /// <param name="idcategorie">L'identifiant de la categorie</param>
        /// <returns>DataTable des sujets d'une categorie</returns>
        public static DataTable GetSujetsByCategorieID(int idcategorie)
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetSujetsByCategorieID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@IdCategorie";
            parm.Value = idcategorie;
            cmd.Parameters.Add(parm);

            // on ajout un bloc try catch pour gérer l'exception 
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("TousLesSujet");
                da.Fill(dt);

                // si tout se passe bien on retourne le DataTable
                return dt;
            }
            // Si exception on récupere l'exception ou on affiche un message ou on retourn quelque chose
            catch (Exception)
            {
                // Si exception on retourne null
                return null;
            }

        }

        /// <summary>
        /// La méthode AddSujet, permet l'ajout d'un nouveau sujet à la base de données
        /// </summary>
        /// <param name="idUtilisateur">L'identifiant de l'utilisateur</param>
        /// <param name="idCategorie">L'identifiant de la categorie</param>
        /// <param name="titre">Le titre du nouveau sujet</param>
        /// <param name="description">La description du sujet ajouter</param>
        /// <returns>retourne le nombre de lignes affectées, 1 si tout va bien</returns>
        public static int AddSujet(int idUtilisateur, int idCategorie, string titre, string description)
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "AddSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdUtilisateur = cmd.CreateParameter();
            parmIdUtilisateur.ParameterName = "@ID_UTILISATEUR";
            parmIdUtilisateur.Value = idUtilisateur;
            cmd.Parameters.Add(parmIdUtilisateur);

            SqlParameter parmIdCategorie = cmd.CreateParameter();
            parmIdCategorie.ParameterName = "@ID_CATEGORIE";
            parmIdCategorie.Value = idCategorie;
            cmd.Parameters.Add(parmIdCategorie);

            SqlParameter parmTitre = cmd.CreateParameter();
            parmTitre.ParameterName = "@TITRE";
            parmTitre.Value = titre;
            cmd.Parameters.Add(parmTitre);

            SqlParameter parmDescr = cmd.CreateParameter();
            parmDescr.ParameterName = "@DESCRIPTION";
            parmDescr.Value = description;
            cmd.Parameters.Add(parmDescr);

            // on ajout un bloc try catch pour gérer l'exception 
            try
            {
                con.Open();
                int nbLigne = cmd.ExecuteNonQuery();
                con.Close();

                // si tout se passe bien on retourne le nombre de ligne affectées
                return nbLigne;
            }

            // Si exception on récupere l'exception ou on affiche un message ou on retourn quelque chose
            catch (Exception)
            {
                // Si exception on retourne 0
                return 0;
            }
        }

        /// <summary>
        /// Méthode permettant la modification de titre et/ou la description
        /// </summary>
        /// <param name="idsujet">L'identifiant du sujet</param>
        /// <param name="oldTitre">l'ancien Titre</param>
        /// <param name="oldDescription">L'ancienne description</param>
        /// <param name="newTitre">Le nouveau Titre</param>
        /// <param name="newDescription">La nouvelle Description</param>
        /// <returns>return 1 si tout ce passe bien</returns>
        public static int ModifierSujet(int idsujet, string oldTitre, string oldDescription, string newTitre, string newDescription)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "ModifierSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdSujet = cmd.CreateParameter();
            parmIdSujet.ParameterName = "@ID_SUJET";
            parmIdSujet.Value = idsujet;
            cmd.Parameters.Add(parmIdSujet);

            SqlParameter parmNewTitre = cmd.CreateParameter();
            parmNewTitre.ParameterName = "@NEW_TITRE";
            parmNewTitre.Value = newTitre;
            cmd.Parameters.Add(parmNewTitre);

            SqlParameter parmOldTitre = cmd.CreateParameter();
            parmOldTitre.ParameterName = "@OLD_TITRE";
            parmOldTitre.Value = oldTitre;
            cmd.Parameters.Add(parmOldTitre);

            SqlParameter parmNewDescr = cmd.CreateParameter();
            parmNewDescr.ParameterName = "@NEW_DESC";
            parmNewDescr.Value = newDescription;
            cmd.Parameters.Add(parmNewDescr);

            SqlParameter parmOldDescr = cmd.CreateParameter();
            parmOldDescr.ParameterName = "@OLD_DESC";
            parmOldDescr.Value = oldDescription;
            cmd.Parameters.Add(parmOldDescr);

            // on ajout un bloc try catch pour gérer l'exception 
            try
            {
                con.Open();
                int nbLigne = cmd.ExecuteNonQuery();
                con.Close();
                // si tout se passe bien on le nombre de ligne affectées
                return nbLigne;
            }
            // Si exception on récupere l'exception ou on affiche un message ou on retourn quelque chose
            catch (Exception)
            {
                // Si exception on retourne 0
                return 0;
            }

        }

        /// <summary>
        /// La méthode DeleteSujet, permet la suppression d'un sujet dont l'id est passé en paramètre
        /// </summary>
        /// <param name="idSujet">L'identifiant du sujet</param>
        /// <returns>le nombre de lignes suprimées, nbLigne = 1 si tout va bien </returns>
        public static int DeleteSujet(int idSujet)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DeleteSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdSujet = cmd.CreateParameter();
            parmIdSujet.ParameterName = "@ID_SUJET";
            parmIdSujet.Value = idSujet;
            cmd.Parameters.Add(parmIdSujet);
            // on ajout un bloc try catch pour gérer l'exception
            try
            {
                con.Open();
                int nbLigne = cmd.ExecuteNonQuery();
                con.Close();
                // si tout se passe bien on le nombre de ligne affectées
                return nbLigne;
            }

            // Si exception on récupere l'exception ou on affiche un message ou on retourn quelque chose
            catch (Exception)
            {
                // Si exception on retourne 0
                return 0;
            }
        }
        #endregion

        #region "Méthodes héritées et substituées"
        #endregion

        #region "Méthodes à implementer pour les interfaces"
        #endregion
    }
}
