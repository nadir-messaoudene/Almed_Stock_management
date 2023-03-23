using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public static List<string> SeparateCodeByDolare(string text)
        {
            List<string> result = new List<string>();

            char[] separator = new char[] { '$' };
            foreach (var item in text.Split(separator))
            {
                result.Add(item);
            }
            return result;
        }
        public static List<string> SeparateCodeByTiet(string text)
        {
            List<string> result = new List<string>();

            char[] separator = new char[] { '-' };
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
        public static string RemouveSparators(string text)
        {
            string result = string.Empty;
            char[] separator = new char[] { ' ', '.', '\\', '/', '-', '_' };
            foreach (var item in text.Split(separator))
                result += item;
            return result;
        }

         public static bool IsDateEqual(string datePeremption, string dLC)
        {
            if (datePeremption == "" && dLC == "")
                return true;
            if (datePeremption == "" || dLC == "")
                return false;

            IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
            DateTime dt = Convert.ToDateTime(datePeremption);
            DateTime dt2 = DateTime.Parse(dLC, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            if ((dt.Year == dt2.Year && dt.Day == dt2.Day && dt.Month == dt2.Month))
                return true;
            else
                return false;
        }
        public static void LunchProcess(string batDir, string fileName)
        {
            Process proc = null;
            try
            {
                proc = new Process();
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = fileName;
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }
    }
}