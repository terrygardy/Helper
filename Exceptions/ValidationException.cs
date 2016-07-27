using System;

namespace Helpers.Exceptions
{
	public class ValidationException : Exception
	{
		private static string BaseMessage = "The entity could not be validated";

		public ValidationException(string pv_strMessage) : base(BaseMessage + ": " + pv_strMessage) { }

		public ValidationException(string pv_strMessage, Exception ex) : base(BaseMessage + ": " + pv_strMessage, ex) { }

		public ValidationException(Exception ex) : base(BaseMessage, ex) { }
	}
}
