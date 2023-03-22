using System;
using DC;
using System.Collections.Generic;
using AlmedFramework;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DA
{
    public class BondeLivraisonLigneDAO : DAO<BonLivraisonLigne>
    {

        public bool UpdateBonLivraisonLigneBy(string bonLigne, string nlot)
        {
            try
            {
                connexion.Open();
                var RequeteUpdateBonReception = "UPDATE [almed].[dbo].[PIECEACHATLIGNES]" +
                         " SET [PLANUMLOT] = '" + nlot + "'" +
                         " WHERE PLAID = '" + bonLigne + "'";
                SqlCommand sqlCommandvalider = new SqlCommand(RequeteUpdateBonReception, connexion);
                sqlCommandvalider.ExecuteNonQuery();
                return true;
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
        public List<BonLivraisonLigne> GetBonLivraisonLigneById(string id)
        {
            List<BonLivraisonLigne> result = new List<BonLivraisonLigne>();
            try
            {
                Logger.Log.Info("Start - recording a new BonLivraisonLigne");
                connexion.Open();

                var RequeteLigneBL = "SELECT PCVID,[PLVDESIGNATION] " +
                                     ", PLVFEFOPEREMPTION " +
                                     ",[PLVNUMLOT] " +
                                     ",[PLVARTCODE] " +
                                     ",PLVQTE " +
                                     "FROM [ALMEd].[dbo].[PIECEVENTELIGNES]" +
                                     "WHERE PCVID = " + id + " and PLVARTCODE <> '' and PLVARTCODE <> 'C&F'";

                SqlCommand cd = new SqlCommand(RequeteLigneBL, connexion);


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
                                Qte = int.Parse((dr["PLVQTE"] != DBNull.Value ? dr["PLVQTE"].ToString() : string.Empty).Split(new char[] { ',', '\\', '.' })[0])
                            });
                    }
                }
                Logger.Log.Info("End - geting BonLivraisonLigne");
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

        public List<BonLivraisonLigne> GetBonDeLivraisonLigne()
        {
            List<BonLivraisonLigne> result = new List<BonLivraisonLigne>();
            try
            {
                Logger.Log.Info("Start - recording a new BonLivraisonLigne");
                connexion.Open();

                var RequeteLigneBL = "SELECT "+
                    "PCVID, " +
                    "[PLVDESIGNATION] " +
                    ",[PLVFEFOPEREMPTION] " +
                    ",[PLVNUMLOT] " +
                    ",[PLVARTCODE] " +
                    ",[PLVQTE] " +
                    "FROM [ALMEd].[dbo].[PIECEVENTELIGNES]";

                SqlCommand cd = new SqlCommand(RequeteLigneBL, connexion);


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
                                DatePeremption = dr["PLVFEFOPEREMPTION"] != DBNull.Value ? dr["PLVFEFOPEREMPTION"].ToString() : string.Empty,
                                Qte = int.Parse((dr["PLVQTE"] != DBNull.Value ? dr["PLVQTE"].ToString() : string.Empty).Split(new char[] { ',', '\\', '.' })[0])
                            });
                    }
                }
                Logger.Log.Info("End - geting BonLivraisonLigne");
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
        public List<BonLivraisonLigne> getCode()
        {
            List<BonLivraisonLigne> result = new List<BonLivraisonLigne>();
            try
            {
                string RequeteLigneBR = "SELECT [PLAID] " +
                                    ",[PCAID] " +
                                    ",[PLADESIGNATION] " +
                                    " ,[PLANUMLOT] " +
                                    ",[PLAFEFOPEREMPTION] " +
                                    ",[PLAPROCODE] " +
                                    ",[PLAQTE] " +
                                    "FROM [almed].[dbo].[PIECEACHATLIGNES]";

                SqlCommand cd = new SqlCommand(RequeteLigneBR, connexion);
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
                                DatePeremption = dr["PLAFEFOPEREMPTION"] != DBNull.Value ? dr["PLAFEFOPEREMPTION"].ToString() : string.Empty,
                                Qte = int.Parse((dr["PLAQTE"] != DBNull.Value ? dr["PLAQTE"].ToString() : string.Empty).Split(new char[] { ',', '\\', '.' })[0])
                            });
                    }
                }

                Logger.Log.Info("End - geting BonLivraisonLigne");
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

        public List<BonLivraisonLigne> getLigneBonReceptionById(string id)
        {
            List<BonLivraisonLigne> result = new List<BonLivraisonLigne>();
            try
            {
                Logger.Log.Info("Start - recording a new RequeteBR");
                connexion.Open();

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

                SqlCommand cd = new SqlCommand(RequeteLigneBR, connexion);
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
                            DatePeremption = dr["PLAFEFOPEREMPTION"] != DBNull.Value ? dr["PLAFEFOPEREMPTION"].ToString() : string.Empty,
                            Qte = int.Parse((dr["PLAQTE"] != DBNull.Value ? dr["PLAQTE"].ToString() : string.Empty).Split(new char[] { ',', '\\', '.' })[0])
                        });
                    }
                }
                Logger.Log.Info("End - geting RequeteBR");
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
        public List<BonLivraisonLigne> getLBonReception()
        {
            List<BonLivraisonLigne> result = new List<BonLivraisonLigne>();
            try
            {
                Logger.Log.Info("Start - recording a new RequeteBR");
                connexion.Open();

                var RequeteLigneBR = "SELECT [PLAID] " +
                  ",[PCAID] " +
                  ",[PLADESIGNATION] " +
                 " ,[PLANUMLOT] " + ",[PLAFEFOPEREMPTION] " +
                  ",[PLAPROCODE] " +
                  ",[PLAQTE] " +
                  "FROM [almed].[dbo].[PIECEACHATLIGNES]";

                SqlCommand cd = new SqlCommand(RequeteLigneBR, connexion);
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
                Logger.Log.Info("End - geting RequeteBR");
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
