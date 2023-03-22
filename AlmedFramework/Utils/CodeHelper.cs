using System;

namespace AlmedFramework
{
    public static class CodeHelper
    {
        public static string GetDLC(string stringIn)
        {
            try
            {
                return Util.SeparateCode(stringIn)[2];
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public static string GetLN(string stringIn)
        {
            try
            {
                return Util.SeparateCode(stringIn)[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static string GetNLot(string stringIn)
        {
            try
            {
                return Util.SeparateCode(stringIn)[1];
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
