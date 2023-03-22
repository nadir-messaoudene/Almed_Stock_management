using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmedFramework
{
    partial class AbbottHelper
    {
        private string GetDLC44(string stringIn)
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

        private string GetLN44(string stringIn)
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

        private string GetNLot44(string stringIn)
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
