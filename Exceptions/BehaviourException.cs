using System;

namespace Helpers.Exceptions
{
	public class BehaviourException : Exception
	{
		private static string BaseMessage = "This action is invalid";

		public BehaviourException(string pv_strMessage) : base(BaseMessage + ": " + pv_strMessage) { }

		public BehaviourException(string pv_strMessage, Exception ex) : base(BaseMessage + ": " + pv_strMessage, ex) { }

		public BehaviourException(Exception ex) : base(BaseMessage, ex) { }
	}
}
