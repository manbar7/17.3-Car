using System;
using System.Runtime.Serialization;

namespace ConsoleApp17
{
    [Serializable]
    internal class RepairMismatchEception : Exception
    {
        public RepairMismatchEception()
        {
        }

        public RepairMismatchEception(string message) : base(message)
        {
        }

        public RepairMismatchEception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepairMismatchEception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}