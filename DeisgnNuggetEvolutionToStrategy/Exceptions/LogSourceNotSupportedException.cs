using System;
using System.Collections.Generic;
using System.Text;

namespace DeisgnNuggetEvolutionToStrategy
{
    [Serializable]
    public sealed class LogSourceNotSupportedException : Exception
    {
        public LogSourceNotSupportedException() { }
        public LogSourceNotSupportedException(string message) : base(message) { }
        public LogSourceNotSupportedException(string message, Exception inner) : base(message, inner) { }
        private LogSourceNotSupportedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
