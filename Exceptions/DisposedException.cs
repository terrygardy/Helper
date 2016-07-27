using System;

namespace Helpers.Exceptions
{
	public class DisposedException : Exception
	{
		private static string BaseMessage = "Die database connection has been closed";

		public DisposedException(string pv_strMessage) : base(BaseMessage + ": " + pv_strMessage) { }

		public DisposedException(string pv_strMessage, Exception ex) : base(BaseMessage + ": " + pv_strMessage, ex) { }

		public DisposedException(Exception ex) : base(BaseMessage, ex) { }
	}
}
