using log4net;

namespace AlmedFramework
{
    public static class Logger
    {
        //Here is the once-per-class call to initialize the log object
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static ILog Log
        {
            get
            {
                return log;
            }
        }
    }
}
