using AlmedFramework;
using DC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DA
{
    public class PieceVenteDAO : DAO<PieceVente_P>
    {
        public PieceVenteDAO()
        {

        }

        public bool update(string id)
        {
            try
            {
                connexion.Open();
                var RequeteUpdateLivre = "UPDATE [dbo].[PIECEVENTES_P] " +
                         "SET [Livre] = 'O' " +
                         "WHERE PCVID=" + id;
                SqlCommand sqlCommandvalider = new SqlCommand(RequeteUpdateLivre, connexion);
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
                if (connexion.State == System.Data.ConnectionState.Open)
                    connexion.Close();
            }
        }
    }
}
