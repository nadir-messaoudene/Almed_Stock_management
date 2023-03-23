using DC;
using System;
using System.Collections.Generic;

namespace AlmedFramework.Utils
{
    public static partial class QRCodeHelper
    {
        public static Items GetItemsBySuplayName(string suplayName, string codeIn)
        {
            try
            {
                Items result = new Items();
                switch (suplayName)
                {
                    //Abbott
                    case "Abbott":
                        result = GetAbbottItemsByCodeIn(codeIn);
                        result.Gamme = suplayName;
                        return result;
                    //Sebia
                    case "Sebia":
                        result = GetSebiaItemsByCodeIn(codeIn);
                        result.Gamme = suplayName;
                        return result;
                    //Oxoid
                    case "Oxoid":
                        result = GetOxoidItemsByCodeIn(codeIn);
                        result.Gamme = suplayName;
                        return result;
                    //Autre
                    case "Autre":
                    default:
                        return null;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Items GetItemsByAlmedCode(string codeIn)
        {
            try
            {
                List<string> item = Util.SeparateCodeByDolare(codeIn);
                return new Items()
                {
                    LN = item[0],
                    NLot = item[1],
                    DLC = item[2]
                };
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
