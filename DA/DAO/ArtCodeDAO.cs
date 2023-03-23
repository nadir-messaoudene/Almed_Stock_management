
using System.Data.SqlClient;
using DC;

namespace DA
{
    public class ArtCodeDAO : DAO<ArtCode>
    {
        public  ArtCode GetArtCode(string artCode)
        {
            ArtCode result = new ArtCode();
            try
            {
                SqlConnexion = ConnectionToSql.GetInstance();
                SqlConnexion.Open();


                var RequeteArtCode = "SELECT " +
                  "ARTCODE  " +
                  "FROM [ALMED].[dbo].[ARTICLES_P] a " +
                  "inner join [ALMED].[dbo].[ARTICLES] b on a.ARTID=b.ARTID " +
                  "where BYG='" + artCode + "'";

                SqlCommand cd = new SqlCommand(RequeteArtCode, SqlConnexion);

                result.artCode = cd.ExecuteReader()[0].ToString();
                
                return result;
            }
            catch (SqlException e)
            {
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
