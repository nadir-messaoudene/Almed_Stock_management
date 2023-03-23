using DC;
using System.Data.SqlClient;

namespace DA
{
    public class PieceVenteDAO : DAO<PieceVente_P>
    {
        public PieceVenteDAO()
        {

        }

        public bool UpdateLivraison(string id)
        {
            try
            {
                SqlConnexion = ConnectionToSql.GetInstance();
                SqlConnexion.Open();
                var RequeteUpdateLivre = "UPDATE [dbo].[PIECEVENTES_P] " +
                         "SET [Livre] = 'O' " +
                         "WHERE PCVID=" + id;
                SqlCommand sqlCommandvalider = new SqlCommand(RequeteUpdateLivre, SqlConnexion);
                sqlCommandvalider.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                return false;
                throw e;
            }
            finally
            {
                if (SqlConnexion.State == System.Data.ConnectionState.Open)
                    SqlConnexion.Close();
            }
        }
    }
}
