using DC;

namespace AlmedFramework.Utils
{
    public static partial class QRCodeHelper
    {
        private static DataServices.Service dataServices = new DataServices.Service();
        public static Items GetOxoidItemsByCodeIn(string codeIn)
        {
            string codeLN = codeIn.Substring(0, 16);
            string codeDLC = (codeIn.Substring(22, 2) == "00" ? "31" : codeIn.Substring(22, 2)) + "/" + codeIn.Substring(20, 2) + "/20" + codeIn.Substring(18, 2);
            switch (codeIn.Length)
            {
                case 33:
                    return new Items()
                    {
                        LN = dataServices.GetLNOxoidByCode(codeLN),
                        NLot = codeIn.Substring(26, 7),
                        DLC = codeDLC
                    };
                case 32:
                    return new Items()
                    {
                        LN = dataServices.GetLNOxoidByCode(codeLN),
                        NLot = codeIn.Substring(26, 6),
                        DLC = codeDLC
                    };
                case 31:
                    return new Items()
                    {
                        LN = dataServices.GetLNOxoidByCode(codeLN),
                        NLot = codeIn.Substring(26, 5),
                        DLC = codeDLC
                    };
                case 11:
                    return new Items()
                    {
                        LN = "None",
                        NLot = codeIn.Substring(0, 5),
                        DLC = (codeIn.Substring(5, 2) == "00" ? "31" : codeIn.Substring(5, 2)) + "/" + codeIn.Substring(7, 2) + "/20" + codeIn.Substring(9, 2)
                    };
                default:
                    return null;
            }

        }
    }
}
