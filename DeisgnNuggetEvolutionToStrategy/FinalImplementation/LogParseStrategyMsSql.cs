using DeisgnNuggetEvolutionToStrategy.Models;
using System;

namespace DeisgnNuggetEvolutionToStrategy.FinalImplementation
{
    internal static class LogParseStrategyMsSql
    {
        public static MsSqlLogInfo Parse(string logContent)
        {
            EnsureLogFormatIsValid(logContent);
            throw new NotImplementedException();
        }

        private static void EnsureLogFormatIsValid(string logContent)
        {
            if (!IsLogFormatValid(logContent))
            {
                throw new MsSqlLogFormatInvalidException("The log content is not valid format for an MS SQL Log file");
            }            
        }

        public static bool IsLogFormatValid(string logContent)
        {
            throw new NotImplementedException();
        }
    }
}
