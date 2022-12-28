using System;
using System.Runtime.Serialization;

namespace SlimeMVVM.Exceptions
{
    public class RGInitialisationException : Exception
    {
        public RGInitialisationException()
        {
        }

        public RGInitialisationException(string message) : base(message)
        {
        }

        public RGInitialisationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RGInitialisationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
