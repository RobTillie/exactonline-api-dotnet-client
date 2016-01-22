using System;
using System.Runtime.Serialization;

namespace ExactOnline.Client.Sdk.Exceptions
{
    [DataContract]
    public class ForbiddenException : Exception // HTTP: 403 
    {
        public ForbiddenException() { }
        public ForbiddenException(string message) : base(message) { }
        public ForbiddenException(string message, Exception inner) : base(message, inner) { }
    }
}