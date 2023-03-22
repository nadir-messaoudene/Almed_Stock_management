using AlmedFramework.DO;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AlmedFramework
{
    public static class Util
    {
        private const string DLC = "01/01/1900";

        public static string GetSyplayName(string stringIn)
        {
            if (stringIn.ToLower().Contains("abbott") || stringIn.ToLower().Contains("add"))
                return "Abbott";
            else if (stringIn.ToLower().Contains("sebia"))
                return "Sebia";
            else if (stringIn.ToLower().Contains("oxoid") || stringIn.ToLower().Contains("oxo"))
                return "Oxoid";
            else
                return "Autre";
        }

        public static Items GetLNLotInCodeByGamme(string gamme, string codeIn)
        {
            try
            {
                switch (gamme)
                {
                    //Abbott
                    case "Abbott":
                        if (codeIn.Length < 40)
                            return new AbbottHelper().GetCode(codeIn, DLC, "");
                        else
                            return new AbbottHelper().GetCode(codeIn, "");
                    //Sebia
                    case "Sebia":
                        if (codeIn.Length < 33)
                            return new SebiaHelper().GetCode(codeIn, DLC, "");
                        else
                            return new SebiaHelper().GetCode(codeIn, "");
                    //Oxoid
                    case "Oxoid":
                        return new OxoidHelper().GetCode(codeIn, "");
                    //Autre
                    case "Autre":
                        return new Items()
                        {
                            LN = codeIn,
                        };
                    default:
                        return null;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<string> SeparateCode(string text)
        {
            List<string> result = new List<string>();

            char[] separator = new char[] { '$' };
            foreach (var item in text.Split(separator))
            {
                result.Add(item);
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string remouveSparators(string text)
        {
            string result = string.Empty;
            char[] separator = new char[] { ' ', '.', '\\', '/', '-', '_' };
            foreach (var item in text.Split(separator))
            {
                result += item;
            }
            return result;
        }

         public static bool IsDateEqual(string datePeremption, string dLC)
        {
            IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
            DateTime dt = Convert.ToDateTime(datePeremption);
            DateTime dt2 = DateTime.Parse(dLC, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            if (dt.Year == dt2.Year && dt.Day == dt2.Day && dt.Month == dt2.Month)
                return true;
            else
                return false;
        }
    }
}