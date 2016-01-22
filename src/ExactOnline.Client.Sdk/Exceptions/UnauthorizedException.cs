using System;
using System.Runtime.Serialization;

namespace ExactOnline.Client.Sdk.Exceptions
{
    [DataContract]
    public class UnauthorizedException : Exception // HTTP: 401
    {
        public UnauthorizedException() { }
        public UnauthorizedException(string message) : base(message) { }
        public UnauthorizedException(string message, Exception inner) : base(message, inner) { }
    }
}