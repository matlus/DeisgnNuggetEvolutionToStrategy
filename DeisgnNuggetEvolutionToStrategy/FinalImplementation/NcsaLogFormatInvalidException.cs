using System;
using System.Collections.Generic;
using System.Text;

namespace DeisgnNuggetEvolutionToStrategy.FinalImplementation
{

    [Serializable]
    public sealed class NcsaLogFormatInvalidException : Exception
    {
        public NcsaLogFormatInvalidException() { }
        public NcsaLogFormatInvalidException(string message) : base(message) { }
        public NcsaLogFormatInvalidException(string message, Exception inner) : base(message, inner) { }
        private NcsaLogFormatInvalidException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
