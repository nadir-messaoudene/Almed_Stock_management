using DC;

namespace AlmedFramework.Utils
{
    public static partial class QRCodeHelper
    {
        public static Items GetAbbottItemsByCodeIn(string codeIn)
        {
            switch (codeIn.Length)
            {
                case 42:
                    return new Items()
                    {
                        LN = codeIn.Substring(35, 7),
                        NLot = codeIn.Substring(18, 6),
                        DLC = codeIn.Substring(30, 2) + "/" + codeIn.Substring(28, 2) + "/20" + codeIn.Substring(26, 2)
                    };
                case 44:
                    return new Items()
                    {
                        LN = codeIn.Substring(38, 6),
                        NLot = codeIn.Substring(26, 9),
                        DLC = codeIn.Substring(22, 2) + "/" + codeIn.Substring(20, 2) + "/20" + codeIn.Substring(18, 2)
                    };
                case 45:
                    if (Util.SeparateCodeByTiet(codeIn)[0].Length == 42)
                        return new Items()
                        {
                            LN = codeIn.Substring(38, 7),
                            NLot = codeIn.Substring(18, 8),
                            DLC = codeIn.Substring(32, 2) + "/" + codeIn.Substring(30, 2) + "/20" + codeIn.Substring(28, 2)
                        };
                    else if (Util.SeparateCodeByTiet(codeIn)[0].Length < 42)
                        return new Items()
                        {
                            LN = codeIn.Substring(20, 7),
                            NLot = codeIn.Substring(37, 8),
                            DLC = codeIn.Substring(33, 2) + "/" + codeIn.Substring(31, 2) + "/20" + codeIn.Substring(29, 2)
                        };
                    else if (Util.SeparateCodeByTiet(codeIn)[0].Length == 45)
                        return new Items()
                        {
                            LN = codeIn.Substring(39, 6),
                            NLot = codeIn.Substring(26, 9),
                            DLC = codeIn.Substring(22, 2) + "/" + codeIn.Substring(20, 2) + "/20" + codeIn.Substring(18, 2)
                        };
                    else return null;
                case 43:
                    return new Items()
                    {
                        LN = codeIn.Substring(37, 6),
                        NLot = codeIn.Substring(26, 8),
                        DLC = codeIn.Substring(22, 2) + "/" + codeIn.Substring(20, 2) + "/20" + codeIn.Substring(18, 2)
                    };
                case 41:
                    return new Items()
                    {
                        LN = codeIn.Substring(35, 6),
                        NLot = codeIn.Substring(26, 6),
                        DLC = codeIn.Substring(22, 2) + "/" + codeIn.Substring(20, 2) + "/20" + codeIn.Substring(18, 2)
                    };
                case 40:
                    return new Items()
                    {
                        LN = codeIn.Substring(34, 6),
                        NLot = codeIn.Substring(26, 5),
                        DLC = codeIn.Substring(22, 2) + "/" + codeIn.Substring(20, 2) + "/20" + codeIn.Substring(18, 2)
                    };
                case 46:
                    return new Items()
                    {
                        LN = Util.RemouveSparators(codeIn.Substring(39, 7)),
                        NLot = codeIn.Substring(26, 9),
                        DLC = codeIn.Substring(22, 2) + "/" + codeIn.Substring(20, 2) + "/20" + codeIn.Substring(18, 2)
                    };

                default:
                    return null;
            }
        }
    }
}
