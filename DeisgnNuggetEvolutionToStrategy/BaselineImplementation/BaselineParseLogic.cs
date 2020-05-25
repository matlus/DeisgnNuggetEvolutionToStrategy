using DeisgnNuggetEvolutionToStrategy.Models;
using System;

namespace DeisgnNuggetEvolutionToStrategy
{
    internal sealed class BaselineParseLogic
    {
        public void Parse(string logContent)
        {
            var logSource = DetermineLogSource(logContent);

            switch (logSource)
            {
                case LogSource.MsSql:
                    var msSqlLogInfo = ParseMsSqlLogs(logContent);
                    PersistMsSqlLogModel(msSqlLogInfo);
                    break;
                case LogSource.Ncsa:
                    var ncsaLogInfo = ParseNcsalLogs(logContent);
                    PersistNcsaLogModel(ncsaLogInfo);
                    break;
                case LogSource.Splunk:
                    var splunkExceptionLogInfo = ParseSplunkLogs(logContent);
                    PersistSplunkExceptionLogModel(splunkExceptionLogInfo);
                    break;
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

        private static void PersistMsSqlLogModel(MsSqlLogInfo msSqlLogInfo)
        {
            throw new NotImplementedException();
        }

        private static void PersistNcsaLogModel(NcsaLogInfo ncsaLogInfo)
        {
            throw new NotImplementedException();
        }

        private static void PersistSplunkExceptionLogModel(SplunkExceptionLogInfo splunkExceptionLogInfo)
        {
            throw new NotImplementedException();
        }
    }
}
