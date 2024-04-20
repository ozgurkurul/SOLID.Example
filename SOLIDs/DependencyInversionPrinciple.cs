namespace SOLIDs.DependencyInversionPrinciple.Unsuitable
{
    public class XmlLog
    {
        public bool Log(string message)
        {
            return true;
        }
    }

    public class Logger
    {
        private readonly XmlLog _xmlLog = new XmlLog();
        public void Log(string message)
        {
            _xmlLog.Log(message);
        }
    }
}

namespace SOLIDs.DependencyInversionPrinciple.Suitable
{
    public interface ILogger
    {
        bool Log(string message);
    }

    public class XmlLog : ILogger
    {
        public bool Log(string message)
        {
            return true;
        }
    }
    public class Logger
    {
        private readonly ILogger _logger;
        public Logger(ILogger logger)
        {
            _logger = logger;
        }
        public void Log(string message)
        {
            _logger.Log(message);
        }
    }
}