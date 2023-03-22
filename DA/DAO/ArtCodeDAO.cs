using AlmedFramework;
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
                Logger.Log.Info("Start - recording a new artCode");
                connexion.Open();


                var RequeteArtCode = "SELECT " +
                  "ARTCODE  " +
                  "FROM [ALMED].[dbo].[ARTICLES_P] a " +
                  "inner join [ALMED].[dbo].[ARTICLES] b on a.ARTID=b.ARTID " +
                  "where BYG='" + artCode + "'";

                SqlCommand cd = new SqlCommand(RequeteArtCode, connexion);

                result.artCode = cd.ExecuteReader()[0].ToString();
                
                Logger.Log.Info("End - geting artCode");
                return result;
            }
            catch (SqlException e)
            {
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
