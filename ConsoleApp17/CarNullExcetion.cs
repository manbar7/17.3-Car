using System;
using System.Runtime.Serialization;

namespace ConsoleApp17
{
    [Serializable]
    internal class CarNullExcetion : Exception
    {
        public CarNullExcetion()
        {
        }

        public CarNullExcetion(string message) : base(message)
        {
        }

        public CarNullExcetion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CarNullExcetion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}