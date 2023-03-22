using AlmedFramework;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DA
{
    public static class ConnectionToSql
    {
        private static string _almedConnectionString = Properties.Settings.Default.AlmedDataConnection;
        private static SqlConnection connexion;

        public static SqlConnection GetWavesoftInstance()
        {
            if (connexion == null)
            {
                try
                {
                    Logger.Log.Info("Start - Connexion to Almed database");
                    connexion = new SqlConnection(_almedConnectionString);
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.StackTrace);
                    Logger.Log.Error("Almed database connextion failer", e);
                }
            }
            return connexion;
        }
    }
}
