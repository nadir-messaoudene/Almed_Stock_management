using log4net;

namespace AlmedFramework
{
    public static class Logger
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static ILog Log
        {
            get
            {
                return log;
            }
        }
    }
}
