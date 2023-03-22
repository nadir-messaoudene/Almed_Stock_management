using AlmedFramework.DO;
using System;

namespace AlmedFramework
{
    public class OxoidHelper : AbstractHelper
    {
        public override Items GetCode(string codeIn, string qte)
        {
            try
            {
                return new Items("Oxoid", GetDLC(codeIn), GetLN(codeIn), GetNLot(codeIn), qte);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override string GetDLC(string stringIn)
        {
            try
            {
                return stringIn.Substring(20, 2) + "/" + stringIn.Substring(20, 2) + "/20" + stringIn.Substring(18, 2);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public override string GetLN(string stringIn)
        {
            try
            {
                return "";
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public override string GetNLot(string stringIn)
        {
            try
            {
                return stringIn.Substring(stringIn.Length - 7, 7);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
