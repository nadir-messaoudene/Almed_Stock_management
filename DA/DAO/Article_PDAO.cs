using DC;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DA
{
    public class Article_PDAO : DAO<Article_P>
    {
        public Article_P GetCode(string code)
        {
            Article_P result = new Article_P();
            try
            {
                SqlConnexion = ConnectionToSql.GetInstance();
                SqlConnexion.Open();

                var RequeteArtCode = "SELECT [ARTCODE] " +
                                    "FROM [ALMED].[dbo].[ARTICLES] " +
                                    "where [ARTID] = '" + code + "'";
                SqlCommand cd = new SqlCommand(RequeteArtCode, SqlConnexion);
                using (var dr = cd.ExecuteReader())
                {
                    if(dr.Read())
                    {
                        result=
                            new Article_P()
                            {
                                Code = dr["ARTCODE"] != DBNull.Value ? dr["ARTCODE"].ToString() : string.Empty
                            };
                    }
                }
                return result;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                if (SqlConnexion.State == System.Data.ConnectionState.Open)
                    SqlConnexion.Close();
            }
        }
    }
}
