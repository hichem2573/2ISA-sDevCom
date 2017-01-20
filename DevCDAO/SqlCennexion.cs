using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCDAO
{
    /// <summary>
    /// 
    /// </summary>
    public static class SqlConnexion
    {
        private static string connexionString = Properties.Settings.Default.InfoConnexion;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnexion()
        {
            SqlConnection connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;

            return connexion;
        }
    }
}
