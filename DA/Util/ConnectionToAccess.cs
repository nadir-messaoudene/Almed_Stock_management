using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace DA
{
    public static class ConnectionToAccess
    {
        private static OleDbConnection connexion;
        private static readonly string accessDataConnection = 
            "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = "+
            Path.GetDirectoryName(Application.ExecutablePath) + "\\DB\\AlmedStock.accdb; Persist Security Info=True";

        public static OleDbConnection GetInstance()
        {
            try
            {
                connexion = new OleDbConnection(accessDataConnection);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.StackTrace);
            }
            return connexion;
        }
    }
}
