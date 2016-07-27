using System;

namespace Helpers.Exceptions
{
	public class UpdateException : Exception
	{
		private static string BaseMessage = "An error occurred while updating";

		public UpdateException(string pv_strMessage) : base(BaseMessage + ": " + pv_strMessage) { }

		public UpdateException(string pv_strMessage, Exception ex) : base(BaseMessage + ": " + pv_strMessage, ex) { }

		public UpdateException(Exception ex) : base(BaseMessage, ex) { }
	}
}
