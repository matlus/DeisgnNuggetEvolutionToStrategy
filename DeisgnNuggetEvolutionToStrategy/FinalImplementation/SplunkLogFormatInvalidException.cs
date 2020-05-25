using System;
using System.Collections.Generic;
using System.Text;

namespace DeisgnNuggetEvolutionToStrategy.FinalImplementation
{

    [Serializable]
    public sealed class SplunkLogFormatInvalidException : Exception
    {
        public SplunkLogFormatInvalidException() { }
        public SplunkLogFormatInvalidException(string message) : base(message) { }
        public SplunkLogFormatInvalidException(string message, Exception inner) : base(message, inner) { }
        private SplunkLogFormatInvalidException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
