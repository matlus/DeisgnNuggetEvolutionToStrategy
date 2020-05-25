using System;
using System.Collections.Generic;
using System.Text;

namespace DeisgnNuggetEvolutionToStrategy.FinalImplementation
{

    [Serializable]
    public sealed class MsSqlLogFormatInvalidException : Exception
    {
        public MsSqlLogFormatInvalidException() { }
        public MsSqlLogFormatInvalidException(string message) : base(message) { }
        public MsSqlLogFormatInvalidException(string message, Exception inner) : base(message, inner) { }
        private MsSqlLogFormatInvalidException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
