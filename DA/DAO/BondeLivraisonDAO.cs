﻿using System;
using DC;
using System.Collections.Generic;
using AlmedFramework;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DA
{
    public class BondeLivraisonDAO : DAO<BonLivraison>
    {
        public  List<BonLivraison> GetBonDeLivraison()
        {
            List<BonLivraison> result = new List<BonLivraison>();
            try
            {
                Logger.Log.Info("Start - recording a new RequeteBL");
                connexion.Open();

                var RequeteBL = "SELECT a.[PCVID] as PCVID " +
                                ",a.[PCVNUM] as PCVNUM " +
                                ",a.[DATEUPDATE] as DATEUPDATE " +
                                ",b.TIRSOCIETE as TIRSOCIETE " +
                                  "FROM [ALMEd].[dbo].[PIECEVENTES] a " +
                                  "inner join [ALMEd].[dbo].[TIERS] b on a.TIRID = b.TIRID " +
                                  "inner join [ALMED].[dbo].[PIECEVENTES_P] c on a.PCVID= c.PCVID " +
                                  "where (a.PINID=42 or a.PINID=66) and c.livre= 'N' " +
                                  "order by DATEUPDATE ";

                SqlCommand cd = new SqlCommand(RequeteBL, connexion);
                using (var dr = cd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(
                            new BonLivraison()
                            {
                                id = dr["PCVID"] != DBNull.Value ? dr["PCVID"].ToString() : string.Empty,
                                NBL = dr["PCVNUM"] != DBNull.Value ? dr["PCVNUM"].ToString() : string.Empty,
                                Date = dr["DATEUPDATE"] != DBNull.Value ? dr["DATEUPDATE"].ToString() : string.Empty,
                                NomClient = dr["TIRSOCIETE"] != DBNull.Value ? dr["TIRSOCIETE"].ToString() : string.Empty
                            });
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
        public  List<BonLivraison> GetBonDeLivraisonById(string id)
        {
            List<BonLivraison> result = new List<BonLivraison>();
            try
            {
                Logger.Log.Info("Start - recording a new RequeteBL");
                connexion.Open();

                var RequeteBL = "SELECT a.[PCVID] as PCVID " +
                                ",a.[PCVNUM] as PCVNUM " +
                                ",a.[DATEUPDATE] as DATEUPDATE " +
                                ",b.TIRSOCIETE as TIRSOCIETE " +
                                  "FROM [ALMEd].[dbo].[PIECEVENTES] a " +
                                  "inner join [ALMEd].[dbo].[TIERS] b on a.TIRID = b.TIRID " +
                                  "inner join [ALMED].[dbo].[PIECEVENTES_P] c on a.PCVID= c.PCVID " +
                                  "where (a.PINID=42 or a.PINID=66) and c.livre= 'N' " +
                                  "and a.PCVID = " + id +
                                  " order by DATEUPDATE ";

                SqlCommand cd = new SqlCommand(RequeteBL, connexion);
                using (var dr = cd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(
                            new BonLivraison()
                            {
                                id = dr["PCVID"] != DBNull.Value ? dr["PCVID"].ToString() : string.Empty,
                                NBL = dr["PCVNUM"] != DBNull.Value ? dr["PCVNUM"].ToString() : string.Empty,
                                Date = dr["DATEUPDATE"] != DBNull.Value ? dr["DATEUPDATE"].ToString() : string.Empty,
                                NomClient = dr["TIRSOCIETE"] != DBNull.Value ? dr["TIRSOCIETE"].ToString() : string.Empty
                            });
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
        public List<BonLivraison> getBonReception()
        {
            List<BonLivraison> result = new List<BonLivraison>();
            try
            {
                Logger.Log.Info("Start - recording a new RequeteBR");
                connexion.Open();

                var RequeteBR = "SELECT a.[PCAID] " +
                    ",a.[PCANUM] " +
                    ",a.[DATEUPDATE] " +
                    ",b.[TIRSOCIETE] " +
                    "FROM [almed].[dbo].[PIECEACHATS] a " +
                    "inner join [almed].[dbo].[TIERS] b on a.tirid=b.tirid " +
                    "inner join [almed].[dbo].[PIECEACHATS_P] c on a.PCAID=c.PCAID " +
                    "where pinid=84 and c.recu='N'";

                SqlCommand cd = new SqlCommand(RequeteBR, connexion);
                using (var dr = cd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(
                            new BonLivraison()
                            {
                                id = dr["PCAID"] != DBNull.Value ? dr["PCAID"].ToString() : string.Empty,
                                NBL = dr["PCANUM"] != DBNull.Value ? dr["PCANUM"].ToString() : string.Empty,
                                Date = dr["DATEUPDATE"] != DBNull.Value ? dr["DATEUPDATE"].ToString() : string.Empty,
                                NomClient = dr["TIRSOCIETE"] != DBNull.Value ? dr["TIRSOCIETE"].ToString() : string.Empty
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
        public List<BonLivraison> getBonReceptionById(string id)
        {
            List<BonLivraison> result = new List<BonLivraison>();
            try
            {
                Logger.Log.Info("Start - recording a new RequeteBR");
                connexion.Open();

                var RequeteBR = "SELECT a.[PCAID] " +
                    ",a.[PCANUM] " +
                    ",a.[DATEUPDATE] " +
                    ",b.[TIRSOCIETE] " +
                    "FROM [almed].[dbo].[PIECEACHATS] a " +
                    "inner join [almed].[dbo].[TIERS] b on a.tirid=b.tirid " +
                    "inner join [almed].[dbo].[PIECEACHATS_P] c on a.PCAID=c.PCAID " +
                    "WHERE pinid=84 and c.recu='N' and a.PCAID = " + id ;


                SqlCommand cd = new SqlCommand(RequeteBR, connexion);
                using (var dr = cd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add(
                            new BonLivraison()
                            {
                                id = dr["PCAID"] != DBNull.Value ? dr["PCAID"].ToString() : string.Empty,
                                NBL = dr["PCANUM"] != DBNull.Value ? dr["PCANUM"].ToString() : string.Empty,
                                Date = dr["DATEUPDATE"] != DBNull.Value ? dr["DATEUPDATE"].ToString() : string.Empty,
                                NomClient = dr["TIRSOCIETE"] != DBNull.Value ? dr["TIRSOCIETE"].ToString() : string.Empty
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
