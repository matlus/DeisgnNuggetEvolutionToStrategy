using DeisgnNuggetEvolutionToStrategy.Models;
using System;

namespace DeisgnNuggetEvolutionToStrategy.IntermideateImplementation
{
    internal sealed class IntermideateParseLogic
    {
        public LogInfoBase Parse(string logContent)
        {
            var logSource = DetermineLogSource(logContent);
            switch (logSource)
            {
                case LogSource.MsSql:
                    return ParseMsSqlLogs(logContent);                    
                case LogSource.Ncsa:
                    return ParseNcsalLogs(logContent);                    
                case LogSource.Splunk:
                    return ParseSplunkLogs(logContent);
                default:
                    throw new LogSourceNotSupportedException("The Log Content provided is not an expected Log Source format");
            }
        }

        private static LogSource DetermineLogSource(string logContent)
        {
            throw new NotImplementedException();
        }

        private static MsSqlLogInfo ParseMsSqlLogs(string logContent)
        {
            throw new NotImplementedException();
        }

        private static NcsaLogInfo ParseNcsalLogs(string logContent)
        {
            throw new NotImplementedException();
        }

        private static SplunkExceptionLogInfo ParseSplunkLogs(string logContent)
        {
            throw new NotImplementedException();
        }
    }
}
