using System;
using System.Runtime.Serialization;

namespace ExactOnline.Client.Sdk.Exceptions
{
    [DataContract]
    public class BadRequestException : Exception // HTTP: 400
    {
        public BadRequestException() { }
        public BadRequestException(string message) : base(message) { }
        public BadRequestException(string message, Exception inner) : base(message, inner) { }
    }
}