using DeisgnNuggetEvolutionToStrategy.Models;

namespace DeisgnNuggetEvolutionToStrategy.FinalImplementation
{
    internal static class LogParserContext
    {
        public static LogInfoBase Parse(string logContent)
        {
            var logSource = DetermineLogSource(logContent);

            switch (logSource)
            {
                case LogSource.MsSql:
                    return LogParseStrategyMsSql.Parse(logContent);
                case LogSource.Ncsa:
                    return LogParseStrategyNcsa.Parse(logContent);
                case LogSource.Splunk:
                    return LogParseStrategySplunk.Parse(logContent);
                default:
                    throw new LogSourceNotSupportedException("The Log Content provided is not an expected Log Source format");
            }
        }

        private static LogSource DetermineLogSource(string logContent)
        {
            if (LogParseStrategyMsSql.IsLogFormatValid(logContent))
            {
                return LogSource.MsSql;
            }
            else if (LogParseStrategyNcsa.IsLogFormatValid(logContent))
            {
                return LogSource.Ncsa;
            }
            else if (LogParseStrategySplunk.IsLogFormatValid(logContent))
            {
                return LogSource.Splunk;
            }

            throw new LogSourceNotSupportedException("The Log Content provided is not an expected Log Source format");
        }
    }
}
