using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmedFramework
{
    partial class AbbottHelper
    {
        private string GetDLC45(string stringIn)
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

        public string GetLN45(string stringIn)
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

        private string GetNLot45(string stringIn)
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



        private string GetDLC45_44(string stringIn)
        {
            try
            {
                return stringIn.Substring(32, 2) + "/" + stringIn.Substring(30, 2) + "/20" + stringIn.Substring(28, 2);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        private string GetLN45_44(string stringIn)
        {
            try
            {
                return stringIn.Substring(stringIn.Length - 8, 8);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        private string GetNLot45_44(string stringIn)
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
    }
}
