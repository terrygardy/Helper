using System;

namespace Helpers.Exceptions
{
	public class DeleteNotAllowedException : Exception
	{
		private static string BaseMessage = "This object cannot be deleted";

		public DeleteNotAllowedException() : base(BaseMessage) { }

		public DeleteNotAllowedException(string pv_strMessage) : base(BaseMessage + ": " + pv_strMessage) { }

		public DeleteNotAllowedException(string pv_strMessage, Exception ex) : base(BaseMessage + ": " + pv_strMessage, ex) { }

		public DeleteNotAllowedException(Exception ex) : base(BaseMessage, ex) { }
	}
}
