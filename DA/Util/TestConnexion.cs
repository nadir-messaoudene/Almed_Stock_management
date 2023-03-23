using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public static class TestConnexion
    {
        private static SqlConnection connexion;

        public static string TestConnexionString(string provider, string serverName, string dataBaseName , string login, string password)
        {
            try
            {
                connexion = new SqlConnection("Server = " + serverName + "; Database = " + dataBaseName + "; User Id = " + login + "; Password = " + password);
                connexion.Open();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                if (connexion.State == System.Data.ConnectionState.Open)
                    connexion.Close();
            }
        }

        public static string SaveConnexionString(string serverName, string dataBaseName, string login, string password)
        {
            try
            {
                Properties.Settings.Default.sqlDataConnection = "Server = " + serverName + "; Database = " + dataBaseName + "; User Id = " + login + "; Password = " + password;
                Properties.Settings.Default.sqlServerName = serverName;
                Properties.Settings.Default.sqlDataBase = dataBaseName;
                Properties.Settings.Default.loginName = login;
                Properties.Settings.Default.Save();

                return "Connexion string saving succes";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static string GetCurentSqlServerName()
        {
            return Properties.Settings.Default.sqlServerName;
        }
        public static string GetCurentSqlDataBase()
        {
            return Properties.Settings.Default.sqlDataBase;
        }

        public static void TestCurrentConnexionString()
        {
            try
            {
                connexion = new SqlConnection(Properties.Settings.Default.sqlDataConnection);
                connexion.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connexion.State == System.Data.ConnectionState.Open)
                    connexion.Close();
            }
        }

        public static string GetCurentLoginName()
        {
            return Properties.Settings.Default.loginName;
        }
    }
}
