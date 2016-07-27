using System;

namespace Helpers.Exceptions
{
	public class OperationException : Exception
	{
		private static string BaseMessage = "The current process is invalid";

		public OperationException(string pv_strMessage) : base(BaseMessage + ": " + pv_strMessage) { }

		public OperationException(string pv_strMessage, Exception ex) : base(BaseMessage + ": " + pv_strMessage, ex) { }

		public OperationException(Exception ex) : base(BaseMessage, ex) { }
	}
}
