using System;

namespace DeisgnNuggetEvolutionToStrategy.Models
{
    internal sealed class MsSqlLogInfo : LogInfoBase
    {
        public DateTime DateTime { get; }
        public string StoredProcedure { get; }
        public DateTime TimeTaken { get; }
        public int ActiveConnections { get; }

        public MsSqlLogInfo(DateTime dateTime, string storedProcedure, DateTime timeTaken, int activeConnections)
        {
            DateTime = dateTime;
            StoredProcedure = storedProcedure;
            TimeTaken = timeTaken;
            ActiveConnections = activeConnections;
        }
    }
}
