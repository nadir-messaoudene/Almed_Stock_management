using DC;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DA
{
    public class ArticlesDAO : DAO<Articles>
    {
        public Articles GetArticles()
        {
            Articles result = new Articles();
            try
            {
                SqlConnexion = ConnectionToSql.GetInstance();
                SqlConnexion.Open();

                var RequeteArticles = "SELECT *" +
                                     "FROM  [ALMED].[dbo].[ARTICLES] a" +
                                    "WHERE  a.ARTCODE not like '%-N'";

                SqlCommand cd = new SqlCommand(RequeteArticles, SqlConnexion);
                using (var dr = cd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        result =
                            new Articles()
                            {
                                ARTCODE = dr["ARTCODE"] != DBNull.Value ? dr["ARTCODE"].ToString() : string.Empty,
                                QTY = int.Parse((dr["ARTQTEACHAT"] != DBNull.Value ? dr["ARTQTEACHAT"].ToString() : string.Empty).Split(new char[] { ',', '\\', '.' })[0])
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

        public Articles GetCode(string code)
        {
            Articles result = new Articles();
            try
            {
                SqlConnexion = ConnectionToSql.GetInstance();
                SqlConnexion.Open();

                var RequeteArticles = "SELECT * FROM  ARTICLES WHERE  ARTID = " + code;
                SqlCommand cd = new SqlCommand(RequeteArticles, SqlConnexion);
                using (var dr = cd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        result =
                            new Articles()
                            {
                                ARTCODE = dr["ARTCODE"] != DBNull.Value ? dr["ARTCODE"].ToString() : string.Empty,
                                QTY = int.Parse((dr["ARTQTEACHAT"] != DBNull.Value ? dr["ARTQTEACHAT"].ToString() : string.Empty).Split(new char[] { ',', '\\', '.' })[0])
                            };
                    }
                }
                return result;
            }
            catch (SqlException e)
            {
                MessageBox.Show("get vrac" + e.Message);
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
