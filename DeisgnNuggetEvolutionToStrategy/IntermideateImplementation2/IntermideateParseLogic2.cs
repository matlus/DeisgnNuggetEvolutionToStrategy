using DeisgnNuggetEvolutionToStrategy.Models;
using System;
using System.Collections.Generic;

namespace DeisgnNuggetEvolutionToStrategy
{
    internal sealed class IntermideateParseLogic2
    {
        private readonly Dictionary<LogSource, Func<string, LogInfoBase>> parsersDictionary = new Dictionary<LogSource, Func<string, LogInfoBase>>
        {
            {LogSource.MsSql, ParseMsSqlLogs },
            { LogSource.Ncsa, ParseNcsalLogs },
            { LogSource.Splunk, ParseSplunkLogs }
        };

        public LogInfoBase Parse(string logContent)
        {
            var logSource = DetermineLogSource(logContent);
            var parseMethod = parsersDictionary[logSource];
            return parseMethod(logContent);
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
