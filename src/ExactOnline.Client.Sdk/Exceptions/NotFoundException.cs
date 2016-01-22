using System;
using System.Runtime.Serialization;

namespace ExactOnline.Client.Sdk.Exceptions
{
    [DataContract]
    public class NotFoundException : Exception // HTTP: 404
    {
        public NotFoundException() { }
        public NotFoundException(string message) : base(message) { }
        public NotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}