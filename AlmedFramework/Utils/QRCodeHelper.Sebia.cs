using DC;

namespace AlmedFramework.Utils
{
    public static partial class QRCodeHelper
    {
        private static Items GetSebiaItemsByCodeIn(string codeIn)
        {
            switch (codeIn.Length)
            {
                case 33:
                    return new Items()
                    {
                        LN = codeIn.Substring(11, 4),
                        NLot = codeIn.Substring(18, 7),
                        DLC = codeIn.Substring(31, 2) + "/" + codeIn.Substring(29, 2) + "/20" + codeIn.Substring(27, 2)
                    };
                default:
                    return null;
            }
        }
    }
}
