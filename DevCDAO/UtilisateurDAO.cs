﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCDAO
{
    public abstract class UtilisateurDAO
    {

        #region "Property et attributs"

        private static SqlConnection con = SqlConnexion.GetConnexion();
        #endregion

        #region "Constructeurs"
        #endregion

        #region "Methodes"

        /// <summary>
        /// La méthode Login, permet l'authantification d'un utilisateur
        /// </summary>
        /// <param name="login">Le login de l'utilisateur</param>
        /// <param name="password">Le mot de passe de l'utilisateur</param>
        /// <returns>DataTable</returns>
        public static DataTable Login(string login, string password)
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetLoginPassword";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parLogin = cmd.CreateParameter(); //On creer une nouvelle instance d'objet sqlParameter
            parLogin.ParameterName = "@Login";
            parLogin.Value = login;
            cmd.Parameters.Add(parLogin);

            SqlParameter parMDP = cmd.CreateParameter();
            parMDP.ParameterName = "@Password";
            parMDP.Value = password;
            cmd.Parameters.Add(parMDP);

            // on ajout un bloc try catch pour gérer l'exception 
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Login");
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
        /// La méthode GetUtilisateurByID, permet de récupérer un utilisateur,
        /// On passant son id en parametre
        /// </summary>
        /// <param name="iduser">L'identidiant de l'urilisateur</param>
        /// <returns>Un DataTable</returns>
        public static DataTable GetUtilisateurByID(int iduser)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetUserByID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@iduser";
            parm.Value = iduser;
            cmd.Parameters.Add(parm);

            // on ajout un bloc try catch pour gérer l'exception 
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Utilisateurs");
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
        /// La méthode GetAllUtilisateur, permet de récupérer tous les utilisateur
        /// </summary>
        /// <returns>DataTble de la liste des utilisateurs</returns>
        public static DataTable GetAllUtilisateur()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllUtilisateurs";
            cmd.CommandType = CommandType.StoredProcedure;


            // on ajout un bloc try catch pour gérer l'exception
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Utilisateurs");
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
        /// Méthode permettant à un utilisateur de changer son mot de passe 
        /// </summary>
        /// <param name="iduser">L'identifiant utilisateur</param>
        /// <param name="password">Mot de passe utilisateur</param>
        /// <returns>Retourne 1 quand ça se passe bien</returns>
        public static int EditPassword(int iduser, string password)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "ModifierPassword";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdUser = cmd.CreateParameter(); //On creer une nouvelle instance d'objet sqlParameter
            parIdUser.ParameterName = "@ID_Utilisateur";
            parIdUser.Value = iduser;
            cmd.Parameters.Add(parIdUser);

            SqlParameter parPassword = cmd.CreateParameter(); //On creer une nouvelle instance d'objet sqlParameter
            parPassword.ParameterName = "@PASSWORD";
            parPassword.Value = password;
            cmd.Parameters.Add(parPassword);

            // on ajout un bloc try catch pour gérer l'exception 
            try
            {
                con.Open();
                int nbligne = cmd.ExecuteNonQuery();
                con.Close();

                // si tout se passe bien on retourne le nombre de ligne affectées
                return nbligne;
            }
            // Si exception on récupere l'exception ou on affiche un message ou on retourne quelque chose
            catch (Exception)
            {
                // Si exception on retourne 0
                return 0;
            }
        }
    }
    #endregion

    #region "Methodes héritées et substituées"
    #endregion

    #region "Methodes à implementer pour les interfaces"
    #endregion

}

