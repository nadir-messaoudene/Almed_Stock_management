using AlmedFramework;
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
                Logger.Log.Info("Start - recording a new RequeteBL");
                connexion.Open();

                var RequeteArtCode = "SELECT " +
                                    "ARTCODE  " +
                                    "FROM [ALMED].[dbo].[ARTICLES_P] a " +
                                    "inner join [ALMED].[dbo].[ARTICLES] b on a.ARTID=b.ARTID " +
                                    "where BYG='" + code + "'";
                SqlCommand cd = new SqlCommand(RequeteArtCode, connexion);
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
                Logger.Log.Info("End - geting RequeteBL");
                return result;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                if (connexion.State == System.Data.ConnectionState.Open)
                    connexion.Close();
            }
        }
    }
}
