using DeisgnNuggetEvolutionToStrategy.Models;
using System;

namespace DeisgnNuggetEvolutionToStrategy.FinalImplementation
{
    internal static class LogParseStrategyNcsa
    {
        public static NcsaLogInfo Parse(string logContent)
        {
            EnsureLogFormatIsValid(logContent);
            throw new NotImplementedException();
        }

        private static void EnsureLogFormatIsValid(string logContent)
        {
            if (!IsLogFormatValid(logContent))
            {
                throw new NcsaLogFormatInvalidException("The log content is not valid format for an NCSA Standard Log file");
            }
        }

        public static bool IsLogFormatValid(string logContent)
        {
            throw new NotImplementedException();
        }
    }
}
