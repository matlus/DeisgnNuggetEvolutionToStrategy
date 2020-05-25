using System;

namespace DeisgnNuggetEvolutionToStrategy.Models
{
    internal sealed class SplunkExceptionLogInfo : LogInfoBase
    {
        public DateTime DateTime { get; }
        public string ClassName { get; }
        public string Message { get; }
        public string Stacktrace { get; }
        public string ReasonPhrase { get; set; }

        public SplunkExceptionLogInfo(DateTime dateTime, string className, string message, string stacktrace, string reasonPhrase)
        {
            DateTime = dateTime;
            ClassName = className;
            Message = message;
            Stacktrace = stacktrace;
            ReasonPhrase = reasonPhrase;
        }
    }
}
