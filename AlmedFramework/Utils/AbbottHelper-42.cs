namespace AlmedFramework
{
    partial class AbbottHelper
    {
        private string GetDLC42(string stringIn)
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

        public string GetLN42(string stringIn)
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

        private string GetNLot42(string stringIn)
        {
            try
            {
                return stringIn.Substring(26, 6);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

    }
}
