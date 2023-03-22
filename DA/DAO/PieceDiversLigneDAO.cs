using System.Collections.Generic;
using DC;
using AlmedFramework;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace DA
{
    public class PieceDiversLigneDAO : DAO<PieceDiversLigne>
    {
        public List<PieceDiversLigne> GetPieceVentLigneByID(string code)
        {
            List<PieceDiversLigne> result = new List<PieceDiversLigne>();
            try
            {
                Logger.Log.Info("Start - get piece divers ligne");
                connexion.Open();

                var Requete = "SELECT * FROM PIECEDIVERSLIGNES WHERE ( PCDID ="+ code + ") and ( ARTTYPE = 'N')";

                SqlCommand cd = new SqlCommand(Requete, connexion);
                using (var dr = cd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        result.Add(
                            new PieceDiversLigne()
                            {
                                PLDID = dr["PCDID"] != DBNull.Value ? dr["PCDID"].ToString() : string.Empty,
                                PLDDESIGNATION = dr["PLDDESIGNATION"] != DBNull.Value ? dr["PLDDESIGNATION"].ToString() : string.Empty,
                                PLDNUMLOT = dr["PLDNUMLOT"] != DBNull.Value ? dr["PLDNUMLOT"].ToString() : string.Empty,
                                ARTID = dr["ARTID"] != DBNull.Value ? dr["ARTID"].ToString() : string.Empty,
                                Qte = int.Parse((dr["PLDQTEUS"] != DBNull.Value ? dr["PLDQTEUS"].ToString() : string.Empty).Split(new char[] { ',', '\\', '.' })[0])
                            });
                    }
                }
                Logger.Log.Info("End - geting piece divers ligne");
                return result;
            }
            catch (SqlException e)
            {
                MessageBox.Show("End - geting piece divers ligne" + e.Message);
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
