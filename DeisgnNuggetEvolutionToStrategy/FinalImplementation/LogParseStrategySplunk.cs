using DeisgnNuggetEvolutionToStrategy.Models;
using System;

namespace DeisgnNuggetEvolutionToStrategy.FinalImplementation
{
    internal static class LogParseStrategySplunk
    {
        public static SplunkExceptionLogInfo Parse(string logContent)
        {
            EnsureLogFormatIsValid(logContent);
            throw new NotImplementedException();
        }

        private static void EnsureLogFormatIsValid(string logContent)
        {
            if (!IsLogFormatValid(logContent))
            {
                throw new NcsaLogFormatInvalidException("The log content is not valid ormat for Splunk (for Exceptions) Log file");
            }
        }

        public static bool IsLogFormatValid(string logContent)
        {
            throw new NotImplementedException();
        }
    }
}
