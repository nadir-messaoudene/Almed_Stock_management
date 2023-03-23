using System.Data.SqlClient;
using System.Windows.Forms;

namespace DA
{
    public static class ConnectionToSql
    {
        private static SqlConnection connexion;

        public static SqlConnection GetInstance()
        {
            try
            {
                connexion = new SqlConnection(Properties.Settings.Default.sqlDataConnection);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.StackTrace);
            }
            return connexion;
        }
    }
}
