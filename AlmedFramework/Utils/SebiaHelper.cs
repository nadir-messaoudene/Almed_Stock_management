using AlmedFramework.DO;
using System;

namespace AlmedFramework
{
    public class SebiaHelper : AbstractHelper
    {
        public Items GetCode(string codeIn, string DLC, string qte)
        {
            try
            {
                return new Items("Sebia", DLC, GetLN25(codeIn), GetNLot(codeIn), qte);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public override Items GetCode(string codeIn, string qte)
        {
            try
            {
                return new Items("Sebia", GetDLC(codeIn), GetLN(codeIn), GetNLot(codeIn), qte);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string GetNLot25(string stringIn)
        {
            try
            {
                return stringIn.Substring(18, 7);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        private string GetLN25(string stringIn)
        {
            try
            {
                return stringIn.Substring(11, 4);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public override string GetDLC(string stringIn)
        {
            try
            {

                return stringIn.Substring(31, 2) + "/" + stringIn.Substring(29, 2) + "/20" + stringIn.Substring(27, 2);

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
                return stringIn.Substring(11, 4);
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
                return stringIn.Substring(18, 7);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
