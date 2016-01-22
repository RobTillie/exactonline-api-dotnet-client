using System;
using System.Runtime.Serialization;

namespace ExactOnline.Client.Sdk.Exceptions
{
    [DataContract]
    public class InternalServerErrorException : Exception // HTTP 500
    {
        public InternalServerErrorException() { }
        public InternalServerErrorException(string message) : base(message) { }
        public InternalServerErrorException(string message, Exception inner) : base(message, inner) { }
    }
}