using AlmedFramework;
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
                Logger.Log.Info("Start - achat recu piecedivers");
                connexion.Open();

                var RequeteUpdateRecu = "UPDATE [dbo].[PIECEACHATS_P] " +
                              "SET [RECU] = 'O' " +
                              "WHERE PCAID=" + id;

                SqlCommand cd = new SqlCommand(RequeteUpdateRecu, connexion);
                cd.ExecuteNonQuery();
                Logger.Log.Info("End - RequeteUpdateRecu piecedivers");
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Update piece de divers -" + e.Message);
                return false;
            }
            finally
            {
                if (connexion.State == System.Data.ConnectionState.Open)
                    connexion.Close();
            }
        }
        public bool PieceDiversSolded(string id)
        {
            try
            {
                Logger.Log.Info("Start - solding piecedivers");
                connexion.Open();

                var Requete = "UPDATE PIECEDIVERS SET PCDISSOLDE = 'O' WHERE PCDID = " + id;

                SqlCommand cd = new SqlCommand(Requete, connexion);
                cd.ExecuteNonQuery();
                Logger.Log.Info("End - solding piecedivers");
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Update piece de divers -" + e.Message);
                return false;
            }
            finally
            {
                if (connexion.State == System.Data.ConnectionState.Open)
                    connexion.Close();
            }
        }
        public List<PieceDivers> GetPieceDivres()
        {
            List<PieceDivers> result = new List<PieceDivers>();
            try
            {
                Logger.Log.Info("Start - get piece divers");
                connexion.Open();

                var Requete = "SELECT * FROM PIECEDIVERS WHERE(PINID = '17') and ( PCDISSOLDE = 'N')";

                SqlCommand cd = new SqlCommand(Requete, connexion);
                using (var dr = cd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(
                            new PieceDivers()
                            {
                                PCDID = dr["PCDID"] != DBNull.Value ? dr["PCDID"].ToString() : string.Empty,
                                PCDNUM = dr["PCDNUM"] != DBNull.Value ? dr["PCDNUM"].ToString() : string.Empty,
                                PCDATECREATED = dr["DATECREATE"] != DBNull.Value ? dr["DATECREATE"].ToString() : string.Empty
                            });
                    }
                }
                Logger.Log.Info("End - geting piece divers");
                return result;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Getting piece de divers -" + e.Message);
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
