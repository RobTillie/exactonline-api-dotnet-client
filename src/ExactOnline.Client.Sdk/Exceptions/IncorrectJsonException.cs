using System;
using System.Runtime.Serialization;

namespace ExactOnline.Client.Sdk.Exceptions
{
	[DataContract]
	public class IncorrectJsonException : Exception
	{
		public IncorrectJsonException()
		{
		}

		public IncorrectJsonException(string message)
			: base(message)
		{
		}
	}
}
