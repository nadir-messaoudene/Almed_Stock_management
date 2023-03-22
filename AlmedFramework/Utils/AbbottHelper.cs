using AlmedFramework.DO;
using System;

namespace AlmedFramework
{
    public partial class AbbottHelper : AbstractHelper
    {

        public Items GetCode(string codeIn, string DLC, string qte)
        {
            try
            {
                switch (codeIn.Length)
                {
                    case 38:
                        codeIn = Util.remouveSparators(codeIn);
                        return new Items("Abbot", DLC, GetLN(codeIn), GetNLot38(codeIn), qte);
                    case 34:
                        codeIn = Util.remouveSparators(codeIn);
                        return new Items("Abbot", DLC, GetLN(codeIn), GetNLot34(codeIn), qte);
                    default:
                        return null;
                }

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
                switch (codeIn.Length)
                {
                    case 45:
                        codeIn = Util.remouveSparators(codeIn);
                        if(codeIn.Length == 44)
                            return new Items("Abbot", GetDLC45_44(codeIn), GetLN45_44(codeIn), GetNLot45_44(codeIn), qte);
                        else
                            return new Items("Abbot", GetDLC45(codeIn), GetLN45(codeIn), GetNLot45(codeIn), qte);
                    case 43:
                        codeIn = Util.remouveSparators(codeIn);
                        return new Items("Abbot", GetDLC42(codeIn), GetLN42(codeIn), GetNLot42(codeIn), qte);
                    case 44:
                        codeIn = Util.remouveSparators(codeIn);
                        return new Items("Abbot", GetDLC44(codeIn), GetLN44(codeIn), GetNLot44(codeIn), qte);
                    case 40:
                        codeIn = Util.remouveSparators(codeIn);
                        return new Items("Abbot", GetDLC42(codeIn), GetLN(codeIn), GetNLot40(codeIn), qte);
                    default:
                        return null;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }



        private string GetNLot38(string stringIn)
        {
            try
            {
                return stringIn.Substring(18, 9);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        private string GetNLot34(string stringIn)
        {
            try
            {
                return stringIn.Substring(16, 9);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        private string GetNLot40(string stringIn)
        {
            try
            {
                return stringIn.Substring(26, 5);
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
                return stringIn.Substring(stringIn.Length - 6, 6);
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
                return stringIn.Substring(22, 2) + "/" + stringIn.Substring(20, 2) + "/20" + stringIn.Substring(18, 2);
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
                return stringIn.Substring(26, 9);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
