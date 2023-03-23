using System;
using DC;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DA
{
    public class BondeLivraisonLigneDAO : DAO<BonLivraisonLigne>
    {
        public bool UpdateBonReceptionLigneBy(string bonLigne, string nlot)
        {
            try
            {
                SqlConnexion = ConnectionToSql.GetInstance();
                SqlConnexion.Open();
                var RequeteUpdateBonReception = "UPDATE [almed].[dbo].[PIECEACHATLIGNES]" +
                         " SET [PLANUMLOT] = '" + nlot + "'" +
                         " WHERE PLAID = '" + bonLigne + "'";
                SqlCommand sqlCommandvalider = new SqlCommand(RequeteUpdateBonReception, SqlConnexion);
                sqlCommandvalider.ExecuteNonQuery();
                return true;
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
        public List<BonLivraisonLigne> GetBonLivraisonLigneById(string id)
        {
            List<BonLivraisonLigne> result = new List<BonLivraisonLigne>();
            try
            {
                SqlConnexion = ConnectionToSql.GetInstance();
                SqlConnexion.Open();

                var RequeteLigneBL = "SELECT [PLVID],[PLVDESIGNATION] " +
                                     ",[PLVFEFOPEREMPTION] " +
                                     ",[PLVNUMLOT] " +
                                     ",[PLVARTCODE] " +
                                     ",[PLVQTE] " +
                                     ",[PLVFEFOPEREMPTION] " +
                                     "FROM [ALMEd].[dbo].[PIECEVENTELIGNES]" +
                                     "WHERE PCVID = " + id + " and PLVARTCODE <> '' and PLVARTCODE <> 'C&F'";

                SqlCommand cd = new SqlCommand(RequeteLigneBL, SqlConnexion);

                using (var dr = cd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(
                            new BonLivraisonLigne()
                            {
                                id = dr["PLVID"] != DBNull.Value ? dr["PLVID"].ToString() : string.Empty,
                                Designation = dr["PLVDESIGNATION"] != DBNull.Value ? dr["PLVDESIGNATION"].ToString() : string.Empty,
                                NLot = dr["PLVNUMLOT"] != DBNull.Value ? dr["PLVNUMLOT"].ToString() : string.Empty,
                                Code = dr["PLVARTCODE"] != DBNull.Value ? dr["PLVARTCODE"].ToString() : string.Empty,
                                DatePeremption = dr["PLVFEFOPEREMPTION"] != DBNull.Value ? Convert.ToDateTime(dr["PLVFEFOPEREMPTION"].ToString()).ToShortDateString().ToString() : string.Empty,
                                Qte = int.Parse((dr["PLVQTE"] != DBNull.Value ? dr["PLVQTE"].ToString() : string.Empty).Split(new char[] { ',', '\\', '.' })[0])
                            });
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

        public List<BonLivraisonLigne> GetBonDeLivraisonLigne()
        {
            List<BonLivraisonLigne> result = new List<BonLivraisonLigne>();
            try
            {
                SqlConnexion = ConnectionToSql.GetInstance();
                SqlConnexion.Open();

                var RequeteLigneBL = "SELECT "+
                    "PCVID, " +
                    "[PLVDESIGNATION] " +
                    ",[PLVFEFOPEREMPTION] " +
                    ",[PLVNUMLOT] " +
                    ",[PLVARTCODE] " +
                    ",[PLVQTE] " +
                    "FROM [ALMEd].[dbo].[PIECEVENTELIGNES]";

                SqlCommand cd = new SqlCommand(RequeteLigneBL, SqlConnexion);


                using (var dr = cd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(
                            new BonLivraisonLigne()
                            {
                                id = dr["PCVID"] != DBNull.Value ? dr["PCVID"].ToString() : string.Empty,
                                Designation = dr["PLVDESIGNATION"] != DBNull.Value ? dr["PLVDESIGNATION"].ToString() : string.Empty,
                                NLot = dr["PLVNUMLOT"] != DBNull.Value ? dr["PLVNUMLOT"].ToString() : string.Empty,
                                Code = dr["PLVARTCODE"] != DBNull.Value ? dr["PLVARTCODE"].ToString() : string.Empty,
                                DatePeremption = dr["PLVFEFOPEREMPTION"] != DBNull.Value ? Convert.ToDateTime(dr["PLVFEFOPEREMPTION"].ToString()).ToShortDateString().ToString() : string.Empty,
                                Qte = int.Parse((dr["PLVQTE"] != DBNull.Value ? dr["PLVQTE"].ToString() : string.Empty).Split(new char[] { ',', '\\', '.' })[0])
                            });
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
        public List<BonLivraisonLigne> GetCode()
        {
            List<BonLivraisonLigne> result = new List<BonLivraisonLigne>();
            try
            {
                SqlConnexion = ConnectionToSql.GetInstance();
                SqlConnexion.Open();
                string RequeteLigneBR = "SELECT [PLAID] " +
                                    ",[PCAID] " +
                                    ",[PLADESIGNATION] " +
                                    " ,[PLANUMLOT] " +
                                    ",[PLAFEFOPEREMPTION] " +
                                    ",[PLAPROCODE] " +
                                    ",[PLAQTE] " +
                                    "FROM [almed].[dbo].[PIECEACHATLIGNES]";

                SqlCommand cd = new SqlCommand(RequeteLigneBR, SqlConnexion);
                using (var dr = cd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(
                            new BonLivraisonLigne()
                            {
                                id = dr["PCAID"] != DBNull.Value ? dr["PCAID"].ToString() : string.Empty,
                                Designation = dr["PLADESIGNATION"] != DBNull.Value ? dr["PLADESIGNATION"].ToString() : string.Empty,
                                NLot = dr["PLANUMLOT"] != DBNull.Value ? dr["PLANUMLOT"].ToString() : string.Empty,
                                Code = dr["PLAPROCODE"] != DBNull.Value ? dr["PLAPROCODE"].ToString() : string.Empty,
                                DatePeremption = dr["PLAFEFOPEREMPTION"] != DBNull.Value ? Convert.ToDateTime(dr["PLAFEFOPEREMPTION"].ToString()).ToShortDateString().ToString() : string.Empty,
                                Qte = int.Parse((dr["PLAQTE"] != DBNull.Value ? dr["PLAQTE"].ToString() : string.Empty).Split(new char[] { ',', '\\', '.' })[0])
                            });
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

        public List<BonLivraisonLigne> GetLigneBonReceptionById(string id)
        {
            List<BonLivraisonLigne> result = new List<BonLivraisonLigne>();
            try
            {
                SqlConnexion = ConnectionToSql.GetInstance();
                SqlConnexion.Open();

                var RequeteLigneBR = "SELECT "+
                  " [PLAID] " +
                  ",[PCAID] " +
                  ",[PLADESIGNATION] " +
                 " ,[PLANUMLOT] " +
                 ",[PLAFEFOPEREMPTION] " +
                  ",[PLAPROCODE] " +
                  ",[PLAQTE] " +
                  "FROM [almed].[dbo].[PIECEACHATLIGNES]" +
                  " WHERE PCAID = " + id + " and PLAPROCODE <> '' ";

                SqlCommand cd = new SqlCommand(RequeteLigneBR, SqlConnexion);
                using (var dr = cd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(new BonLivraisonLigne()
                        {
                            id = dr["PLAID"] != DBNull.Value ? dr["PLAID"].ToString() : string.Empty,
                            Designation = dr["PLADESIGNATION"] != DBNull.Value ? dr["PLADESIGNATION"].ToString() : string.Empty,
                            NLot = dr["PLANUMLOT"] != DBNull.Value ? dr["PLANUMLOT"].ToString() : string.Empty,
                            Code = dr["PLAPROCODE"] != DBNull.Value ? dr["PLAPROCODE"].ToString() : string.Empty,
                            DatePeremption = dr["PLAFEFOPEREMPTION"] != DBNull.Value ? Convert.ToDateTime(dr["PLAFEFOPEREMPTION"].ToString()).ToShortDateString().ToString() : string.Empty,
                            Qte = int.Parse((dr["PLAQTE"] != DBNull.Value ? dr["PLAQTE"].ToString() : string.Empty).Split(new char[] { ',', '\\', '.' })[0])
                        });
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
        public List<BonLivraisonLigne> GetLBonReception()
        {
            List<BonLivraisonLigne> result = new List<BonLivraisonLigne>();
            try
            {
                SqlConnexion = ConnectionToSql.GetInstance();
                SqlConnexion.Open();

                var RequeteLigneBR = "SELECT [PLAID] " +
                  ",[PCAID] " +
                  ",[PLADESIGNATION] " +
                 " ,[PLANUMLOT] " + ",[PLAFEFOPEREMPTION] " +
                  ",[PLAPROCODE] " +
                  ",[PLAQTE] " +
                  "FROM [almed].[dbo].[PIECEACHATLIGNES]";

                SqlCommand cd = new SqlCommand(RequeteLigneBR, SqlConnexion);
                using (var dr = cd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(new BonLivraisonLigne()
                        {
                            id = dr["PCAID"] != DBNull.Value ? dr["PCAID"].ToString() : string.Empty,
                            Designation = dr["PLADESIGNATION"] != DBNull.Value ? dr["PLADESIGNATION"].ToString() : string.Empty,
                            NLot = dr["PLANUMLOT"] != DBNull.Value ? dr["PLANUMLOT"].ToString() : string.Empty,
                            Code = dr["PLAPROCODE"] != DBNull.Value ? dr["PLAPROCODE"].ToString() : string.Empty,
                            Qte = int.Parse((dr["PLAQTE"] != DBNull.Value ? dr["PLAQTE"].ToString() : string.Empty).Split(new char[] { ',', '\\', '.' })[0])
                        });
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
