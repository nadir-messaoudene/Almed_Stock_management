using DC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DA
{
    public class PieceDiverDAO : DAO<PieceDivers>
    {
        public bool PieceAchatRecu(string id)
        {
            try
            {
                SqlConnexion = ConnectionToSql.GetInstance();
                SqlConnexion.Open();

                var RequeteUpdateRecu = "UPDATE [dbo].[PIECEACHATS_P] SET [RECU] = 'O' WHERE PCAID=" + id;

                SqlCommand cd = new SqlCommand(RequeteUpdateRecu, SqlConnexion);
                cd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Update piece divers -" + e.Message);
                return false;
            }
            finally
            {
                if (SqlConnexion.State == System.Data.ConnectionState.Open)
                    SqlConnexion.Close();
            }
        }
        public bool PieceDiversSolded(string id)
        {
            try
            {
                SqlConnexion = ConnectionToSql.GetInstance();
                SqlConnexion.Open();

                var Requete = "UPDATE [ALMED].[dbo].[PIECEDIVERS]  SET PCDISSOLDE = 'O' WHERE PCDID = " + id;

                SqlCommand cd = new SqlCommand(Requete, SqlConnexion);
                cd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Update piece divers -" + e.Message);
                return false;
            }
            finally
            {
                if (SqlConnexion.State == System.Data.ConnectionState.Open)
                    SqlConnexion.Close();
            }
        }
        public List<PieceDivers> GetPieceDivres()
        {
            List<PieceDivers> result = new List<PieceDivers>();
            try
            {
                SqlConnexion = ConnectionToSql.GetInstance();
                SqlConnexion.Open();

                var Requete = "SELECT * FROM [ALMED].[dbo].[PIECEDIVERS] WHERE(PINID = '17') and ( PCDISSOLDE = 'N')";

                SqlCommand cd = new SqlCommand(Requete, SqlConnexion);
                using (var dr = cd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(
                            new PieceDivers()
                            {
                                PCDID = dr["PCDID"] != DBNull.Value ? dr["PCDID"].ToString() : string.Empty,
                                PCDNUM = dr["PCDNUM"] != DBNull.Value ? dr["PCDNUM"].ToString() : string.Empty,
                                PCDATECREATED = dr["DATECREATE"] != DBNull.Value ? Convert.ToDateTime(dr["DATECREATE"].ToString()).ToShortDateString().ToString() : string.Empty
                            });
                    }
                }
                return result;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Getting piece de divers -" + e.Message);
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
