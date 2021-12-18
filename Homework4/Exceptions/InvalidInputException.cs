using System;
using System.Runtime.Serialization;

namespace Homework4.Methods
{
    [Serializable]
    internal class InvalidInputException : Exception
    {
        public InvalidInputException()
        {
        }

        public InvalidInputException(string message) : base(message)
        {
        }

        public InvalidInputException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidInputException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public void ShowMessage()
        {
            Console.Clear();
            Console.WriteLine(Message);
            Console.ReadKey();
        }
    }
}