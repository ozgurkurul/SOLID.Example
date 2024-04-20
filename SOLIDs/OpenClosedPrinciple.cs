namespace SOLIDs.OpenClosedPrinciple.Unsuitable
{
    /// <summary>
    /// Open/Closed Principle'ye uymuyor
    /// </summary>
    public enum LogType
    {
        Xml,
        Db
    }
    public class XmlLog
    {
        public bool Log(string message)
        {
            return true;
        }
    }
    public class DbLog
    {
        public bool Log(string message)
        {
            return true;
        }
    }
    public class Logger
    {
        private readonly XmlLog _xmlLog;
        private readonly DbLog _dbLog;
        public Logger(XmlLog xmlLog, DbLog dbLog)
        {
            _xmlLog = xmlLog;
            _dbLog = dbLog;
        }
        public void Log(LogType logType, string message)
        {
            switch (logType)
            {
                case LogType.Xml:
                    _xmlLog.Log(message);
                    break;
                case LogType.Db:
                    _dbLog.Log(message);
                    break;
            }
        }
    }
}

namespace SOLIDs.OpenClosedPrinciple.Suitable
{
    /// <summary>
    /// Open/Closed Principle'ye uyuyor
    /// </summary>
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
    public class DbLog : ILogger
    {
        public bool Log(string message)
        {
            return true;
        }
    }
    public class JsonLog : ILogger
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
