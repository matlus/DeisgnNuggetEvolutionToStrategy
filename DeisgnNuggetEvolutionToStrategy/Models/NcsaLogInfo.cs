using System;

namespace DeisgnNuggetEvolutionToStrategy.Models
{
    internal sealed class NcsaLogInfo : LogInfoBase
    {
        public DateTime DateTime { get; }
        public string IPAddress { get; }
        public DateTime TimeTaken { get; }
        public string HttpMethod { get; }
        public string UriStem { get; }
        public int StatusCode { get; }

        public NcsaLogInfo(DateTime dateTime, string ipAddress, DateTime timeTaken, string httpMethod, string uriStem, int statusCode)
        {
            DateTime = dateTime;
            IPAddress = ipAddress;
            TimeTaken = timeTaken;
            HttpMethod = httpMethod;
            UriStem = uriStem;
            StatusCode = statusCode;
        }
    }
}
