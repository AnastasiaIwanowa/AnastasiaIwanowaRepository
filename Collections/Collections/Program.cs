using NLog;

namespace Collections
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Trace("trace message");
            logger.Debug("debug message");
            logger.Info("info message");
            logger.Warn("warn message");
            logger.Error("error message");
            logger.Fatal("fatal message");

            ActionsCollections actions = new ActionsCollections();
            actions.Execute();
        }
    }
}
