using DC;
using System;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DA
{
    public class ItemDAO : DAO<Items>
    {
        public Items RecordItem(Items item)
        {
            try
            {
                accessConnexion = ConnectionToAccess.GetInstance();
                accessConnexion.Open();

                string RequeteGetId = " SELECT Items.[Qte] FROM Items WHERE(((Items.[idReception]) = @idReception ) AND((Items.[idItem]) = @idItem ))";
                string RequeteRecordItem = "INSERT INTO Items (" +
                        "LN, NLot, DLC, SuplayName, BRN, Qte,DateCreated,Movement,idReception,idItem) " +
                        "VALUES(@LN,@NLot,@DLC,@SuplayName,@BRN,@Qte,@DateCreated,@Movement,@idReception,idItem)";


                OleDbCommand cmd1 = new OleDbCommand(RequeteGetId, accessConnexion);
                cmd1.Parameters.AddWithValue("idReception", item.IdReception);
                cmd1.Parameters.AddWithValue("idItem", item.IdItem);
                OleDbCommand cmd2;
                if (cmd1.ExecuteReader().HasRows)
                {
                    RequeteRecordItem = "UPDATE Items SET Qte = '" + item.Qte + "' WHERE(((Items.[idReception]) = @idReception) AND ((Items.[idItem]) =  @idItem))";
                    cmd2 = new OleDbCommand(RequeteRecordItem, accessConnexion);

                    cmd2.Parameters.AddWithValue("idReception", item.IdReception);
                    cmd2.Parameters.AddWithValue("idItem", item.IdItem);
                    cmd2.ExecuteNonQuery();
                    return item;
                }

                cmd2 = new OleDbCommand(RequeteRecordItem, accessConnexion);

                cmd2.Parameters.AddWithValue("LN", item.LN);
                cmd2.Parameters.AddWithValue("NLot", item.NLot);
                cmd2.Parameters.AddWithValue("DLC", item.DLC);
                cmd2.Parameters.AddWithValue("SuplayName", item.SuplayName);
                cmd2.Parameters.AddWithValue("BRN", item.BRN);
                cmd2.Parameters.AddWithValue("Qte", item.Qte);
                cmd2.Parameters.AddWithValue("DateCreated", item.DateCreated);
                cmd2.Parameters.AddWithValue("Movement", item.Movement);
                cmd2.Parameters.AddWithValue("idReception", item.IdReception);
                cmd2.Parameters.AddWithValue("idItem", item.IdItem);
                cmd2.ExecuteNonQuery();

                return item;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                accessConnexion.Close();
            }
        }

        public string GetQteByIdItemAndIdReception(string idItem, string idReception)
        {
            try
            {
                accessConnexion = ConnectionToAccess.GetInstance();
                accessConnexion.Open();

                string RequeteGetId = "SELECT Items.[Qte] FROM Items WHERE(((Items.[idReception]) = @idReception ) AND((Items.[idItem]) = @idItem ))";



                OleDbCommand cmd = new OleDbCommand(RequeteGetId, accessConnexion);
                cmd.Parameters.AddWithValue("idReception", idReception);
                cmd.Parameters.AddWithValue("idItem", idItem);

                string qte = "0";
                using (var dr = cmd.ExecuteReader())
                    while (dr.Read())
                        qte = dr["Qte"] != DBNull.Value ? dr["Qte"].ToString() : "0";

                return qte;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                accessConnexion.Close();
            }
        }

        public string GetLNOxoidByCode(string code)
        {
            try
            {
                accessConnexion = ConnectionToAccess.GetInstance();
                accessConnexion.Open();

                string RequeteGetLN = "SELECT Oxoid.[LNOXO] FROM Oxoid WHERE (((Oxoid.[IDCode]) = @code ))";

                OleDbCommand cmd = new OleDbCommand(RequeteGetLN, accessConnexion);
                cmd.Parameters.AddWithValue("IDCode", code);

                string LN = "";
                using (var dr = cmd.ExecuteReader())
                    if (dr.Read()) LN = dr["LNOXO"] != DBNull.Value ? dr["LNOXO"].ToString() : "";
                return LN;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                accessConnexion.Close();
            }
        }
    }
}